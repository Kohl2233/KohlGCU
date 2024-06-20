public class Pet {
    // Attrbiutes
    private int Id;
    private String name;
    private String description;
    private double price;
    private int categoryId;

    @Override
    public String toString() {
        return "Pet [ID: " + Id + ", Name: " + name + ", Descrip: " + description + ", Price: "
        + price + ", CategoryID: " + categoryId;
    }

    public int getId() { return Id; }
    public String getName() { return name; }
    public String getDescription() { return description; }
    public double getPrice() { return price; }
    public int getCatID() { return categoryId; }

    public void setID(int id) { Id = id; }
    public void setName(String name) { this.name = name; }
    public void setDesc(String desc) { description = desc; }
    public void setPrice(double price) { this.price = price; }
    public void setCatID(int catId) { categoryId = catId; }
}
