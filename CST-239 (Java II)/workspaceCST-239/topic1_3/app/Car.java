package app;

import java.util.ArrayList;

public class Car {
	// Class Attributes
	private String make;
	private String model;
	private ArrayList<Tire> tires;
	private Engine engine;
	private String curState;
	private int speed;
	
	// Constructor
	Car (String make, String model, ArrayList<Tire> tires, Engine engine){
		this.make = make;
		this.model = model;
		this.tires = tires;
		this.engine = engine;
		this.curState = engine.getState();
		this.speed = 0;
	}
	
	// Setter Methods
	public void setMake(String make) {
		this.make = make;
	}
	
	public void setModel(String model) {
		this.model = model;
	}
	
	public void setTire(int index, Tire newtire) {
		tires.set(index, newtire);
	}
	
	public void setState() {
		curState = engine.getState();
	}
	
	// Getter Methods
	public String getModel() {
		return model;
	}
	
	public String getMake() {
		return make;
	}
	
	public ArrayList<Tire> getTires(){
		return tires;
	}
	
	public String getState() {
		return curState;
	}
	
	// Other Methods
	public boolean checkTirePressure() {
		boolean pressureGood = true;
		for (int i = 0; i < tires.size(); i++) {
			if (tires.get(i).getPressure() < 32) {
				pressureGood = false;
			}
		}
		
		return pressureGood;
	}
	
	public void startEngine() {
		if (checkTirePressure()) {
			engine.start();
			this.setState();
			System.out.printf("Car is now in state: %s\n", curState);
		} else {
			System.out.printf("Tire pressure too low, car is now in state: %s\n", curState);
		}
	}
	
	public void stopEngine() {
		engine.stop();
		this.setState();
		System.out.printf("Car is now in state: %s\n", curState);
	}
	
	public void cycleEngine() {
		System.out.println("Cycling (restarting) engine...");
		engine.stop();
		engine.start();
		this.setState();
		System.out.printf("Car is now in state: %s\n", curState);
	}
	
	public void accelerateToSpeed(int targetSpeed) {
		if (engine.isRunning()) {
			if (targetSpeed <= 60 && targetSpeed >= 1) {
				this.speed = targetSpeed;
				System.out.printf("Car Speed: %d\n", speed);
			} else {
				this.speed = 60;
				System.out.printf("We can not go that fast. Car Speed: %d\n", speed);
			}
		} else {
			System.out.println("Car needs to be running to move bruh.");
		}
	}
}
