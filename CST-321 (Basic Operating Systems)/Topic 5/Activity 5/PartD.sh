#!/bin/bash


# set i
i=1;

# while i is less than equal to 10
while [ $i -le 10 ]
do
	# message
	echo "Iteration: $i"

	# increment i
	((i++))
done