package app;

public class Weapon extends SalableProduct {
	// Class Attributes
	private int damage;
	private int durability;
	private String material;
	private int rating;
	
	// Constructor
	Weapon (String name, String type, int quantity, double price, String description, int damage, int durability, String material, int rating){
		super(name, type, quantity, price, description);
		this.damage = damage;
		this.durability = durability;
		this.material = material;
		this.rating = rating;
	}
	
	// Copy Constructor
	Weapon(Weapon weapon){
		super(weapon.getName(), weapon.getType(), weapon.getQuantity(), weapon.getPrice(), weapon.getDescription());
		this.damage = weapon.getDamage();
		this.durability = weapon.getDurability();
		this.material = weapon.getMaterial();
		this.rating = weapon.getRating();
	}
	
	// Setter Methods
	public void setDamage(int damage) {this.damage = damage;}
	public void setDurability(int durability) {this.durability = durability;}
	public void setMaterial(String material) {this.material = material;}
	public void setRating(int rating) {this.rating = rating;}
	
	// Getter Methods
	public int getDamage() {return damage;}
	public int getDurability() {return durability;}
	public String getMaterial() {return material;}
	public int getRating() {return rating;}
	
	// Other Methods
	public void displayStats() {
		System.out.printf("Damage: %d\nDurability: %d\nMaterial: %s\nRating: %d/10\n", 
				this.getDamage(), this.getDurability(), this.getMaterial(), this.getRating());
	}
}
