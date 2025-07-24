/*
	Created by Kohl Johnson on 12-15-2024
	Scenario: A parking garage that only holds X number of cars
*/

#include <stdio.h>
#include <stdlib.h>
#include <unistd.h>
#include <pthread.h>
#include <semaphore.h>

// Globals
int CAPACITY = 300000; // represents the available spots in parking garage
int ACTUAL_NUM_CARS = 0; // represents the running total of cars parked in garage
int CARS_PER_TURN = 1; // represents how many cars can go through a 'gate' each time
int COST_PER_SPOT = 2; // cost per parking spot
int REVENUE = 0; // how much we made owning a parking garage
sem_t semaphore; // our semaphore 

// Thread Function
// lets cars enter parking garage
void *garageGate(void *a) {
	for (int i = CAPACITY / 3; i > 0; i--) {
		// -- Start Critical Region
		sem_wait(&semaphore);

		// take payment
		REVENUE += COST_PER_SPOT;

		// Add car to Actual Num Cars
		ACTUAL_NUM_CARS += CARS_PER_TURN;

		sem_post(&semaphore);
		// -- End Critical Region
	}
}

// Main Program Function
int main(int argc, char const *argv[])
{
	pthread_t tid1, tid2, tid3;

	// Init Semaphore
	sem_init(&semaphore, 0, 1);

	// Spawn Threads (create 3 gates)
	printf("\n\nStarting threads...\n\n");
	if (pthread_create(&tid1, NULL, garageGate, NULL)) {
		printf("ERROR creating gate 1.\n");
		exit(1);
	}
	if (pthread_create(&tid2, NULL, garageGate, NULL)) {
		printf("ERROR creating gate 2.\n");
		exit(1);
	}
	if (pthread_create(&tid3, NULL, garageGate, NULL)) {
		printf("ERROR creating gate 3.\n");
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
	if (pthread_join(tid3, NULL)) {
		printf("ERROR joining thread 3.\n");
		exit(1);
	}

	// Print Stats
	printf("\n\n----- GARAGE STATS -----\n");
	printf("Used Spots: %d\n", ACTUAL_NUM_CARS);
	printf("Spots Remaining: %d\n", CAPACITY - ACTUAL_NUM_CARS);
	printf("Revenue: $%d\n\n", REVENUE);

	// Cleanup
	sem_destroy(&semaphore);
	return 0;
}