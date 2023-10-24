package junit;

import static org.junit.Assert.*;

import org.junit.Assert;
import org.junit.Test;

import app.Armor;

public class ArmorTest {

	@Test
	public void testSetDurability() {
		Armor armor = new Armor("Chestplate", "Armor", 1, 9.99, "This is armor", 5, "Wood", 2);
		armor.setDurability(2);
		Assert.assertEquals(armor.getDurability(), 2);
	}

	@Test
	public void testSetMaterial() {
		Armor armor = new Armor("Chestplate", "Armor", 1, 9.99, "This is armor", 5, "Wood", 2);
		armor.setMaterial("Iron");
		Assert.assertTrue(armor.getMaterial().equals("Iron"));
	}

	@Test
	public void testSetRating() {
		Armor armor = new Armor("Chestplate", "Armor", 1, 9.99, "This is armor", 5, "Wood", 2);
		armor.setRating(8);
		Assert.assertEquals(armor.getRating(), 8);
	}
}
