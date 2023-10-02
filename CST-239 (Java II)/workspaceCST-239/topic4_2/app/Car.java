package app;

public class Car {
	private int year;
	private String make;
	private String model;
	private int odometer;
	private double engineLiters;
	
	// Default Constructor
	public Car() {
		this.year = 0;
		this.make = "";
		this.model = "";
		this.odometer = 0;
		this.engineLiters = 0;
	}
	
	// Non-Default Constructor
	public Car(int year, String make, String model, int odometer, double engineLiters) {
		this.year = year;
		this.make = make;
		this.model = model;
		this.odometer = odometer;
		this.engineLiters = engineLiters;
	}
	
	// Getter Methods
	public int getYear() {return this.year;}
	public String getMake() {return this.make;}
	public String getModel() {return this.model;}
	public int getOdometer() {return this.odometer;}
	public double getEngineLiters() {return this.engineLiters;}
	
	// Setter Methods
	public void setYear(int year) {this.year = year;}
	public void setMake(String make) {this.make = make;}
	public void setModel(String model) {this.model = model;}
	public void setOdemeter(int odometer) {this.odometer = odometer;}
	public void setEngineLiters(double engineLiters) {this.engineLiters = engineLiters;}
	
	
}
