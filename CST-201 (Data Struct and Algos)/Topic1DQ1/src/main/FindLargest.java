package main;

import java.util.Random;


/* Sources
 * Timing: https://stackoverflow.com/questions/180158/how-do-i-time-a-methods-execution-in-java
 * Format Specifiers: https://docs.oracle.com/javase/8/docs/api/java/util/Formatter.html
 */
public class FindLargest {

	public static void main(String[] args) {
		int[] randoms = new int[100];
		Random randy = new Random();
		
		// Populate Array
		for (int i = 0; i < randoms.length; i++) {
			int num = randy.nextInt(1000); // random int from 0-999
			System.out.printf("%d,", num);
			randoms[i] = num;
		}
		
		long startTime = System.nanoTime();
		
		// Find Largest
		// Big O Notation: O(n)
		int largest = -1;
		for (int i = 0; i < randoms.length; i++) { // step 1
			if (randoms[i] > largest) { // step 2
				largest = randoms[i]; // step 3 (conditional)
			}
		}
		
		long endTime = System.nanoTime();
		double duration = (double)(endTime - startTime) / 1000000;
		
		// Output
		System.out.printf("\nLargest Num: %d\nTime Taken: %.4f ms", largest, duration);

	}

}
