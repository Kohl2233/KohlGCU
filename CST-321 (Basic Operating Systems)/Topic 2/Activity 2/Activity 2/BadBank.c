#include <stdio.h>
#include <stdlib.h>
#include <unistd.h>
#include <pthread.h>
#include <semaphore.h>

// Globals
int BANK_BALANCE = 0;
sem_t semaphore;

void *deposit(void *a) {
	for (int i = 0; i < 1000000; i++) {
		sem_wait(&semaphore);

		BANK_BALANCE++;
		printf("DEPOSIT -- Amount: $1, new balance: %d\n", BANK_BALANCE);

		sem_post(&semaphore);
	}
	pthread_exit(NULL);
}

int main(int argc, char const *argv[])
{
	pthread_t tid1, tid2;

	// Spawn Threads
	sem_init(&semaphore, 0, 1);

	if (pthread_create(&tid1, NULL, deposit, NULL)) {
		printf("ERROR creating tid1.\n");
		exit(1);
	}
	if (pthread_create(&tid2, NULL, deposit, NULL)) {
		printf("ERROR creating tid2.\n");
		exit(1);
	}

	// Wait for Threads to Finish
	if (pthread_join(tid1, NULL)) {
		printf("ERROR joining thread 1.\n");
		exit(1);
	}
	if (pthread_join(tid2, NULL)) {
		printf("ERROR joinging thread 2.\n");
		exit(1);
	}

	// After Threads Done
	printf("\n\nEND BALANCE: %d\n", BANK_BALANCE);

	// Cleanup
	sem_destroy(&semaphore);
	pthread_exit(NULL);
}