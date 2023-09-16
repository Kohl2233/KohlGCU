package app;

public class Gun extends Weapon {
	public void fireWeapon(int power) {
		System.out.println("In Gun.fireWeapon() with power of " + power);
	}
	
	public void fireWeapon() {
		System.out.println("In overloaded Gun.fireWeapon()");
		super.fireWeapon(5);
	}

	@Override
	public void activate(boolean enable) {
		System.out.println("In the Gun.activate() with an enable of " + enable);
		
	}
}
