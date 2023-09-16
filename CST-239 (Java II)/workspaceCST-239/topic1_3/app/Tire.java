package app;

public class Tire {
	// Class Attributes
	private int index;
	private int pressure;
	
	// Constructor
	Tire (int index, int pressure){
		this.index = index;
		this.pressure = pressure;
	}
	
	// Setter Methods
	public void setIndex(int index) {
		this.index = index;
	}
	
	public void setPressure(int pressure) {
		this.pressure = pressure;
	}
	
	// Getter Methods
	public int getIndex() {
		return index;
	}
	
	public int getPressure() {
		return pressure;
	}	
}
