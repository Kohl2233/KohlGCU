package app;

public class Cell {
	private int xCord;
	private int yCord;
	private int value;
	private boolean isHit;
	
	
	// Parameterized Constructor
	public Cell(int xCord, int yCord, int value) {
		this.xCord = xCord;
		this.yCord = yCord;
		this.value = value;
		this.isHit = false;
	}
	
	
	
	// Method to Set Value of isHit
	public void setIsHit(boolean b) {
		this.isHit = b;
	}
	
	
	
	// Method to Get Value of isHit
	public boolean isHit() {
		return isHit;
	}
	
	
	// Method to Get X Cord of Cell
	public int getPosX() {
		return this.xCord;
	}
	
	
	
	// Method to Get Y Cord of Cell
	public int getPosY() {
		return this.yCord;
	}
	
	
	
	// Method to Set the Value of Cell
	public void setValue(int value) {
		this.value = value;
	}
	
	
	
	// Method to Get Value of Cell
	public int getValue() {
		return this.value;
	}
	
	
	
	// Method to Quick Check if Empty
	public boolean isEmpty() {
		return this.value == 0;
	}	
}
