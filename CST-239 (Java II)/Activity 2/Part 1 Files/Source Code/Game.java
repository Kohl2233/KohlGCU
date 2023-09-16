package app;

import java.util.Random;

public class Game {
	public static void main(String[] args) {
		// Get Two Random Health Values Between 1 - 1000
		Random randy = new Random();
		int health1 = randy.nextInt(999) + 1;
		int health2 = randy.nextInt(999) + 1;
		
		// Create Batman and Superman SuperHero Objects
		Batman batman = new Batman(health1);
		Superman superman = new Superman(health2);
		
		// Fight to the Death
		boolean supermanDead = superman.isDead();
		boolean batmanDead = batman.isDead();
		while ((!supermanDead) && (!batmanDead)) {
			if (!supermanDead) {
				superman.attack(batman);
				batmanDead = batman.isDead();
			}
			if (!batmanDead) {
				batman.attack(superman);
				supermanDead = superman.isDead();
			}
		}
		
		// Display Results
		if (supermanDead) {
			System.out.println("Batman has won the game!");
		} else {
			System.out.println("Superman has won the game!");
		}
	}
}
