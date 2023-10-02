package app;

public class Bomb implements WeaponInterface {
	public void fireWeapon(int power) {
		System.out.println("In Bomb.fireWeapon() within class " + this.getClass() + " with power of " + power);
	}
	
	public void fireWeapon() {
		System.out.println("In method fireWeapon() within class " + this.getClass() + " with no arguments.");
	}

	@Override
	public void activate(boolean enable) {
		System.out.println("In Bomb.activate() within class" + this.getClass() + " with a enable of " + enable);
		
	}
}
