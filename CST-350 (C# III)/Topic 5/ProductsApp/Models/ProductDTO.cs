namespace ProductsApp.Models
{
    public class ProductDTO
    {
        // Attributes
        public string? Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string? Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public string? ImageURL { get; set; }
        public decimal EstimatedTax { get; set; }
        public string FormattedPrice { get; set; }
        public string FormattedDateTime { get; set; }
    }
}
