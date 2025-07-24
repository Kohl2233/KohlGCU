using System.ComponentModel.DataAnnotations;

namespace ProductsApp.Models
{
    public class ProductViewModel
    {
        public string? Id { get; set; }                                 // Id of Product

        [Required]
        public string Name { get; set; }                                // Name of Product

        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Price must be a postive value")]
        public decimal Price { get; set; }                              // Price of the Product used for Data Entry

        [Display(Name = "Price")]
        public string? FormattedPrice { get; set; }                     // Formatted Price for Display

        [Required]
        public string? Description { get; set; }                        // Description of Product

        [DataType(DataType.Date)]
        public DateTime CreatedAt { get; set; }                         // Used for Data Entry

        [Display(Name = "Created At")]
        public string? FormattedDateTime { get; set; }                  // Formatted Date for Display

        public string? ImageURL { get; set; }                           // Allowed to be null

        [Display(Name = "Upload Image")]
        public IFormFile? ImageFile { get; set; }                       // One of ImageURL (chosen) or ImageFile (uploaded), allowed to be null

        public decimal EstimatedTax { get; set; }                       // Estimated Tax for Product

        [Display(Name = "Tax")]
        public string? FormattedEstimatedTax { get; set; }              // Formatted Tax for Display
    }
}
