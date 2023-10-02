package app;

import java.io.BufferedReader;
import java.io.File;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.IOException;
import java.util.ArrayList;
import java.util.Collections;
import java.util.Scanner;

import com.fasterxml.jackson.databind.ObjectMapper;

public class InventoryManager {
	private ArrayList<SalableProduct> products = new ArrayList<>();

	// Initial Inventory Population Method
	public void populateInventory() {
		/*
		Weapon weapon1 = new Weapon("Wooden Sword", "Weapon", 3, 10.58, "Hack and slash with this splinter prone sword!", 12, 8, "Wood", 3);
		Weapon weapon2 = new Weapon("Stone Sword", "Weapon", 2, 32.99, "In use since.... well.. 300,000 BC, THIS sword will have you hurtin!", 15, 18, "Stone", 6);
		Weapon weapon3 = new Weapon("Iron Sword", "Weapon", 8, 68.49, "A timeless classic, you can cut bamboo clean in half with this baby!", 28, 14, "Iron", 8);
		Weapon weapon4 = new Weapon("Bronze Sword", "Weapon", 0, 48.99, "Sword made from bronze, pretty cool.", 25, 13, "Bronze", 6);
		Armor armor1 = new Armor("Wooden Chestplate", "Armor", 2, 34.85, "Chestplate made from wood, what else could you want?", 22, "Wood", 4);
		Armor armor2 = new Armor("Stone Chestplate", "Armor", 1, 49.99, "Please do not buy this.", 32, "Stone", 4);
		Armor armor3 = new Armor("Iron Full-Body Plates", "Armor", 8, 75.99, "Protects against all but the heaviest weapons!", 50, "Iron", 8);
		Armor armor4 = new Armor("Dragon Scale Chestplate", "Armor", 0, 499.99, "Protects against fire like nothing else, extremely rare.", 120, "Dragon Scale", 9);
		Health health1 = new Health("Bandage", "Health", 73, 4.99, "Single bandage for a single wound. Can't live without it.. literally.", 1, "Cloth", 7);
		Health health2 = new Health("Medkit", "Health", 15, 19.99, "All-in-one bag for a doctor on the go!", 5, "Sterile Cloth", 10);
		products.add(weapon1);
		products.add(weapon2);
		products.add(weapon3);
		products.add(weapon4);
		products.add(armor1);
		products.add(armor2);
		products.add(armor3);
		products.add(armor4);
		products.add(health1);
		products.add(health2);
		Collections.sort(products)
		*/
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
	InventoryManager(){
		this.populateInventory();
	}

	// Getter Methods
	public ArrayList<SalableProduct> getProducts(){
		return products;
	}

	public ArrayList<SalableProduct> getInStockProducts(){
		ArrayList<SalableProduct> stockProducts = new ArrayList<>();
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
}
