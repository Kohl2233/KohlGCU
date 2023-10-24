package app;

public class SalableProduct implements Comparable<SalableProduct> {
	// Class Attributes
	private String name;
	private String type;
	private int quantity;
	private String status;
	private double price;
	private String description;
	private int sortType;

	// Constructor
	public SalableProduct (String name, String type, int quantity, double price, String description){
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

	// Sorting Stuff
	/*
	 * Name (Ascending) = 1
	 * Name (Descending) = 2
	 * Price (Ascending) = 3
	 * Price (Descending) = 4
	 */
	public void setSortType(int sortType) {this.sortType = sortType;}
	
	@Override
	public int compareTo(SalableProduct product) {
		int returnNum = 0;
		switch (sortType) {
			case 1:
				returnNum = name.compareTo(product.getName());
				break;
			case 2: 
				returnNum = -1 * name.compareTo(product.getName());
				break;
			case 3: 
				if (this.price < product.getPrice()) {
					returnNum = -1;
				} else if (this.price > product.getPrice()) {
					returnNum = 1;
				} else {
					returnNum = 0;
				}
				break;
			case 4:
				if (this.price < product.getPrice()) {
					returnNum = 1;
				} else if (this.price > product.getPrice()) {
					returnNum = -1;
				} else {
					returnNum = 0;
				}
				break;
		}
		return returnNum;
	}
}
