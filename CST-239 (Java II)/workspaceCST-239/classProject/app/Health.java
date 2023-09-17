package app;

public class Health extends SalableProduct {
	// Class Attributes
	private int numUses;
	private String material;
	private int rating;
	
	// Constructor
	Health (String name, String type, int quantity, double price, String description, int numUses, String material, int rating){
		super(name, type, quantity, price, description);
		this.numUses = numUses;
		this.material = material;
		this.rating = rating;
	}
	
	// Copy Constructor
	Health (Health health){
		super(health.getName(), health.getType(), health.getQuantity(), health.getPrice(), health.getDescription());
		this.numUses = health.getNumUses();
		this.material = health.getMaterial();
		this.rating = health.getRating();
	}
	
	// Setter Methods
	public void setNumUses(int numUses) {this.numUses = numUses;}
	public void setMaterial(String material) {this.material = material;}
	public void setRating(int rating) {this.rating = rating;}
	
	// Getter Methods
	public int getNumUses() {return numUses;}
	public String getMaterial() {return material;}
	public int getRating() {return rating;}
	
	// Other Methods
	public void displayStats() {
		System.out.printf("Number Uses: %d\nMaterial: %s\nRating: %d/10\n", 
				this.getNumUses(), this.getMaterial(), this.getRating());
	}
}
