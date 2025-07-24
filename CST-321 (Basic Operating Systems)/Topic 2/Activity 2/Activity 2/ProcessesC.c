#include <stdio.h>
#include <string.h>
#include <unistd.h>
#include <stdlib.h>
#include <spawn.h>
#include <sys/wait.h>

extern char **environ;

void run_cmd(char *cmd) {
	pid_t pid;
	char *argv[] = {"sh", "-c", cmd, NULL};
	int status;

	// Spawn provided command
	printf("Executing %s\n", cmd);
	status = posix_spawn(&pid, "/bin/sh", NULL, NULL, argv, environ);
	if (status == 0) {
		// all is good, print pid and wait for process to finish
		printf("Child Process ID: %i\n", pid);
		if (waitpid(pid, &status, 0) != -1) {
			printf("Child process exited with status %i\n", status);
		}
	} else {
		// give an error
		printf("Child process did not spawn, error: '%s'\n", strerror(status));
	}
}

int main(int argc, char *argv[])
{
	run_cmd(argv[1]);
	return 0;
}