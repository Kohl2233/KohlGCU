#!/bin/bash
echo "##### Creating New Directory #####"
mkdir testdir
ls
echo "##### Removing Created Directory #####"
rmdir testdir
ls
echo "##### Running GCC on ProgramPractice.c #####"
gcc ProgramPractice.c -oProgramPractice.out
ls
echo "##### Showing Active User #####"
whoami
echo "##### DONE! #####"
