package junit;

import static org.junit.Assert.*;

import org.junit.Assert;
import org.junit.Test;

import app.Health;

public class HealthTest {

	@Test
	public void testSetNumUses() {
		Health health = new Health("Bandaid", "Health", 2, 9.99, "its a bandaid", 1, "Cloth", 2);
		health.setNumUses(2);
		Assert.assertEquals(health.getNumUses(), 2);
	}

	@Test
	public void testSetMaterial() {
		Health health = new Health("Bandaid", "Health", 2, 9.99, "its a bandaid", 1, "Cloth", 2);
		health.setMaterial("Wood");
		Assert.assertTrue(health.getMaterial().equals("Wood"));
	}

	@Test
	public void testSetRating() {
		Health health = new Health("Bandaid", "Health", 2, 9.99, "its a bandaid", 1, "Cloth", 2);
		health.setRating(2);
		Assert.assertEquals(health.getRating(), 2);
	}

}
