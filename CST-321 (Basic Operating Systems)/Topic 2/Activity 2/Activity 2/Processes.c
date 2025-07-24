#include <stdio.h>
#include <unistd.h>
#include <stdlib.h>
#include <sys/wait.h>
int main(int argc, char const *argv[])
{
	printf("Main ID: %d", (int)getpid());
	printf("\ncreating fork...\n\n");

	pid_t pid = fork();
	if (pid < 0) {
		// fork failed
		printf("failed to create fork..");
	}
	if (pid == 0) {
		// child thread code
		printf("i am the child with ID: %d, and parent ID: %d\n", (int)getpid(), (int)getppid());
		for (int i = 0; i < 10; i++){
			printf("this is child message number %d\n", i);
			sleep(1);
		}
		printf("\nchild process finished. Exiting..\n");
		exit(0);
	}

	// parent thread code
	for (int i = 0; i < 10; i++) {
		printf("parent message number %d\n", i);
		sleep(2);
	}
	wait(NULL);
	printf("\n\nParent is exiting.\n");
	return 1;
}