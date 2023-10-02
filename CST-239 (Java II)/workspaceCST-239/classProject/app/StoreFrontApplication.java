package app;

import java.util.ArrayList;
import java.util.Scanner;

public class StoreFrontApplication {
	// Attributes
	InventoryManager InvManager = new InventoryManager();
	ShoppingCart ShopCart = new ShoppingCart(this, InvManager);

	// Getter Methods
	public InventoryManager getInventoryManager() {return InvManager;}
	public ShoppingCart getShoppingCart() {return ShopCart;}

	// Welcome Message Method
	public void displayWelcomeMsg() {
		System.out.println("\nWelcome to Cheapos Refurbished Products!");
	}

	// Main Menu Method
	private String mainMenu() {
		this.displayMainMenu();
		String choice = this.getMainMenuChoice();
		return choice;
	}

	// Display Main Menu Method
	public void displayMainMenu() {
		System.out.printf("\n----- MAIN MENU -----\n"
				+ "[%s] View Full Catalog\n"
				+ "[%s] View In-Stock Products\n"
				+ "[%s] View Shopping Cart\n"
				+ "[%s] Quit Program\n"
				+ "Enter letter to continue.\n", "A", "B", "C", "D");
	}

	// Get Main Menu Choice Method
	private String getMainMenuChoice() {
		boolean isValidInput = false;
		String input = null;
		while (!isValidInput) {
			System.out.print("\nEnter Option: ");
			Scanner scan = new Scanner(System.in);
			input = scan.nextLine();
			if (input.equals("A") || input.equals("B") || input.equals("C") || input.equals("D")) {
				isValidInput = true;
			} else {
				System.out.println("Invalid Input, options are A-D. Make sure it is capitalized.");
			}
		}

		return input;
	}

	// Full Catalog Method
	public void displayFullCatalog() {
		System.out.println("-------------------- Full Product Catalog --------------------");
		System.out.printf("%-30s%-15s%-15s%s\n", "NAME", "TYPE", "STATUS", "PRICE");
		ArrayList<SalableProduct> products = InvManager.getProducts();
		for (SalableProduct product : products) {
			System.out.printf("%-30s%-15s%-15s$%,.2f\n", product.getName(), product.getType(), product.getStatus(), product.getPrice());
		}
	}

	// In-Stock Method
	public void inStock() {
		this.displayInStockProducts();
		String choice = this.getInStockMenuChoice();
		switch(choice) {
		case "A":
			// Inspect Single Product
			int targetIndex = this.inspectSingleProductMenu(InvManager.getInStockProducts().size()); // prompt user for product number
			this.inspectSingleProduct(targetIndex - 1); // show details for that product
			this.addInspectedToCart(InvManager.getInStockProducts().get(targetIndex - 1)); // ask user if they wish to add that product to cart
			break;
		case "B":
			// Sort By Price (low to high)
			break;
		case "C":
			// Show Only X Type
			break;
		case "D":
			// Reprint Inventory
			this.inStock(); // just send user back to in-stock product menu
			break;
		default:
			// Back to Main Menu, method will do nothing, end, and then go back to main menu
			break;
		}

	}

	// Display In-Stock Products Method
	public void displayInStockProducts() {
		ArrayList<SalableProduct> stockProducts = InvManager.getInStockProducts();
		System.out.println("-------------------- In-Stock Products --------------------");
		System.out.printf("%-34s%-15s%-15s%-15s\n", "NAME", "TYPE", "QTY", "PRICE"); // table column headers
		for (int i = 0; i < stockProducts.size(); i++) {
			SalableProduct product = stockProducts.get(i);
			System.out.printf("[%d] %-30s%-15s%-15d$%,.2f\n", i + 1, product.getName(), product.getType(), product.getQuantity(), product.getPrice());
		}
	}

	// In-Stock Menu Method
	private String getInStockMenuChoice() {
		System.out.printf("\n----- In-Stock Product Menu -----\n"
			+ "[%s] Inspect Single Product\n"
			+ "[%s] Sort By Price\n"
			+ "[%s] Show Only X Type\n"
			+ "[%s] Reprint Inventory\n"
			+ "[%s] Go Back to Main Menu\n"
			+ "Enter letter to continue.\n", "A", "B", "C", "D", "E");
		boolean isValidInput = false;
		String input = null;
		while (!isValidInput) {
			System.out.print("\nEnter Option: ");
			Scanner scan = new Scanner(System.in);
			input = scan.nextLine();
			if (input.equals("A") || input.equals("B") || input.equals("C") || input.equals("D") || input.equals("E")) {
				isValidInput = true;
			} else {
				System.out.println("Invalid Input, options are A-D. Make sure it is capitalized.");
			}
		}
		return input;
	}

	// Inspect Single Product Menu Method
	private int inspectSingleProductMenu(int size) {
		boolean isValidInput = false;
		int input = 0;
		while(!isValidInput) {
			System.out.print("Enter Product Number: ");
			Scanner scan = new Scanner(System.in);
			input = scan.nextInt();
			if ((input > 0) && (input <= size)) {
				isValidInput = true;
			} else {
				System.out.printf("\nInvalid input, number should be between 1 and %d.\n", size);
			}
		}
		return input;
	}

	// Inspect Single Product Method (Note: INDEX MUST BE FROM IN-STOCK PRODUCT LIST)
	private void inspectSingleProduct(int index) {
		ArrayList<SalableProduct> stockProducts = InvManager.getInStockProducts();
		SalableProduct salableProduct = stockProducts.get(index);
		System.out.printf("\n---------- Viewing %s ----------", salableProduct.getName());
		if (salableProduct.getType().equals("Weapon")) {
			// Weapon Class
			Weapon product = (Weapon) salableProduct;
			product.displayDetails();
			product.displayStats();
		} else if (salableProduct.getType().equals("Armor")) {
			// Armor Class
			Armor product = (Armor) salableProduct;
			product.displayDetails();
			product.displayStats();
		} else {
			// Health Class
			Health product = (Health) salableProduct;
			product.displayDetails();
			product.displayStats();
		}

	}

	// Add Inspected Product to Cart Method
	public void addInspectedToCart(SalableProduct product) {
		// Prompt For Menu Choice
		boolean isValidInput = false;
		String input = null;
		while (!isValidInput) {
			System.out.printf("\nAdd %s to cart [Y/N]? ", product.getName());
			Scanner scan = new Scanner(System.in);
			input = scan.nextLine();
			if (input.equals("Y")) {
				ShopCart.addProductToCart(product);
				this.inStock();
				isValidInput = true;
			} else if (input.equals("N")) {
				// Go Back to In-Stock Product Menu
				this.inStock();
				isValidInput = true;
			} else {
				System.out.println("Invalid input, options are Y and N.");
			}
		}
	}

	// Quit Program Method
	private boolean quitProgram(boolean quit) {
		if (quit) {
			System.out.println("----- PROGRAM END -----");
			return quit;
		} else {
			return quit;
		}
	}

	// Main Method
	public static void main(String[] args) {
		StoreFrontApplication StoreFront = new StoreFrontApplication();
		StoreFront.displayWelcomeMsg();
		boolean quit = StoreFront.quitProgram(false);
		while (!quit) {
			String menuChoice = StoreFront.mainMenu();
			// Main Menu Handling
			switch (menuChoice) {
			case "A":
				// Full Catalog
				StoreFront.displayFullCatalog();
				break;
			case "B":
				// In-Stock Catalog
				StoreFront.inStock();
				break;
			case "C":
				// Shopping Cart
				StoreFront.ShopCart.shopCart();
				break;
			case "D":
				// Program Quit
				quit = StoreFront.quitProgram(true);
			}
		}
	}
}
