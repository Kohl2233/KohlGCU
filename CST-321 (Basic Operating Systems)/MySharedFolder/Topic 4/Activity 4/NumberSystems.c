// Created: 01-05-2025
// By: Kohl Johnson

#include <stdio.h>


// Function to Convert Decimal Number to Binary
void decimalToBinary(int number, int *array) {
	int i = 0;
	while (number > 0) {
		// store remainder in array
		array[i] = number % 2;
		number = number / 2;
		i++;
	}

	// print out in reverse
	printf("Decimal to Binary: ");
	for (int j = i - 1; j >= 0; j--) {
		printf("%d", array[j]);
	}
	printf("\n");
}



// Function to Shift Left by 10, Mask Lower 10 bits to 0, and Logically OR number of 0x3FF
int shiftMask(int number) {
	int result = 0;
	int maskResult = 0;
	int logicalOrResult = 0;

	// shift left by 10
	result = number << 10;
	printf("%d << 10 = %d\n", number, (number << 10));

	// mask lower 10 bits
	maskResult = ~result;
	printf("~%d = %d\n", result, maskResult);

	// logically OR 0x3FF (1023)
	logicalOrResult = maskResult | 1023;
	printf("%d | 1023 = %d\n\n", maskResult, logicalOrResult);

	return logicalOrResult;
}



// Function to Convert Decimal Number to Hexadecimal
void decimalToHexaDecimal(int number, char *hexa) {
	// variables
	int i = 1;
	int j, temp;

	// if decimal is not == 0 then enter into loop
	while (number != 0) {
		// convert to hexadecimal
		temp = number % 16;
		if (temp < 10) {
			temp = temp + 48;
		} else {
			temp = temp + 55;
		}
		hexa[i++] = temp;
		number = number / 16;
	}

	// hexadecimal printing
	printf("Decimal to Hex: ");
	for (int j = i - 1; j > 0; j--) {
		printf("%c", hexa[j]);
	}
	printf("\n");
}



int main(int argc, char const *argv[])
{
	// variables
	int input;
	int binary[32];
	char hexadecimal[100];
	int res = 0;

	// user input prompt
	printf("Enter a number between 1-1000: ");
	scanf("%d", &input);
	printf("\nYou entered %d\n", input);

	decimalToBinary(input, binary); // convert to binary
	decimalToHexaDecimal(input, hexadecimal); // convert to hexadecimal
	res = shiftMask(input); // shift, mask, logical OR

	decimalToBinary(res, binary);
	decimalToHexaDecimal(res, hexadecimal);

	return 0;
}