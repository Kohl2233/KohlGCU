package app;

import java.util.Random;
import java.util.Scanner;

public class Board {
	// Class Attributes
	private Cell[][] board = new Cell[10][10];
	
	/*
	 * Cell Values
	 * 0 : Nothing
	 * 1 : Cruiser
	 * 2 : Destroyer
	 * 3 : Submarine
	 */
	
	
	// Default Constructor
	public Board() {
		populateBoard();
	}
	
	
	
	// Method to Get Cell from Board
	public Cell getCell(int x, int y) {
		return this.board[x][y];
	}
	
	
	
	// Method to Update isHit on Cell
	public void hitCell(int x, int y) {
		board[x][y].setIsHit(true);
	}
	
	
	
	// Method to Populate Cell Array
	private void populateBoard() {
		for (int x = 0; x < 10; x++) {
			for (int y = 0; y < 10; y++) {
				board[x][y] = new Cell(x, y, 0);
			}
		}
	}
	
	
	
	// Method to Get Number of Ships Sunk
	public int getNumSunkShips() {
		int num = 0;
		if (isCruiserSunk()) {
			num++;
		}
		
		if (isDestroyerSunk()) {
			num++;
		}
		
		if (isSubmarineSunk()) {
			num++;
		}
		return num;
	}
	
	
	
	// Method to Check if Cruiser is Sunk
	public boolean isCruiserSunk() {
		boolean stillSearching = true;
		boolean isSunk = true;
		while (stillSearching) {
			for (int x = 0; x < 10; x++) {
				for (int y = 0; y < 10; y++) {
					if (board[x][y].getValue() == 1) {
						if (!board[x][y].isHit()) {
							isSunk = false;
							stillSearching = false;
						}
					}
				}
			}
		}
		return isSunk;
	}
	
	
	
	// Method to Check if Destroyer is Sunk
	public boolean isDestroyerSunk() {
		boolean stillSearching = true;
		boolean isSunk = true;
		while (stillSearching) {
			for (int x = 0; x < 10; x++) {
				for (int y = 0; y < 10; y++) {
					if (board[x][y].getValue() == 2) {
						if (!board[x][y].isHit()) {
							isSunk = false;
							stillSearching = false;
						}
					}
				}
			}
		}
		return isSunk;
	}
	
	
	
	// Method to Check if Submarine is Sunk
	public boolean isSubmarineSunk() {
		boolean stillSearching = true;
		boolean isSunk = true;
		while (stillSearching) {
			for (int x = 0; x < 10; x++) {
				for (int y = 0; y < 10; y++) {
					if (board[x][y].getValue() == 3) {
						if (!board[x][y].isHit()) {
							isSunk = false;
							stillSearching = false;
						}
					}
				}
			}
		}
		return isSunk;
	}
	
	
	
	// Method to check if All Ships Sunk
	public boolean allShipsSunk() {
		if (isCruiserSunk() && isDestroyerSunk() && isSubmarineSunk()) {
			return true;
		} else {
			return false;
		}
	}
	
	
	
	// Method to Check if Prospect Pos is Valid (used for spawning)
	public boolean isValidCell(int col, int row) {
		boolean valid = false;
		if (col >= 0 && col < 10) {
			// valid x
			if (row >= 0 && row < 10) {
				// valid y
				Cell cell = this.getCell(col, row);
				if (cell.isEmpty()) {
					// is empty
					valid = true;
				}
			}
		}
		return valid;
	}
	
	
	
	// Method to Check if Cell is In Bounds and NOT hit
	public boolean isValidFire(int col, int row) {
		boolean valid = false;
		if (col >= 0 && col < 10) {
			if (row >= 0 && row < 10) {
				if (!getCell(col, row).isHit()) {
					valid = true;
				}
			}
		}
		return valid;
	}
	
	
	
	// Method to Get Orientation of Ship
	private String getOrientation(int shipType) {
		// ShipType 1: Cruiser, 2: Submarine
		boolean isValid = false;
		String orient = "";
		while (!isValid) {
			if (shipType == 1) {
				// Need Either Horizontal or Vertical
				Scanner scan = new Scanner(System.in);
				System.out.println("Enter Orientation (H or V): ");
				orient = scan.nextLine().trim();
				if (orient.equals("H") || orient.equals("V")) {
					// Valid
					isValid = true;
				} else {
					// NOT valid
					System.out.println("Please enter either H (horizontal) or V (vertical).");
				}
			} else {
				// Need Either Point Right-Down or Point Right-Up
				Scanner scan = new Scanner(System.in);
				System.out.println("PRU: Point Right Up, PRD: Point Right Down, Enter Orientation: ");
				orient = scan.nextLine();
				if (orient.equals("PRU") || orient.equals("PRD")) {
					// Valid
					isValid = true;
				} else {
					// NOT Valid
					System.out.println("Please enter either PRU (point right up) or PRD (point right down).");
				}
			}
		}
		// Return Valid
		return orient;
	}
	
	
	
	// Method to Add Random Cruiser
	public void addRandomCruiser() {
		Random randy = new Random();
		boolean isValid = false;
		int col = -1, row = -1;
		String orient = "";
		while (!isValid) {
			col = randy.nextInt(10);
			row = randy.nextInt(10);
			int i = randy.nextInt(2);
			if (i == 1) {
				orient = "V";
			} else { orient = "H"; }
			
			// Check Center
			if (isValidCell(col, row)) {
				// ok, valid center cell
				// check other two
				if (orient.equals("V")) {
					// vertical
					if (isValidCell(col, row + 1) && isValidCell(col, row - 1)) {
						// valid
						isValid = true;
					} 
				} else {
					// horizontal
					if (isValidCell(col - 1, row) && isValidCell(col + 1, row)) {
						// valid
						isValid = true;
					}
				}
			}
		}
		
		// Valid Random Position
		addCruiser(col, row, orient);
	}
	
	
	
	// Method to Add Random Destroyer
	public void addRandomDestroyer() {
		Random randy = new Random();
		boolean isValid = false;
		int col = -1, row = -1;
		while (!isValid) {
			col = randy.nextInt(10);
			row = randy.nextInt(10);
			
			// Check Center
			if (isValidCell(col, row)) {
				// ok, valid center cell
				// check other 3
				if (isValidCell(col + 1, row) && isValidCell(col, row + 1) && isValidCell(col + 1, row + 1)) {
					// valid
					isValid = true;
				}
				
			}
		}
		
		addDestroyer(col, row);
	}
	
	
	
	// Method to add Random Submarine
	public void addRandomSubmarine() {
		Random randy = new Random();
		boolean isValid = false;
		int col = -1, row = -1;
		String orient = "";
		while (!isValid) {
			col = randy.nextInt(10);
			row = randy.nextInt(10);
			int i = randy.nextInt(2);
			if (i == 1) {
				orient = "PRU";
			} else { orient = "PRD"; }
			
			// Check Center
			if (isValidCell(col, row)) {
				// ok, valid center cell
				// check other two
				if (orient.equals("PRD")) {
					// pointing right down
					if (isValidCell(col - 1, row - 1) && isValidCell(col + 1, row + 1)) {
						// Valid
						isValid = true;
					}
				} else {
					// pointing right up
					if (isValidCell(col + 1, row - 1) && isValidCell(col - 1, row + 1)) {
						// Valid
						isValid = true;
					}
				}
			}
		}
		
		addSubmarine(col, row, orient);
	}
	
	
	// Method to Place Destroyer (with predetermined pos)
	public void addDestroyer(int x, int y) {
		int col = x, row = y;
		board[col][row].setValue(2); // top left
		board[col + 1][row].setValue(2); // top right
		board[col][row + 1].setValue(2); // bot left
		board[col + 1][row + 1].setValue(2); // bot right
	}
	
	
	
	// Method to Place Cruiser (with predetermined pos and orient)
	public void addCruiser(int x, int y, String orient) {
		int col = x, row = y;
		board[col][row].setValue(1);
		if (orient.equals("V")) {
			// vertical
			board[col][row - 1].setValue(1);
			board[col][row + 1].setValue(1);
		} else {
			// horizontal
			board[col - 1][row].setValue(1);
			board[col + 1][row].setValue(1);
		}
	}
	
	
	
	// Method to Place Submarine (with predetermined pos and orient)
	public void addSubmarine(int x, int y, String orient) {
		int col = x, row = y;
		board[col][row].setValue(3);
		if (orient.equals("PRU")) {
			// pointing right up
			board[col + 1][row - 1].setValue(3);
			board[col - 1][row + 1].setValue(3);
		} else {
			// pointing right down
			board[col - 1][row - 1].setValue(3);
			board[col + 1][row + 1].setValue(3);
		}
	}
	
	
	
	// Method to Add Destroyer to Board
	public void addDestroyer() {
		// y = row, x = col
		// destroyer is 2x2 cells
		boolean isValid = false;
		int col = -1, row = -1;
		while (!isValid) {
			Scanner scan = new Scanner(System.in);
			System.out.println("Placing Destroyer..\nEnter the TOP LEFT Cell Position (x, y): ");
			String[] input = scan.nextLine().split(", ");
			try {
				col = Integer.parseInt(input[0]); // x
				row = Integer.parseInt(input[1]); // y
				
				if (isValidCell(col, row)) {
					// valid center cell, check other 3
					if (isValidCell(col + 1, row) && isValidCell(col, row + 1) && isValidCell(col + 1, row + 1)) {
						// Valid
						isValid = true;
					} else {
						System.out.println("Destroyer does not fit here, try again.");
					}
				} else {
					System.out.println("Please enter a valid position.");
				}
			} catch (Exception err) {
				System.out.println("ERROR: Could not parse, make sure you enter a integer position, in the correct format.");
			}
		}
		
		// If We Got Here, All Checks Valid
		// place 4 cells
		board[col][row].setValue(2); // top left
		board[col + 1][row].setValue(2); // top right
		board[col][row + 1].setValue(2); // bot left
		board[col + 1][row + 1].setValue(2); // bot right
	}
	
	
	
	// Method to Add Cruiser
	public void addCruiser() {
		boolean isValid = false;
		int col = -1, row = -1;
		String orient = getOrientation(1);
		while (!isValid) {
			Scanner scan = new Scanner(System.in);
			System.out.println("Placing Cruiser..\nEnter the CENTER position (x, y): ");
			String[] input = scan.nextLine().split(", ");
			try {
				col = Integer.parseInt(input[0]); // x
				row = Integer.parseInt(input[1]); // y
				if (isValidCell(col, row)) {
					// valid center, check other 2
					if (orient.equals("V")) {
						// vertical
						if (isValidCell(col, row - 1) && isValidCell(col, row + 1)) {
							// Valid
							isValid = true;
						} else {
							System.out.println("Cruiser does not fit vertically here. Try again.");
						}
					} else {
						// horizontal
						if (isValidCell(col - 1, row) && isValidCell(col + 1, row)) {
							// valid
							isValid = true;
						} else {
							System.out.println("Cruiser does not fit horizontally here. Try again.");
						}
					}
				}
			} catch (Exception err) {
				System.out.println("ERROR: Could not parse, make sure you enter an integer position, in the exact format.");
			}
		}
		
		// If we get here, All checks valid
		// place cells
		board[col][row].setValue(1);
		if (orient.equals("V")) {
			// vertical
			board[col][row - 1].setValue(1);
			board[col][row + 1].setValue(1);
		} else {
			// horizontal
			board[col - 1][row].setValue(1);
			board[col + 1][row].setValue(1);
		}
	}
	
	
	
	// Method to Add Submarine
	public void addSubmarine() {
		boolean isValid = false;
		int col = -1, row = -1;
		String orient = getOrientation(2);
		while (!isValid) {
			Scanner scan = new Scanner(System.in);
			System.out.println("Placing submarine..\nEnter CENTER position (x, y): ");
			String[] input = scan.nextLine().split(", ");
			try {
				col = Integer.parseInt(input[0]); // x
				row = Integer.parseInt(input[1]); // y
				
				if (isValidCell(col, row)) {
					// valid center, check other two
					if (orient.equals("PRU")) {
						// pointing top right
						if (isValidCell(col + 1, row - 1) && isValidCell(col - 1, row + 1)) {
							// Valid
							isValid = true;
						} else {
							System.out.println("Submarine does not fit here, try again.");
						}
					} else {
						// pointing bottom right
						if (isValidCell(col - 1, row - 1) && isValidCell(col + 1, row + 1)) {
							// Valid
							isValid = true;
						} else {
							System.out.println("Submarine does not fit here, try again.");
						}
					}
				}
			} catch (Exception err) {
				System.out.println("ERROR: Could not parse, make sure you enter an integer position, in the exact format.");
			}
		}
		
		// If we get here, all checks are valid
		// place cells
		board[col][row].setValue(3);
		if (orient.equals("PRU")) {
			// pointing right up
			board[col + 1][row - 1].setValue(3);
			board[col - 1][row + 1].setValue(3);
		} else {
			// pointing right down
			board[col - 1][row - 1].setValue(3);
			board[col + 1][row + 1].setValue(3);
		}
	}
	
}
