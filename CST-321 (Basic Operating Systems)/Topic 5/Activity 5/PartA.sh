#!/bin/bash

# if number is greater than 50
if [ $1 -gt 50 ]; then
	echo "this number is greater than 50."
elif [ $1 -eq 50 ]; then
	echo "this number is equal to 50."
else
	echo "this number is less than 50."

fi