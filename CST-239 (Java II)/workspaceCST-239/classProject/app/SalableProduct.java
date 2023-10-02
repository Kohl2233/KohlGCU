package app;

public class SalableProduct implements Comparable<SalableProduct> {
	// Class Attributes
	private String name;
	private String type;
	private int quantity;
	private String status;
	private double price;
	private String description;

	// Constructor
	SalableProduct (String name, String type, int quantity, double price, String description){
		this.name = name;
		this.type = type;
		this.quantity = quantity;
		this.price = price;
		this.description = description;

		this.checkStatus(); // update status
	}

	// Setter Methods
	public void setName(String name) {this.name = name;}
	public void setType(String type) {this.type = type;}
	public void setQuantity(int quantity) {this.quantity = quantity; this.checkStatus();}
	public void setStatus(String status) {this.status = status;}
	public void setPrice(double price) {this.price = price;}
	public void setDescription(String description) {this.description = description;}

	// Getter Methods
	public String getName() {return name;}
	public String getType() {return type;}
	public int getQuantity() {return quantity;}
	public String getStatus() {return status;}
	public double getPrice() {return price;}
	public String getDescription() {return description;}

	// Catalog Methods
	public void displayDetails() {
		System.out.printf("\nName: %s\nType: %s\nQty: %d\nStatus: %s\nUnit Price: $%,.2f\nDescription: %s\n",
				name, type, quantity, status, price, description);
	}

	public void displaySimpleDetails() {
		System.out.printf("%-30s%-15s%-15s$%,.2f\n", this.getName(), this.getType(), this.getStatus(), this.getPrice());
	}

	// Inventory Methods
	public void checkStatus() {
		if (this.inStock()) {
			this.setStatus("Available");
		} else {
			this.setStatus("Out of Stock");
		}
	}

	public boolean inStock() {
		if (quantity > 0) {
			return true;
		} else {
			return false;
		}
	}

	@Override
	public int compareTo(SalableProduct product) {
		return name.compareTo(product.getName());
	}
}
