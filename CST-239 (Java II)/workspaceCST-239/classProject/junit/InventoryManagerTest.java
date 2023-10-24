package junit;

import static org.junit.Assert.*;

import java.util.ArrayList;

import org.junit.Assert;
import org.junit.Test;

import app.Armor;
import app.InventoryManager;
import app.SalableProduct;

public class InventoryManagerTest {

	@Test
	public void testGetProducts() {
		InventoryManager InvManager = new InventoryManager();
		ArrayList<SalableProduct> products = InvManager.getProducts();
		for (SalableProduct product : products) {
			Assert.assertTrue(product instanceof SalableProduct);
		}
	}

	@Test
	public void testGetInStockProducts() {
		InventoryManager InvManager = new InventoryManager();
		ArrayList<SalableProduct> products = InvManager.getInStockProducts();
		for (SalableProduct product : products) {
			Assert.assertTrue(product.inStock());
		}
	}

	@Test
	public void testUpdateProductQuantity() {
		InventoryManager InvManager = new InventoryManager();
		ArrayList<SalableProduct> products = InvManager.getInStockProducts();
		InvManager.updateProductQuantity("Chestplate", 1);
		Assert.assertEquals(products.get(0).getQuantity(), 3);
	}
}
