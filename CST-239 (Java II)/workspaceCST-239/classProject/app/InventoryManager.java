package app;

import java.io.File;
import java.io.FileNotFoundException;
import java.util.ArrayList;
import java.util.Collections;
import java.util.Random;
import java.util.Scanner;

import com.fasterxml.jackson.databind.ObjectMapper;

public class InventoryManager {
	private ArrayList<SalableProduct> products = new ArrayList<SalableProduct>();

	// Initial Inventory Population Method
	public void populateInventory() {
		try {
			File file = new File("Inventory.txt");
			Scanner scan = new Scanner(file);
			while (scan.hasNextLine()) {
				String line = scan.nextLine();
				String[] attri = line.split("@");
				String type = attri[1];
				switch (type) {
					case "Weapon":
						Weapon weapon = new Weapon(attri[0], 
								attri[1], 
								Integer.valueOf(attri[2]), 
								Double.valueOf(attri[3]), 
								attri[4], 
								Integer.valueOf(attri[5]), 
								Integer.valueOf(attri[6]), 
								attri[7], 
								Integer.valueOf(attri[8]));
						products.add(weapon);
						break;
					case "Armor":
						Armor armor = new Armor(attri[0], 
								attri[1], 
								Integer.valueOf(attri[2]), 
								Double.valueOf(attri[3]), 
								attri[4], 
								Integer.valueOf(attri[5]), 
								attri[6], 
								Integer.valueOf(attri[7]));
						products.add(armor);
						break;
					case "Health":
						Health health = new Health(attri[0], 
								attri[1], 
								Integer.valueOf(attri[2]), 
								Double.valueOf(attri[3]), 
								attri[4], 
								Integer.valueOf(attri[5]), 
								attri[6], 
								Integer.valueOf(attri[7]));
						products.add(health);
						break;
				}
			}
			scan.close();
		} catch (FileNotFoundException err) {
			System.out.println("File could not be found.");
		}
		
		//ObjectMapper objectMapper = new ObjectMapper();
	}
	// Constructor
	public InventoryManager(){
		this.populateInventory();
	}

	// Getter Methods
	public ArrayList<SalableProduct> getProducts(){
		return products;
	}
	
	public String getProductDetailsAsString() {
		String str = "";
		products = this.getProducts();
		for (int i = 0; i < products.size(); i++) {
			SalableProduct product = products.get(i);
			if (i != products.size() - 1) {
				str += product.getName() + "," + product.getQuantity() + "," + product.getPrice() + ",";
			} else {
				str += product.getName() + "," + product.getQuantity() + "," + product.getPrice();
			}
		}
		return str;
	}
	
	public ArrayList<SalableProduct> getInStockProducts(){
		ArrayList<SalableProduct> stockProducts = new ArrayList<SalableProduct>();
		for (int i = 0; i < products.size(); i++) {
			SalableProduct product = products.get(i);
			if (product.inStock()) {
				stockProducts.add(product);
			}
		}
		Collections.sort(stockProducts);
		return stockProducts;
	}

	// Setter Methods
	public void updateProductQuantity(String name, int qty) {
		for (SalableProduct product : products) {
			if (product.getName().equals(name)) {
				int newQuantity = product.getQuantity() + qty;
				product.setQuantity(newQuantity);
			}
		}
	}
	
	// Bulk Inventory Update
	public void randomInventoryUpdate() {
		Random randy = new Random();
		products = this.getProducts();
		for (int i = 0; i < products.size(); i++) {
			SalableProduct product = products.get(i);
			product.setQuantity(product.getQuantity() + randy.nextInt(9) + 1);
		}
	}
	
	// New Product Method
	public void addNewProduct(String productString) {
		String productInfo[] = productString.split(",");
		switch(productInfo[2]) {
		case "Weapon":
			Weapon weapon = new Weapon(productInfo[1], 
					productInfo[2], 
					Integer.valueOf(productInfo[3]), 
					Double.valueOf(productInfo[4]), 
					productInfo[5], 
					Integer.valueOf(productInfo[6]), 
					Integer.valueOf(productInfo[7]), 
					productInfo[8], 
					Integer.valueOf(productInfo[9]));
			products.add(weapon);
			break;
		case "Armor":
			Armor armor = new Armor(productInfo[1], 
					productInfo[2], 
					Integer.valueOf(productInfo[3]), 
					Double.valueOf(productInfo[4]), 
					productInfo[5], 
					Integer.valueOf(productInfo[6]), 
					productInfo[7], 
					Integer.valueOf(productInfo[8]));
			products.add(armor);
			break;
		case "Health":
			Health health = new Health(productInfo[1], 
					productInfo[2], 
					Integer.valueOf(productInfo[3]), 
					Double.valueOf(productInfo[4]), 
					productInfo[5], 
					Integer.valueOf(productInfo[6]), 
					productInfo[7], 
					Integer.valueOf(productInfo[8]));
			products.add(health);
			break;
		}
	}
	
	// Sorting Methods
	public void sortInStockProducts(int sortType) {
		// Set the sortType attribute in each SalableProduct
		for (SalableProduct product : getInStockProducts()) {
			product.setSortType(sortType);
		}
		
		// Sort
		Collections.sort(getInStockProducts());
	}
	
}
