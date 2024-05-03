package app;

import java.util.ArrayList;
import java.util.Random;
import java.util.Scanner;

public class Battleship {
	Board playerBoard, computerBoard;
	ArrayList<Cell> computerMemory = new ArrayList<Cell>();
	
	int compPrevTurnSunkShips = 0;
	int compCurTurnSunkShips = 0;
	
	public Battleship() {
		playerBoard = new Board();
		computerBoard = new Board();
	}
	
	public static void main(String[] args) {
		// Create Game
		Battleship game = new Battleship();
		
		// Welcome Message + Instructions
		System.out.println("Welcome to Battleship!");
		System.out.println("----- Instructions -----");
		System.out.println("Your goal is to sink all the computer ships, and vice versa.\n"
				+ "We will start by placing all of your ships, then the computer will place it's ships.\n"
				+ "You will also fire the first shot. Don't miss..\n\n");
		
		// Create User and Comp Ships
		game.placeAllShips();
		
		// Run Game
		System.out.println("Game has started. Keep in mind, '-' denotes a cell has been fired at, but failed to hit anyhting.\n"
				+ "'!' denotes a cell has been fired at and HIT something.\n"
				+ "You Board is on the left, computer board is on the right.\n");
		game.playGame();
	}
	
	
	
	// Method for Running Game
	public void playGame() {
		printSideBySide(false);
		while (!playerBoard.allShipsSunk() && !computerBoard.allShipsSunk()) {
			playerTurn();
			computerTurn();
		}
		
		if (!playerBoard.allShipsSunk()) {
			System.out.println("\n\nPLAYER HAS WON!!");
		} else {
			System.out.println("\n\nCOMPUTER HAS WON!!");
		}
	}
	
	
	
	// Method for Player Turn
	public void playerTurn() {
		System.out.println("\n---------- PLAYER TURN ----------");
		int numTurns = 1;
		while (numTurns > 0) {
			Scanner scan = new Scanner(System.in);
			System.out.println("Enter Target Position (x, y): ");
			String[] input = scan.nextLine().split(", ");
			try {
				int col = Integer.parseInt(input[0]); // x
				int row = Integer.parseInt(input[1]); // y
				if (computerBoard.isValidFire(col, row)) {
					// valid cell on computer board
					// check if there is a ship
					if (!computerBoard.getCell(col, row).isEmpty()) {
						// its a hit
						numTurns++;
						System.out.println("HIT CONFIRMED!");
						computerBoard.hitCell(col, row);
					} else {
						System.out.println("MISS.");
						computerBoard.hitCell(col, row);
					}
					printSideBySide(false);
					pause();
					numTurns--;
				} else {
					System.out.println("Invalid Cell. Either its out of bounds, or you already targeted this position.");
				}
			} catch (Exception err) {
				System.out.println("Please enter a valid position.");
			}
		}
	}
	
	
	
	// Method for Computer Turn
	public void computerTurn() {
		System.out.println("---------- COMPUTER TURN ----------");
		int numTurns = 1;
		while (numTurns > 0) {
			Cell target = bestGuess();
			int col = target.getPosX();
			int row = target.getPosY();
			
			if (!playerBoard.getCell(col, row).isEmpty()) {
				// hit
				numTurns++;
				System.out.printf("COMPUTER HIT CONFIRMED AT (%d, %d)..\n", col, row);
				playerBoard.hitCell(col, row);
				computerMemory.add(target);
				
				// Update Sunk Ships
				compCurTurnSunkShips = playerBoard.getNumSunkShips();
				if (compCurTurnSunkShips > compPrevTurnSunkShips) {
					System.out.println("Ship Sunk, Wiping Computer Memory.");
					compPrevTurnSunkShips = compCurTurnSunkShips;
					computerMemory.clear();
				}
			} else {
				// miss
				System.out.printf("COMPUTER MISS AT (%d, %d).\n", col, row);
				playerBoard.hitCell(col, row);
			}
			numTurns--;
		}
		printSideBySide(false);
		pause();
	}
	
	
	
	// Method to Find Best Choice for Shot Pos
	public Cell bestGuess() {
		Cell target = null;
		if (computerMemory.isEmpty()) {
			// We have yet to hit anything, choose random
			Random randy = new Random();
			boolean valid = false;
			while (!valid) {
				int col = randy.nextInt(10);
				int row = randy.nextInt(10);
				if (playerBoard.isValidFire(col, row)) {
					target = new Cell(col, row, -1);
					valid = true;
				}
			}
		} else {
			// Educated Guess
			boolean targetFound = false;
			while (!targetFound) {
				// Pick One of Eight Valid Sides
				ArrayList<Cell> prospects = new ArrayList<Cell>();
				int col = computerMemory.get(computerMemory.size() - 1).getPosX();
				int row = computerMemory.get(computerMemory.size() - 1).getPosY();
				
				if (playerBoard.isValidFire(col - 1, row - 1)) { prospects.add(new Cell(col - 1, row - 1, -1)); }
				if (playerBoard.isValidFire(col, row - 1)) { prospects.add(new Cell(col, row - 1, -1)); }
				if (playerBoard.isValidFire(col + 1, row - 1)) { prospects.add(new Cell(col + 1, row - 1, -1)); }
				
				if (playerBoard.isValidFire(col - 1, row)) { prospects.add(new Cell(col - 1, row, -1)); }
				if (playerBoard.isValidFire(col + 1, row)) { prospects.add(new Cell(col + 1, row, -1)); }
				
				if (playerBoard.isValidFire(col - 1, row + 1)) { prospects.add(new Cell(col - 1, row + 1, -1)); }
				if (playerBoard.isValidFire(col, row + 1)) { prospects.add(new Cell(col, row + 1, -1)); }
				if (playerBoard.isValidFire(col + 1, row + 1)) { prospects.add(new Cell(col + 1, row + 1, -1)); }
				
				if (prospects.isEmpty()) {
					// no more moves, remove last hit, cycle again
					if (!computerMemory.isEmpty()) {
						computerMemory.remove(computerMemory.size() - 1);
						System.out.println("DEBUG: No more moves, removing last hit.");
						
						// check if memory is now empty
						if (computerMemory.isEmpty()) {
							System.out.println("Memory is now empty, choosing random.");
							// memory is empty, get random
							Random randy = new Random();
							boolean valid = false;
							while (!valid) {
								col = randy.nextInt(10);
								row = randy.nextInt(10);
								if (playerBoard.isValidFire(col, row)) {
									target = new Cell(col, row, -1);
									valid = true;
									
								}
							}
							targetFound = true;
						}
					}
				} else {
					System.out.println("Choosing Random Position out of Valid Sides.");
					Random randy = new Random();
					target = prospects.get(randy.nextInt(prospects.size()));
					targetFound = true;
				}
			}
		}
		return target;
	}
	
	
	
	// Method to 'Pause' in Between Events
	public void pause() {
		System.out.println("Press Enter to continue..");
		Scanner scan = new Scanner(System.in);
		scan.nextLine();
	}
	
	
	
	public void placeAllShips() {
		// PlayerShips
		printGameView(playerBoard);
		playerBoard.addCruiser();
		printGameView(playerBoard);
		playerBoard.addDestroyer();
		printGameView(playerBoard);
		playerBoard.addSubmarine();
		printGameView(playerBoard);
		
		// Computer Ships
		computerBoard.addRandomCruiser();
		computerBoard.addRandomDestroyer();
		computerBoard.addRandomSubmarine();
		
	}
	
	
	public void printGameView(Board board) {
		String seperator = new String(new char[10]).replace("\0", "*-----");
		System.out.print("\n" + seperator + "*\n");
		for (int y = 0; y < 10; y++) {
			System.out.print("|");
			for (int x = 0; x < 10; x++) {
				String display = "";
				int val = board.getCell(x, y).getValue();
				if (board.getCell(x, y).isHit() && val != 0) {
					display = "!";
				} else {
					display = getStringRepOfValue(val);
				}
				System.out.printf("  %s  |", display);
			}
			
			for (int x = 0; x < 10; x++) {
				
			}
			System.out.print("\n" + seperator + "*\n");
		}
	}
	
	public void printSideBySide(boolean showCompShips) {
		String seperator = new String(new char[10]).replace("\0", "*-----") + "*    ||    " + new String(new char[10]).replace("\0", "*-----");
		System.out.print("\n" + seperator + "*\n");
		for (int y = 0; y < 10; y++) {
			System.out.print("|");
			for (int x = 0; x < 10; x++) {
				String display = "";
				int val = playerBoard.getCell(x, y).getValue();
				if (playerBoard.getCell(x, y).isHit() && val != 0) {
					display = "!";
				} else if (playerBoard.getCell(x, y).isHit()){
					display = "-";
				} else {
					display = getStringRepOfValue(val);
				}
				System.out.printf("  %s  |", display);
			}
			System.out.print("    ||    |");
			for (int x = 0; x < 10; x++) {
				String display = "";
				int val = computerBoard.getCell(x, y).getValue();
				if (computerBoard.getCell(x, y).isHit()) {
					if (computerBoard.getCell(x, y).getValue() != 0) {
						display = "!";
					} else {
						display = "-";
					}
				} else {
					display = getStringRepOfValue(val);
					if (!showCompShips) {
						display = " ";
					}
				}
				System.out.printf("  %s  |", display);
			}
			System.out.print("\n" + seperator + "*\n");
		}
	}
	
	
	
	public String getStringRepOfValue(int val) {
		switch (val){
			case 0:
				return " ";
			case 1: 
				return "C";
			case 2: 
				return "D";
			case 3: 
				return "S";
			default:
				return "?";
		}
	}

}
