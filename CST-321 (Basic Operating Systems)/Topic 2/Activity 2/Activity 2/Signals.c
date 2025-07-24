#include <stdio.h>
#include <unistd.h>
#include <stdlib.h>
#include <signal.h>
#include <sys/mman.h>
#include <err.h>
#include <errno.h>

// constants
int WAKEUP = SIGUSR1;
pid_t otherPid;
sigset_t sigset;


void sleepUntilAwoken() {
	int nSig;
	printf("sleepin\n");
	sigwait(&sigset, &nSig);
	printf("we have awoken...\n");
}

void producer() {
	// run for 30 iterations, send signal at iteration 5
	for (int i = 0; i < 30; i++) {
		printf("Producer message number %d\n", i);
		if (i == 4) {
			printf("time to awake consumer\n");
			kill(otherPid, WAKEUP);

		}
		sleep(1);
	}
	_exit(1);
}

void consumer() {
	sigemptyset(&sigset);
	sigaddset(&sigset, WAKEUP);
	sigprocmask(SIG_BLOCK, &sigset, NULL);

	sleepUntilAwoken();

	for (int i = 0; i < 20; i++) {
		printf("consumer message number %d\n", i);
		sleep(1);
	}
	_exit(1);
}

int main(int argc, char *argv[])
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
	return 0;
}