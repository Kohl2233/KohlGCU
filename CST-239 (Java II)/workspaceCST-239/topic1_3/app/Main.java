package app;

import java.util.ArrayList;

public class Main {
	public static void main(String[] args) {
		// Create Engine
		Engine engine = new Engine("Off");
		
		// Create 4 Tires
		ArrayList<Tire> tires = new ArrayList<Tire>();
		for (int i = 0; i < 4; i++) {
			Tire tire = new Tire(i, 32);
			tires.add(tire);
		}
		
		
		// Create Car
		Car car = new Car("Chrysler", "200", tires, engine);
		
		// Start Car
		car.startEngine();
		car.stopEngine();
		car.cycleEngine();
		car.accelerateToSpeed(120);
	}
}
