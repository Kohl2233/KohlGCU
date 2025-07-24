#include <stdio.h>
#include <stdlib.h>
#include <unistd.h>
#include <pthread.h>

void *task1(void *a) {
	for (int i = 0; i < 10; i++) {
		printf("Task 1 Message: this is run number %d\n", i);
		sleep(1);
	}
	return NULL;
}

void *task2(void *a) {
	for (int i = 0; i < 10; i++) {
		printf("Task 2 Message: this is run number %d\n", i);
		sleep(2);
	}
	return NULL;
}

int main(int argc, char const *argv[])
{
	pthread_t tid1, tid2;

	// create two threads
	if (pthread_create(&tid1, NULL, task1, NULL)) {
		printf("ERROR creating task 1.\n");
		exit(1);
	}
	if (pthread_create(&tid2, NULL, task2, NULL)) {
		printf("ERROR creating task 2.\n");
		exit(1);
	}

	// Wait for threads to finish
	if (pthread_join(tid1, NULL)) {
		printf("ERROR joining thread 1.\n");
		exit(1);
	}
	if (pthread_join(tid2, NULL)) {
		printf("ERROR joinging thread 2.\n");
		exit(1);
	}

	// Cleanup Threads
	pthread_exit(NULL);
}