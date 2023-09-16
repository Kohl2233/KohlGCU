package app;

public class Bomb extends Weapon {
	public void fireWeapon(int power) {
		System.out.println("In Bomb.fireWeapon() with power of " + power);
	}
	
	public void fireWeapon() {
		System.out.println("In overloaded Bomb.fireWeapon()");
		super.fireWeapon(10);
	}

	@Override
	public void activate(boolean enable) {
		System.out.println("In Bomb.activate() with a enable of " + enable);
		
	}
}
