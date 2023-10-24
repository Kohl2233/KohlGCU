package junit;

import static org.junit.Assert.*;

import org.junit.Assert;
import org.junit.Test;

import app.Weapon;

public class WeaponTest {
	@Test
	public void testSetDamage() {
		Weapon weapon = new Weapon("Sword", "Weapon", 1, 9.99, "This is a sword", 10, 8, "Iron", 5);
		weapon.setDamage(5);
		Assert.assertEquals(weapon.getDamage(), 5);
	}

	@Test
	public void testSetDurability() {
		Weapon weapon = new Weapon("Sword", "Weapon", 1, 9.99, "This is a sword", 10, 8, "Iron", 5);
		weapon.setDurability(5);
		Assert.assertEquals(weapon.getDurability(), 5);
	}

	@Test
	public void testSetMaterial() {
		Weapon weapon = new Weapon("Sword", "Weapon", 1, 9.99, "This is a sword", 10, 8, "Iron", 5);
		weapon.setMaterial("Wood");
		Assert.assertTrue(weapon.getMaterial().equals("Wood"));
	}

	@Test
	public void testSetRating() {
		Weapon weapon = new Weapon("Sword", "Weapon", 1, 9.99, "This is a sword", 10, 8, "Iron", 5);
		weapon.setRating(1);
		Assert.assertEquals(weapon.getRating(), 1);
	}

}
