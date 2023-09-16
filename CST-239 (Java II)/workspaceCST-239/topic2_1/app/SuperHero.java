package app;

import java.util.Random;

public class SuperHero {
	private String name;
	private int health;
	private boolean isDead;
	
	public SuperHero(String name, int health) {
		this.name = name;
		this.health = health;
	}
	
	private void determineHealth(int damage) {
		if (this.health - damage <= 0) {
			this.health = 0;
			this.isDead = true;
		} else {
			this.health = this.health - damage;
		}
	}
	
	public boolean isDead() {
		return this.isDead;
	}
	
	public void attack(SuperHero opponent) {
		Random randy = new Random();
		int damage = randy.ints(1, (10 + 1)).findFirst().getAsInt();
		
		// Set Health of the Provided Opponent
		opponent.determineHealth(damage);
		System.out.printf("%s has taken damage of %d and now has health of %d.\n", opponent.name, damage, opponent.health);
	}
}
