#!/bin/bash

# name to search for
searchName="Kohl"

# read in names from names.txt
# store in array
names=($(cat "names.txt" | sort))

# iterate through it with for loop
for name in "${names[@]}"
do
	# print out the name
	echo "Name: $name"

	# check if its the search name
	if [[ $name == $searchName ]]; then
		echo "----- Found Match ------"
	fi
done