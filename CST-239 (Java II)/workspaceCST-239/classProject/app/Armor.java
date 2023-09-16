package app;

public class Armor extends SalableProduct {
	// Class Attributes
	private int durability;
	private String material;
	private int rating;
	
	// Constructor
	Armor (String name, String type, int quantity, double price, String description, int durability, String material, int rating){
		super(name, type, quantity, price, description);
		this.durability = durability;
		this.material = material;
		this.rating = rating;
	}
	
	// Setter Methods
	public void setDurability(int durability) {this.durability = durability;}
	public void setMaterial(String material) {this.material = material;}
	public void setRating(int rating) {this.rating = rating;}
	
	// Getter Methods
	public int getDurability() {return durability;}
	public String getMaterial() {return material;}
	public int getRating() {return rating;}
	
	// Other Methods
	public void displayStats() {
		System.out.printf("Durability: %d\nMaterial: %s\nRating: %d/10\n", 
				this.getDurability(), this.getMaterial(), this.getRating());
	}
}
