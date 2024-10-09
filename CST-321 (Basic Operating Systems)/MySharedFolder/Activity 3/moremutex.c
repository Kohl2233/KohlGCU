#include <stdio.h>
#include <stdlib.h>
#include <unistd.h>
#include <pthread.h>
#include <errno.h>


int counter = 0;
int end_time;
pthread_mutex_t mutex = PTHREAD_MUTEX_INITIALIZER; // mutex init

void *counter_thread(void *args) {
	int status;

	while (time (NULL) < end_time) {
		// Enter Critical Region
		status = pthread_mutex_lock(&mutex);
		if (status == 0) {
			printf("Counter Thread: locked mutex so counter could be incremented.\n");
		}
		counter++;
		sleep(1); // hog the mutex
		status = pthread_mutex_unlock(&mutex);
		if (status == 0) {
			printf("Counter Thread: Unlocked mutex since counter is done being incremented.\n");
		}
		// Exit Critical Region
	}

	// print final stats
	printf("Final Counter: %d\n", counter);
	return NULL;
}

void *monitor_thread(void *args) {
	int status;
	int misses = 0;

	while (time (NULL) < end_time) {
		status = pthread_mutex_trylock(&mutex);
		if (status != EBUSY) {
			printf("	Monitor Thread: the trylock will lcok the mutex to safely read counter value.\n");
			printf("	Monitor Thread: value of counter is %d\n", counter);
			status = pthread_mutex_unlock(&mutex);
			if (status == 0) {
				printf("	Monitor Thread: mutex is now being unlocked.\n");
			}
		} else {
			misses++;
		}
		sleep(3);
	}

	// print out stats
	printf("Final Misses: %d\n", misses);
	return NULL;
}



int main(int argc, char const *argv[])
{
	int status;
	pthread_t counter_thread_id;
	pthread_t monitor_thread_id;

	// set the end time
	end_time = time (NULL) + 10; // 60 seconds from now

	// create counter and monitor threads
	if (pthread_create(&counter_thread_id, NULL, counter_thread, NULL)) {
		printf("failed to create counter thread.\n");
	}
	if (pthread_create(&monitor_thread_id, NULL, monitor_thread, NULL)) {
		printf("failed to create monitor thread.\n");
	}

	// wait for both threads to finish
	if (pthread_join(counter_thread_id, NULL)) {
		printf("failed to join counter thread.\n");
	}
	if (pthread_join(monitor_thread_id, NULL)) {
		printf("failed to join monitor thread.\n");
	}

	// exit ok
	return 0;
}