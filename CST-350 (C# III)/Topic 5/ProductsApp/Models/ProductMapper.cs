namespace ProductsApp.Models
{
    public class ProductMapper : IProductMapper
    {
        public string CurrencyFormat { get; set; } = "C"; // currency format
        public string DateFormat { get; set; } = "D"; // date format
        public decimal TaxRate { get; set; } = 0.08m; // 8% tax rate

        public ProductMapper(string currency, string dateFormat, decimal tax)
        {
            CurrencyFormat = currency;
            DateFormat = dateFormat;
            TaxRate = tax;
        }

        // Convert from ProductModel to ProductDTO
        public ProductDTO ToDTO(ProductModel model)
        {
            return new ProductDTO
            {
                Id = model.Id.ToString(), // convert id to a string
                Name = model.Name,
                Price = model.Price,
                Description = model.Description,
                ImageURL = model.ImageURL,
                EstimatedTax = model.Price * TaxRate,
                FormattedPrice = model.Price.ToString(CurrencyFormat)
            };
        }

        public ProductDTO ToDTO(ProductViewModel viewModel)
        {
            // creating a new product, id is not yet set
            if (viewModel.Id == null)
            {
                return new ProductDTO
                {
                    Name = viewModel.Name,
                    Price = viewModel.Price,
                    Description = viewModel.Description,
                    CreatedAt = viewModel.CreatedAt,
                    ImageURL = viewModel.ImageURL
                };
            }

            return new ProductDTO
            {
                Id = viewModel.Id,
                Name = viewModel.Name,
                Price = viewModel.Price,
                Description = viewModel.Description,
                CreatedAt = viewModel.CreatedAt,
                ImageURL = viewModel.ImageURL
            };
        }

        public ProductModel ToModel(ProductDTO dto)
        {
            if (dto.Id == null)
            {
                // comes from the create form, Id is not yet set and the database will assign it
                return new ProductModel
                {
                    Name = dto.Name,
                    Price = dto.Price,
                    Description = dto.Description,
                    CreatedAt = dto.CreatedAt,
                    ImageURL = dto.ImageURL ?? string.Empty
                };
            }

            return new ProductModel
            {
                Id = int.Parse(dto.Id),
                Name = dto.Name,
                Price = dto.Price,
                Description = dto.Description,
                CreatedAt = dto.CreatedAt,
                ImageURL = dto.ImageURL ?? string.Empty
            };
        }

        public ProductViewModel ToViewModel(ProductDTO dto)
        {
            return new ProductViewModel
            {
                Id = dto.Id,
                Name = dto.Name,
                Price = dto.Price,
                Description = dto.Description,
                CreatedAt = dto.CreatedAt,
                ImageURL = dto.ImageURL,
                EstimatedTax = dto.EstimatedTax,
                FormattedPrice = dto.FormattedPrice,
                FormattedDateTime = dto.FormattedDateTime
            };
        }
    }
}
