package app;

import java.util.ArrayList;
import java.util.Scanner;

public class StoreFrontApplication {
	
	// Welcome Message Method
	void displayWelcomeMsg() {
		System.out.println("\nWelcome to Cheapos Refurbished Products!");
		System.out.println("To continue, please answer the question below.");
	}
	
	// Welcome Message Questionnaire
	boolean welcomeQuestionnaire() {
		System.out.print("Will you follow instructions (Y or N): ");
		Scanner scan = new Scanner(System.in);
		String response = scan.nextLine();
		if (response.equals("Y")) {
			System.out.println("\nAwesome! Continue on with our store and we will have you swingin' in no time!");
			return true;
		} else {
			System.out.println("\nMan... you won't last long in the arena -___-\nHave a good day!");
			System.out.println("\n----- PROGRAM END -----");
			return false;
		}
	}
	
	// Main Menu Method
	void displayMainMenu() {
		
	}
	
	// Main Method
	public static void main(String[] args) {
		StoreFrontApplication StoreFront = new StoreFrontApplication(); // create StoreFrontApplication
		StoreFront.displayWelcomeMsg(); // display welcome message
		boolean passedQuestionnaire = StoreFront.welcomeQuestionnaire();		
	}
}
