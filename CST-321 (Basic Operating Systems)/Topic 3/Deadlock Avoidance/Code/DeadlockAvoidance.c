#include <stdio.h>
#include <stdlib.h>
#include <unistd.h>
#include <signal.h>
#include <semaphore.h>
#include <pthread.h>
#include <sys/mman.h>
#include <time.h>



// Globals
sem_t* semaphore;
pid_t otherPid;
sigset_t sigSet;



// Signal Handler
void signalHandler(int signum) {
	printf("Caught Signal: %d\n", signum);
	printf("	Exit Child Process.\n");
	sem_post(semaphore);
	_exit(0);
}



// Signal Handler 2
void signalHandler2(int signum) {
	printf("I am alive!\n");
}


// Hung Process Checker Function
void *checkHungChild(void *a) {
	int* status = a;
	printf("Checking for hung child process......\n");
	sleep(10);
	if (sem_trywait(semaphore) != 0) {
		printf("child process seems to be hung......\n");
		*status = 1;
	} else {
		printf("child process appears to be fine.\n");
		*status = 0;
	}
	return NULL;
}



// Worker Process Logic
void workerProcess() {
	// setup signal handlers
	signal(SIGUSR1, signalHandler);
	signal(SIGUSR2, signalHandler2);

	// random init
	srand(time(NULL));

	FILE *fp = fopen("output.txt", "w"); // open file for writing

	
	// simulate a complicated process
	printf("---------- Child Process Log:\n");
	printf("	Child process is grabbing semaphore.\n");
	sem_wait(semaphore);

	// ----- Start Critical Region ----
	int processLength = rand() % 30 + 15; // random length of 15-44
	printf("	Starting %d second process......\n", processLength);
	fprintf(fp, "	 Starting %d second process......\n", processLength);
	for (int x = 0; x <= processLength; x++) {
		printf("	on task %d/%d (%.2f%%)\n", x, processLength, (double)x / (double)processLength * 100);
		fprintf(fp, "	 on task %d/%d (%.2f%%)\n", x, processLength, (double)x / (double)processLength * 100);
		sleep(1);
	}
	fclose(fp);
	sem_post(semaphore);
	// ----- End Critical Region
	

	printf("---------- Exiting Child Process.\n");
	_exit(0);
}



// Parent Process Logic
void parentProcess() {
	// detect hung child process and kill after timeout
	sleep(2);

	// try to get semaphore
	if (sem_trywait(semaphore) != 0) {
		// start a timer thread and wait for it to return
		pthread_t tid1;
		int status = 0;
		if (pthread_create(&tid1, NULL, checkHungChild, &status)) {
			printf("failed to create timer thread.\n");
			_exit(1);
		}
		if (pthread_join(tid1, NULL)) {
			printf("failed to join timer thread.\n");
			exit(1);
		}

		// check if child needs to be killed
		if (status == 1) {
			int decision = -1;
			// pause other process ask user if they want to terminate
			kill(otherPid, SIGSTOP); // 'pause' worker process
			printf("Detected a hung process, should we kill it? (1 = yes no = 0)\n");
			scanf("%d", &decision);

			if (decision == 1) {
				// kill process
				printf("Going to kill process with id of %d\n", otherPid);
				kill(otherPid, SIGTERM);
				printf("killed child process.\n");


				// prove that process is killed
				printf("now proving child process is killed...\n");
				sleep(5);
				kill(otherPid, SIGUSR2);
				sleep(1);
				printf("Done proving child process is killed.\n");

				// try to get semaphore
				if (sem_trywait(semaphore) != 0) {
					sem_post(semaphore);
					printf("cleaned up and got the semaphore.\n");
				} else {
					printf("got the semaphore.\n");
				}
			} else {
				kill(otherPid, SIGCONT); // resume worker process
			}
		}
	}

	// exit cleanly
	printf("exiting parent process\n");
	_exit(0);
}



// Driver Code
int main(int argc, char const *argv[])
{
	pid_t pid;

	// create shared semaphore
	semaphore = (sem_t*)mmap(0, sizeof(sem_t), PROT_READ|PROT_WRITE,MAP_SHARED|MAP_ANONYMOUS, -1, 0);
	if (sem_init(semaphore, 1, 1) != 0) {
		printf("Failed to create semaphore.\n");
		exit(EXIT_FAILURE);
	}

	pid = fork();
	if (pid == -1) {
		printf("unable to fork, error.\n");
		exit(EXIT_FAILURE);
	}

	if (pid == 0) {
		// run child process logic
		printf("Main: Started worker process with id of %d\n", getpid());
		otherPid = getppid();
		workerProcess();
	} else {
		// run parent process logic
		printf("Main: Started parent process with id of %d\n", getpid());
		otherPid = pid;
		parentProcess();
	}

	// cleanup
	sem_destroy(semaphore);

	// return ok
	return 0;
}