package junit;

import static org.junit.Assert.*;

import org.junit.Assert;
import org.junit.Test;

import app.SalableProduct;

public class SalableProductTest {
	@Test
	public void testSalableProduct() {
		SalableProduct product = new SalableProduct("Hammer", "Weapon", 2, 19.99, "Trusty Hammer");
		Assert.assertTrue(product instanceof SalableProduct);
	}

	@Test
	public void testSetName() {
		SalableProduct product = new SalableProduct("Hammer", "Weapon", 2, 19.99, "Trusty Hammer");
		product.setName("Sword");
		Assert.assertTrue(product.getName().equals("Sword"));
	}

	@Test
	public void testSetType() {
		SalableProduct product = new SalableProduct("Hammer", "Weapon", 2, 19.99, "Trusty Hammer");
		product.setType("Armor");
		Assert.assertTrue(product.getType().equals("Armor"));
	}

	@Test
	public void testSetQuantity() {
		SalableProduct product = new SalableProduct("Hammer", "Weapon", 2, 19.99, "Trusty Hammer");
		product.setQuantity(3);
		Assert.assertEquals(product.getQuantity(), 3);
	}

	@Test
	public void testSetStatus() {
		SalableProduct product = new SalableProduct("Hammer", "Weapon", 2, 19.99, "Trusty Hammer");
		product.setStatus("Available");
		Assert.assertTrue(product.getStatus().equals("Available"));
	}

	@Test
	public void testSetPrice() {
		SalableProduct product = new SalableProduct("Hammer", "Weapon", 2, 19.99, "Trusty Hammer");
		product.setPrice(9.99);
		Assert.assertTrue(product.getPrice() == 9.99);
	}

	@Test
	public void testSetDescription() {
		SalableProduct product = new SalableProduct("Hammer", "Weapon", 2, 19.99, "Trusty Hammer");
		product.setDescription("This is a test");
		Assert.assertTrue(product.getDescription().equals("This is a test"));
	}

	@Test
	public void testCheckStatus() {
		SalableProduct product = new SalableProduct("Hammer", "Weapon", 2, 19.99, "Trusty Hammer");
		product.setQuantity(2);
		Assert.assertTrue(product.getStatus().equals("Available"));
		product.setQuantity(0);
		Assert.assertTrue(product.getStatus().equals("Out of Stock"));
	}

	@Test
	public void testInStock() {
		SalableProduct product = new SalableProduct("Hammer", "Weapon", 2, 19.99, "Trusty Hammer");
		product.setQuantity(0);
		Assert.assertFalse(product.inStock());
		product.setQuantity(1);
		Assert.assertTrue(product.inStock());
	}
}
