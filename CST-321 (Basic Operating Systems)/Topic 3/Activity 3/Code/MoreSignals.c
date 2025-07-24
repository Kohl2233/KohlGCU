// Created By: Kohl Johnson
// Create Date: 12-21-2024


#include <stdio.h>
#include <unistd.h>
#include <stdlib.h>
#include <signal.h>
#include <sys/mman.h>
#include <err.h>
#include <errno.h>
#include <string.h>

struct CIRCULAR_BUFFER *buffer = NULL;
int MAX = 100;
int WAKEUP = SIGUSR1;
int SLEEP = SIGUSR2;

sigset_t sigSet; // the signal set
pid_t otherPid; // id of child (if parent) or parent (if child)


// Circular Buffer
struct CIRCULAR_BUFFER {
	int count;			// current number of items in buffer
	int lower;			// next slot to read (get) in buffer
	int upper;			// next slot to write (set) in buffer
	int buffer[100];	// buffer contents
};

// Puts current Process to Sleep until WAKEUP Signal Recieved
void sleepAndWait() {
	int nSig;
	printf("Sleepin......\n");
	sigwait(&sigSet, &nSig);
	printf("Awoken.\n");
}

// Will Send the Other Method the WAKEUP Signal
// done by killing the sleep signal (i think)
void wakeUpOther() {
	kill(otherPid, WAKEUP);
}

// Gets a Value from the Shared Buffer
int getValue() {
	int value = buffer->buffer[buffer->lower];
	printf("CONSUMER: consumer read a value of %c\n", value);
	++buffer->lower;
	if (buffer->lower == MAX) {
		buffer->lower = 0;
	}
	--buffer->count;
	return value;
}

// Sets a Value into the Shared Buffer
void putValue(int value) {
	buffer->buffer[buffer->upper] = value;
	printf("PRODUCER: producer stored value of %c\n", buffer->buffer[buffer->upper]);
	++buffer->upper;
	if (buffer->upper == MAX) {
		buffer->upper = 0;
	}
	++buffer->count;
}

// Consumer Logic
void consumer() {
	// setup signal set
	sigemptyset(&sigSet);
	sigaddset(&sigSet, WAKEUP);
	sigprocmask(SIG_BLOCK, &sigSet, NULL);

	// confirmation message
	printf("Running the child consumer process....\n");

	// buffer reading until termination character is found
	int character = 0;
	do {
		sleepAndWait();				// wait to be notified of new character
		character = getValue();		// read character from shared buffer
	} while (character != 0);

	// exit cleanly
	printf("Exiting the child consumer process.\n");
	_exit(1);
}

// Producer Logic
void producer() {
	// confirmation message
	printf("Running the parent producer process...\n");

	// send desired message to child consumer process
	char message[13] = "Kohl Johnson";
	for (int x = 0; x < strlen(message); x++) {
		putValue(message[x]);
		wakeUpOther();
		sleep(1);
	}

	// tell consumer that full message has been sent
	putValue(0);
	wakeUpOther();

	// exit cleanly
	printf("Exiting the parent producer process.\n");
	_exit(1);
}

// Driver Code
int main(int argc, char const *argv[])
{
	pid_t pid;

	// create buffer
	buffer = (struct CIRCULAR_BUFFER*)mmap(0, sizeof(buffer), PROT_READ|PROT_WRITE, MAP_SHARED|MAP_ANONYMOUS, -1, 0);
	buffer->count = 0;
	buffer->upper = 0;
	buffer->lower = 0;

	// create consumer
	pid = fork();
	if (pid == -1) {
		printf("Failed to fork... %d\n", errno);
	}

	if (pid == 0) {
		// run producer logic as child
		otherPid = getppid();
		producer();
	} else {
		// run consumer logic as parent
		otherPid = pid;
		consumer();
	}

	// return ok
	return 0;
}