/*
	Created by Kohl Johnson on 12-15-2024
*/

#include <stdio.h>
#include <stdlib.h>
#include <unistd.h>
#include <pthread.h>
#include <signal.h>
#include <sys/wait.h>



// ---------- Globals ----------
enum { SIZE = 10 }; // size of buffer
int BUFFER [SIZE]; // our buffer integer array
int WRITE_INDEX = 0; // index to write (upper)
int READ_INDEX = 0; // index to read (lower)



// ---------- Signals ----------
int WAKEUP = SIGUSR1;
pid_t otherPid;
sigset_t sigset;

void sleepUntilAwoken() {
	int nSig;
	printf("sleepin...\n");
	sigwait(&sigset, &nSig);
	printf("we have awoken.\n");
}


// ---------- Circle Buffer Functions ----------
int put(int value) {
	// check if buffer is full
	if ((WRITE_INDEX + 1) % SIZE == READ_INDEX) {
		// buffer is full
		return 0;
	}

	// not full
	BUFFER[WRITE_INDEX] = value; // insert val
	WRITE_INDEX = (WRITE_INDEX + 1) % SIZE; // set new write index
	return 1;
}

int get(int *value) {
	// check if buffer is empty
	printf("----- inside get() read index: %d write index: %d\n", READ_INDEX, WRITE_INDEX);
	if (READ_INDEX == WRITE_INDEX) {
		// buffer is empty
		return 0;
	}

	// not empty
	*value = BUFFER[READ_INDEX]; // get value from buffer
	READ_INDEX = (READ_INDEX + 1) % SIZE; // set new read index
	return 1;
}



// ---------- Producer and Consumer Thread Functions ----------

// Producer Thread
// responsible for creating numbers, inserting them into circular buffer, and send AWAKE signal to consumer
void producer() {
	sigemptyset(&sigset);
	sigaddset(&sigset, WAKEUP);
	sigprocmask(SIG_BLOCK, &sigset, NULL);

	printf("Producer Thread Created with ID: %d\n", (int)getpid());

	while(1) {
		int writeVal = rand() % 20; // random num between 0 and 19

		// try putting into buffer
		int attemptedWriteIndex = WRITE_INDEX;
		int status = put(writeVal);

		if (status) {
			// success
			printf("Producer: SUCCESSFULLY added value of %d to buffer index %d.\n", writeVal, attemptedWriteIndex);
		} else {
			// failed
			printf("Producer: FAILED to add value to buffer index %d...\n", attemptedWriteIndex);
		}
		sleep(1);
	}
	exit(0);
}

// Consumer Thread
// responsible for "consuming" numbers, removing them from the circular buffer, and send AWAKE signal to producer
void consumer() {
	sigemptyset(&sigset);
	sigaddset(&sigset, WAKEUP);
	sigprocmask(SIG_BLOCK, &sigset, NULL);

	printf("Consumer Thread Created with ID: %d\n", (int)getpid());

	while(1) {
		// try reading from buffer
		int attemptedReadIndex = READ_INDEX;
		int value;
		int status = get(&value);
		printf("----- status from get(): %d\n", status);
		if (status) {
			// success
			printf("Consumer: SUCCESSFULLY retrieved a value of %d from buffer index %d.\n", value, attemptedReadIndex);
			// send "more room" signal
		} else {
			// failed
			printf("Consumer: FAILED to retrieve value from buffer index %d...\n", attemptedReadIndex);
		}
		sleep(1);
	}
	exit(0);
}



// ---------- Main Function -----------
int main(int argc, char const *argv[])
{
	pid_t pid;
	pid = fork();
	if (pid == -1) {
		printf("Unable to fork");
		exit(EXIT_FAILURE);
	}
	if (pid == 0) {
		// run as child, (consumer)
		otherPid = getppid();
		consumer();
	} else {
		// run as parent, (producer)
		otherPid = pid;
		producer();
	}
	wait(NULL);
	return 0;
}