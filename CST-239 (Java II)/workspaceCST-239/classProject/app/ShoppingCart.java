package app;

import java.util.ArrayList;
import java.util.Scanner;

public class ShoppingCart {
	private StoreFrontApplication StoreFront = null;
	private InventoryManager InvManager = null;
	private ArrayList<SalableProduct> shopCart = new ArrayList<SalableProduct>();

	ShoppingCart (StoreFrontApplication StoreFront, InventoryManager InvManager){
		this.StoreFront = StoreFront;
		this.InvManager = InvManager;
	}

	// Add Product to Cart Method
	public void addProductToCart (SalableProduct product) {
		// Create New Product For Use in Shopping Cart
		SalableProduct shopProduct = null;
		if (product.getType().equals("Weapon")) {
			// create new weapon class
			shopProduct = new Weapon((Weapon) product);
		} else if (product.getType().equals("Armor")) {
			// create new armor class
			shopProduct = new Armor((Armor) product);
		} else {
			// create new health class
			shopProduct = new Health((Health) product);
		}

		product.setQuantity(product.getQuantity() - 1); // update quantity of InvManager's product
		shopProduct.setQuantity(1); // update quantity of ShoppingCart's product

		// Add to Shopping Cart
		shopCart.add(shopProduct);

		// Print Success Message
		System.out.printf("\n%s has been added to cart! You now have %d item(s) in cart.\n\n", shopProduct.getName(), shopCart.size());
	}

	// Remove Product From Cart Method
	private void removeProductFromCart() {
		boolean isValidInput = false;
		int index = 0;
		while (!isValidInput) {
			System.out.print("Enter Product Number: ");
			Scanner scan = new Scanner(System.in);
			index = scan.nextInt();
			if (index > 0 && index <= shopCart.size()) {
				isValidInput = true;
			} else {
				System.out.printf("\nInvalid number, should be between 1 and %d.\n", shopCart.size());
			}
		}

		// Update InvManagers Inventory
		SalableProduct remProduct = shopCart.get(index - 1);
		InvManager.updateProductQuantity(remProduct.getName(), 1);

		// Update ShopCart Inventory
		shopCart.remove(index - 1);

		// Send User Back to Shopping Cart Menu
		System.out.printf("\n%s has been removed from shopping cart.\n", remProduct.getName());
		this.shopCart();
	}

	// Shopping Cart Get Menu Choice Method
	public String getShopMenuChoice() {
		System.out.printf("\n----- Shopping Cart Menu -----\n"
				+ "[%s] Remove a Product\n"
				+ "[%s] Checkout\n"
				+ "[%s] Back to In-Stock Products\n"
				+ "Enter letter to continue.\n", "A", "B", "C");
			boolean isValidInput = false;
			String input = null;
			while (!isValidInput) {
				System.out.print("\nEnter Option: ");
				Scanner scan = new Scanner(System.in);
				input = scan.nextLine();
				if (input.equals("A") || input.equals("B") || input.equals("C")) {
					if ((input.equals("A") || input.equals("B")) && shopCart.size() > 0) {
						isValidInput = true;
					} else if (input.equals("C")) {
						isValidInput = true;
					} else {
						System.out.println("Can not do that, your cart is empty.");
					}
				} else {
					System.out.println("Invalid Input, options are A-C. Make sure it is capitalized.");
				}
			}
			return input;
	}

	// Display Cart Method
	public void displayCart() {
		if (shopCart.size() != 0) {
			System.out.println("-------------------- Shopping Cart Entries --------------------");
			System.out.printf("%-38s%-15s%-15s%-15s\n", "NAME", "TYPE", "QTY", "PRICE"); // table column headers
			for (int i = 0; i < shopCart.size(); i++) {
				SalableProduct product = shopCart.get(i);
				System.out.printf("[%s] %-34s%-15s%-15d$%,.2f\n", i + 1, product.getName(), product.getType(), product.getQuantity(), product.getPrice());
			}
		} else {
			System.out.println("Your Cart is Empty :(");
		}
	}
	
	// Checkout Method
	public void checkout() {
		System.out.println("Thank you for your order! Your reciept is included below.");
		System.out.println("-------------------- Order Reciept --------------------");
		System.out.printf("%-30s%-15s%-15s\n", "NAME", "QTY", "PRICE"); // table column headers
		double total = 0;
		for (SalableProduct product : shopCart) {
			total += product.getPrice();
			System.out.printf("%-30s%-15s$%,.2f\n", product.getName(), product.getQuantity(), product.getPrice());
		}
		System.out.println("-------------------------------------------------------");
		System.out.printf("Order Total: $%,.2f\n\n\n", total);
		shopCart.clear();
	}

	// Shopping Cart Method
	public void shopCart() {
		this.displayCart();
		String menuChoice = this.getShopMenuChoice();
		switch(menuChoice) {
		case "A":
			// Remove a Product
			this.removeProductFromCart();
			break;
		case "B":
			// Checkout
			this.checkout();
			break;
		case "C":
			// Back to In-Stock Products
			StoreFront.inStock();
			break;
		}
	}
}
