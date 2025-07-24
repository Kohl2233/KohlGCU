#!/bin/bash

PASSWORD=$1
PASS_LEN=${#PASSWORD}

# check requirements for min length 8 characters
if [ $PASS_LEN -gt 7 ]; then
	echo "PASSED: PASSWORD MEETS MIN LENGTH (length is: $PASS_LEN)"
else
	echo "FAILED: PASSWORD DOES NOT MEET MIN LENGTH (length is: $PASS_LEN)"
fi

# check requirement for at least one numeric character
if ! [[ "$PASSWORD" =~ [0-9] ]]; then
	echo "FAILED: PASSWORD DOES NOT CONTAIN ANY NUMERICS"
else
	echo "PASSED: PASSWORD CONTAINS AT LEAST ONE NUMERIC"
fi

# check requirement for at least one special character (@,#,$,%,*,+,=)
if [[ "$PASSWORD" == *[@#$%*+=]* ]]; then
	echo "PASSED: PASSWORD CONTAINS AT LEAST ONE SPECIAL CHAR"
else
	echo "FAILED: PASSWORD DOES NOT CONTAIN A SPECIAL CHAR"
fi