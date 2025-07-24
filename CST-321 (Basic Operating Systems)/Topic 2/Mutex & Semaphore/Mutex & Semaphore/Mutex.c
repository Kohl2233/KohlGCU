/*
	Created by Kohl Johnson on 12-15-2024
	Scenario: Phone booth
*/

#include <stdio.h>
#include <stdlib.h>
#include <unistd.h>
#include <pthread.h>

// Globals
int TOTAL_CALLS_MADE = 0; // running total of calls made
pthread_mutex_t mutex = PTHREAD_MUTEX_INITIALIZER; // mutex init

// Thread Function
void *makeCall(void *a) {
	for (int i = 0; i < 1000000; i++) {
		// -- Start Critical Region
		pthread_mutex_lock(&mutex); // lock

		TOTAL_CALLS_MADE += 1;

		pthread_mutex_unlock(&mutex); // unlock
		// -- End Critical Region
	}
	pthread_exit(NULL);
}

// Main Function
int main(int argc, char const *argv[])
{
	pthread_t tid1, tid2;

	// Spawn Threads
	if (pthread_create(&tid1, NULL, makeCall, NULL)) {
		printf("ERROR creating thread 1.\n");
		exit(1);
	}
	if (pthread_create(&tid2, NULL, makeCall, NULL)) {
		printf("ERROR creating thread 2.\n");
		exit(1);
	}

	// Join Threads (wait for finish)
	if (pthread_join(tid1, NULL)) {
		printf("ERROR joining thread 1.\n");
		exit(1);
	}
	if (pthread_join(tid2, NULL)) {
		printf("ERROR joinging thread 2.\n");
		exit(1);
	}

	// Print Stats
	printf("\n\nTotal Calls Made: %d\n", TOTAL_CALLS_MADE);

	return 0;
}