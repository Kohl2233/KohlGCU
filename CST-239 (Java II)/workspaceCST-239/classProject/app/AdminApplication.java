package app;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.PrintWriter;
import java.net.Socket;
import java.net.UnknownHostException;
import java.util.Scanner;

public class AdminApplication {
	// Serves As a Client
	private Socket clientSocket;
	private PrintWriter out;
	private BufferedReader in;
	
	public void start(String ip, int port) throws UnknownHostException, IOException {
		clientSocket = new Socket(ip, port);
		out = new PrintWriter(clientSocket.getOutputStream(), true);
		in = new BufferedReader(new InputStreamReader(clientSocket.getInputStream()));
	}
	
	public String sendMessage(String msg) throws IOException {
		out.println(msg);
		return in.readLine();
	}
	
	public void cleanup() throws IOException {
		in.close();
		out.close();
		clientSocket.close();
	}
	
	// Display Main Menu Method
	public void displayMainMenu() {
		System.out.printf("\n----- ADMIN APPLICATION MAIN MENU -----\n"
			+ "[%s] Update Store Inventory\n"
			+ "[%s] Return all Products\n"
			+ "[%s] Create New Product\n"
			+ "[%s] Quit Admin Application\n"
			+ "Enter letter to continue.\n", "U", "R", "N", "Q");
	}
		
	// Get Main Menu Choice Method
	private String getMainMenuChoice() {
		boolean isValidInput = false;
		String input = null;
		while (!isValidInput) {
			System.out.print("\nEnter Option: ");
			Scanner scan = new Scanner(System.in);
			input = scan.nextLine();
			if (input.equals("U") || input.equals("R") || input.equals("N") || input.equals("Q")) {
				isValidInput = true;
			} else {
				System.out.println("Invalid Input, options are U, R, N, and Q. Make sure it is capitalized.");
			}
		}

		return input;
	}
		
		// Display All Products Method
		public void displayProducts(String str) {
			String[] products = str.split(",");
			System.out.println(String.format("%-30s%-10s%-10s", "NAME", "QTY", "PRICE"));
			for (int i = 0; i < products.length; i += 3) {
				System.out.println(String.format("%-30s%-10s$%-10s", products[i], products[i + 1], products[i + 2]));
			}
		}
		
		// Create New Products Method
		public String createNewProduct() throws IOException {
			Scanner scan = new Scanner(System.in);
			// Get Name
			System.out.print("\nEnter Name of Product: ");
			String name = scan.nextLine();
			// Get Type
			System.out.print("\nEnter Type of Product: ");
			String type = scan.nextLine();
			// Get Quantity
			System.out.print("\nEnter Quantity of Product: ");
			String qty = scan.nextLine();
			// Get Price
			System.out.print("\nEnter Price of Product: ");
			String price = scan.nextLine();
			// Get Description
			System.out.print("\nEnter Description of Product: ");
			String description = scan.nextLine();
			
			String productString = "," + name + "," + type + "," + qty + "," + price + "," + description + ",";
			switch(type) {
			case "Weapon":
				// Get damage, durability, material, rating
				System.out.print("\nEnter Damage of Product: ");
				String dmg = scan.nextLine();
				System.out.print("\nEnter Durability of Product: ");
				String durability = scan.nextLine();
				System.out.print("\nEnter Material of Product: ");
				String material = scan.nextLine();
				System.out.print("\nEnter Rating of Product: ");
				String rating = scan.nextLine();
				productString = productString + dmg + "," + durability + "," + material + "," + rating;
				break;
			case "Armor":
				// get durability, material, rating
				System.out.print("\nEnter Durability of Product: ");
				durability = scan.nextLine();
				System.out.print("\nEnter Material of Product: ");
				material = scan.nextLine();
				System.out.print("\nEnter Rating of Product: ");
				rating = scan.nextLine();
				productString = productString + durability + "," + material + "," + rating;
				break;
			case "Health":
				// get numUses, material, and rating
				System.out.print("\nEnter Number of Uses of Product: ");
				String numUses = scan.nextLine();
				System.out.print("\nEnter Material of Product: ");
				material = scan.nextLine();
				System.out.print("\nEnter Rating of Product: ");
				rating = scan.nextLine();
				productString = productString + numUses + "," + material + "," + rating;
				break;
			}
			
			return productString;
		}
	
	public static void main(String[] args) throws UnknownHostException, IOException, InterruptedException {
		AdminApplication client = new AdminApplication();
		client.start("127.0.0.1", 6666);
		
		// Admin Application
		boolean quit = false;
		while(!quit) {
			client.displayMainMenu();
			String input = client.getMainMenuChoice();
			String response = null;
			switch(input) {
			case "U":
				// update inventory
				response = client.sendMessage(input);
				System.out.println(response);
				break;
			case "R":
				// return inventory
				response = client.sendMessage(input);
				client.displayProducts(response);
				break;
			case "N":
				// make a new product
				response = client.sendMessage("N" + client.createNewProduct());
				System.out.println(response);
				break;
			case "Q":
				// quit admin app
				response = client.sendMessage(input);
				System.out.println(response);
				quit = true;
				break;
			}
			Thread.sleep(1000);
			//if (input.equals("Q")) {quit = true;}
		}
		client.cleanup();
	}
}
