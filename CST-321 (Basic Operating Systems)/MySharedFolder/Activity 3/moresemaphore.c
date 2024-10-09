#include <stdio.h>
#include <stdlib.h>
#include <unistd.h>
#include <signal.h>
#include <semaphore.h>
#include <pthread.h>
#include <sys/mman.h>

// Global Variables
sem_t* semaphore;
pid_t otherPid;
sigset_t sigSet;

void signalHandler(int signum) {
	printf("Caught Signal: %d\n", signum);
	printf("	Exit Child Process.\n");
	sem_post(semaphore);
	_exit(0);
}

void signalHandler2(int signum) {
	printf("I am alive!\n");
}

void childProcess() {
	// setup signal handlers
	signal(SIGUSR1, signalHandler);
	signal(SIGUSR2, signalHandler2);

	// simulate a hung process
	int value;
	sem_getvalue(semaphore, &value);
	printf("	Child process semaphore count is %d\n", value);
	printf("	Child process is grabbing semaphore.\n");
	sem_wait(semaphore);
	sem_getvalue(semaphore, &value);
	printf("	Child process semaphore count is %d\n", value);
	// ----- Start Critical Region ----
	printf("	Starting very long process\n");
	for (int x = 0; x < 60; x++) {
		printf("on task %d...\n", x);
		sleep(1);
	}
	sem_post(semaphore);
	// ----- End Critical Region

	printf("	Exit Child Process.\n");
	_exit(0);
}


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

void parentProcess() {
	// detect hung child process and kill after timeout
	sleep(2);
	if (getpgid(otherPid) >= 0) {
		printf("Child process is running......\n");
	}
	int value;
	sem_getvalue(semaphore, &value);
	printf("In parent process with the semahpore count of %d\n", value);

	// try to get semaphore
	if (sem_trywait(semaphore) != 0) {
		// start a timer thread and wait for it to return
		pthread_t tid1;
		int status = 0;
		printf("Detected child is hung or running too long....\n");
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
			sem_getvalue(semaphore, &value);
			printf("in parent process with semaphore count of %d\n", value);
			if (sem_trywait(semaphore) != 0) {
				if (value == 0) {
					sem_post(semaphore);
				}
				printf("cleaned up and got the semaphore.\n");
				sem_getvalue(semaphore, &value);
				printf("in parent process with semaphore count of %d\n.", value);
			} else {
				printf("got the semaphore.\n");
			}
		}
	}

	// exit cleanly
	printf("exiting parent process\n");
	_exit(0);
}

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
		printf("	Started child process with id of %d\n", getpid());
		otherPid = getppid();
		childProcess();
	} else {
		// run parent process logic
		printf("Started parent process with id of %d\n", getpid());
		otherPid = pid;
		parentProcess();
	}

	// cleanup
	sem_destroy(semaphore);

	// return ok
	return 0;
}