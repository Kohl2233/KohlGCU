/*
	Created by Kohl Johnson on 12-15-2024
*/

#include <stdio.h>
#include <stdlib.h>
#include <unistd.h>
#include <pthread.h>
#include <signal.h>



// ---------- Globals ----------
enum { SIZE = 10 }; // size of buffer
int BUFFER [SIZE]; // our buffer integer array
int WRITE_INDEX = 0; // index to write (upper)
int READ_INDEX = 0; // index to read (lower)
pthread_mutex_t MUTEX = PTHREAD_MUTEX_INITIALIZER; // mutex init



// ---------- Signals ----------




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

int get(int * value) {
	// check if buffer is empty
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
// responsible for creating numbers, inserting them into circular buffer, and send "data added" signal to consumer
void *producer() {
	
	while(1) {
		int writeVal = rand() % 20; // random num between 0 and 19

		// --- Critical Region Start ---
		pthread_mutex_lock(&MUTEX); // lock
		// try putting into buffer
		int status = put(writeVal);
		pthread_mutex_unlock(&MUTEX);
		// --- Critical Region End ---

		if (status) {
			// success
			printf("Producer: SUCCESSFULLY added value of %d to buffer.\n", writeVal);
		} else {
			// failed
			printf("Producer: FAILED to add value to buffer...\n");
		}
		sleep(1);
	}
	_exit(1);
}

// Consumer Thread
// responsible for "consuming" numbers, removing them from the circular buffer, and send "more room" signal to producer
void *consumer() {
	while(1) {
		// --- Critical Region Start ---
		pthread_mutex_lock(&MUTEX);
		// try reading from buffer
		int value;
		int status = get(&value);
		pthread_mutex_unlock(&MUTEX);
		// --- Critical Region End ---
		
		if (status) {
			// success
			printf("Consumer: SUCCESSFULLY retrieved a value of %d from buffer.\n", value);
			// send "more room" signal
		} else {
			// failed
			printf("Consumer: FAILED to retrieve value from buffer...\n");
		}
		sleep(2);
	}
	return NULL;
}



// ---------- Main Function -----------
int main(int argc, char const *argv[])
{
	printf("\n\nStarting Threads...\n\n");

	pthread_t tid1, tid2;

	// create two threads
	if (pthread_create(&tid1, NULL, producer, NULL)) {
		printf("ERROR creating producer thread.\n");
		exit(1);
	}
	if (pthread_create(&tid2, NULL, consumer, NULL)) {
		printf("ERROR creating consumer thread.\n");
		exit(1);
	}

	// Wait for threads to finish
	if (pthread_join(tid1, NULL)) {
		printf("ERROR joining producer thread.\n");
		exit(1);
	}
	if (pthread_join(tid2, NULL)) {
		printf("ERROR joining consumer thread.\n");
		exit(1);
	}

	// Cleanup Threads
	pthread_exit(NULL);
}