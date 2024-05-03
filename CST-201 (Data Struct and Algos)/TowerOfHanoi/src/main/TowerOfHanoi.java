package main;

import java.util.Scanner;

/* ----- Resources -----
 * General Overview: https://www.geeksforgeeks.org/c-program-for-tower-of-hanoi/
 * Understanding Cases: https://www.geeksforgeeks.org/iterative-tower-of-hanoi/
 * More Help w/ Cases (visualizing): https://towersofhanoi.info/Animate.aspx
 * 
 */

public class TowerOfHanoi {

	public static void main(String[] args) {
		
		int numDisks = getInput();
		Pole source = createPole(numDisks);
		Pole aux = createPole(numDisks);
		Pole dest = createPole(numDisks);
		
		towerOfHanoi(numDisks, source, aux, dest);
	}
	
	
	
	// Method to Get User Input
	static int getInput() {
		Scanner scan = new Scanner(System.in);
		System.out.println("Enter an Integer: ");
		return scan.nextInt();
	}
	
	
	
	// Class to Represent a Pole
	static class Pole {
		int capacity; // how many disks a pole can have
		int top; // holds the top most disk
		int disks[]; // keeps track of all disks in pole
	}
	
	
	
	// Method to Create a Pole
	static Pole createPole(int capacity) {
		Pole pole = new Pole();
		pole.capacity = capacity;
		pole.top = -1;
		pole.disks = new int[pole.capacity];
		return pole;
	}
	
	
	// Method to Check if Pole is Full
	static boolean isFull(Pole pole) {
		// an empty pole with have the top disk set to -1
		return (pole.top == pole.capacity - 1);
	}
	
	
	
	// Method to Check if Pole is Empty
	static boolean isEmpty(Pole pole) {
		return (pole.top == -1);
	}
	
	
	
	// Method to Add a Disk to Pole
	static void addToPole(Pole pole, int disk) {
		if (!isFull(pole)) {
			pole.disks[++pole.top] = disk;
		}
	}
	
	
	
	// Method to Remove a Disk from Pole
	static int removeFromPole(Pole pole) {
		if (isEmpty(pole)) {
			return -2;
		}
		
		return pole.disks[pole.top--];
	}
	
	
	
	// Method to Move Between two Poles
	static void moveDisksTwoPoles(Pole source, Pole dest, char s, char d, int moveNum) {
		int pole1TopDisk = removeFromPole(source);
		int pole2TopDisk = removeFromPole(dest);
		
		// Check if Pole 1 is Empty
		if (pole1TopDisk == -2) {
			// move pole2 disk to pole1, print move
			addToPole(source, pole2TopDisk);
			printMove(d, s, pole2TopDisk, moveNum);
		// Check if Pole 2 is Empty
		} else if (pole2TopDisk == -2) {
			// move pole1 disk to pole2, print move
			addToPole(dest, pole1TopDisk);
			printMove(s, d, pole1TopDisk, moveNum);
		// Check if Top Disk of Pole 1 > Top Disk of Pole 2
		} else if (pole1TopDisk > pole2TopDisk) {
			addToPole(source, pole1TopDisk); // add pole1 disk back to source pole
			addToPole(source, pole2TopDisk); // add pole2 disk to source pole
			printMove(d, s, pole2TopDisk, moveNum);
		// Top Disk of Pole 1 < Top Disk of Pole 2
		} else {
			addToPole(dest, pole2TopDisk); // add pole2 disk back to dest pole
			addToPole(dest, pole1TopDisk); // add pole1 disk to dest pole
			printMove(s, d, pole1TopDisk, moveNum); // print move
		}
	}
	
	
	
	// Method to Output Print Move
	static void printMove(char fromPole, char toPole, int disk, int moveNum) {
		System.out.printf("Move %d: Moving disc %d from pole %c to pole %c.\n", moveNum, disk, fromPole, toPole);
	}
	
	
	
	// Tower of Hanoi Algo
	static void towerOfHanoi(int numDisks, Pole source, Pole aux, Pole dest) {
		int i, numMoves;
		char s = 'S', d = 'D', a = 'A'; // 'names' of poles S = source, D = destination, A = auxiliary (or middle one)
		
		// Check if Num Disks is Even
		if (numDisks % 2 == 0) {
			// interchange dest pole and aux pole
			char temp = d;
			d = a;
			a = temp;
		}
		
		// Calc Total Num of Moves
		numMoves = (int)(Math.pow(2,  numDisks) - 1);
		
		// Add Disks to Source Pole
		for (i = numDisks; i >= 1; i--) {
			addToPole(source, i);
		}
		
		// Move Disks
		for (i = 1; i <= numMoves; i++) {
			if (i % 3 == 1) {
				moveDisksTwoPoles(source, dest, s, d, i);
			} else if (i % 3 == 2) {
				moveDisksTwoPoles(source, aux, s, a, i);
			} else if (i % 3 == 0) {
				moveDisksTwoPoles(aux, dest, a, d, i);
			}
		}
		
		System.out.printf("\n\nDone! Total Num of Moves: %d", numMoves);
	}
}
