namespace ProductsApp.Models
{
    public class ProductModel
    {
        // Attributes
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public string ImageURL { get; set; }

        // Parameterized Constructor
        public ProductModel(int id, string name, decimal price, string description, DateTime createdAt, string imageURL)
        {
            Id = id;
            Name = name;
            Price = price;
            Description = description;
            CreatedAt = createdAt;
            ImageURL = imageURL;
        }

        // Default Constructor
        public ProductModel() { }

        public override bool Equals(object obj)
        {
            return Equals(obj as ProductModel);
        }

        public bool Equals(ProductModel other)
        {
            return other != null && Id == other.Id;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
