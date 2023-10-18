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
	
	public static void main(String[] args) throws UnknownHostException, IOException, InterruptedException {
		AdminApplication client = new AdminApplication();
		client.start("127.0.0.1", 6666);
		
		// Admin Application
		boolean quit = false;
		while(!quit) {
			client.displayMainMenu();
			String input = client.getMainMenuChoice();
			String response = client.sendMessage(input);
			switch(input) {
			case "U":
				// update inventory
				System.out.println(response);
				break;
			case "R":
				// return inventory
				client.displayProducts(response);
				break;
			case "N":
				// make a new product?
				break;
			case "Q":
				// quit admin app
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
