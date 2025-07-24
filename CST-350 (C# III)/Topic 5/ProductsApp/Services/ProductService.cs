using ProductsApp.Models;

namespace ProductsApp.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductDAO _productDAO;
        private readonly IProductMapper _productMapper;

        public ProductService(IProductDAO productDAO, IProductMapper productMapper)
        {
            _productDAO = productDAO;
            _productMapper = productMapper;
        }

        public async Task<int> AddProduct(ProductViewModel productViewModel)
        {
            var productDTO = _productMapper.ToDTO(productViewModel);
            var productModel = _productMapper.ToModel(productDTO);
            return await _productDAO.AddProduct(productModel);
        }

        public Task DeleteProduct(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ProductViewModel>> GetAllProducts()
        {
            IEnumerable<ProductModel> productModels = await _productDAO.GetAllProducts(); // fetch all from databse

            List<ProductViewModel> productViewModels = new List<ProductViewModel>();

            foreach (var productModel in productModels)
            {
                ProductDTO productDTO = _productMapper.ToDTO(productModel);
                ProductViewModel productViewModel = _productMapper.ToViewModel(productDTO);
                productViewModels.Add(productViewModel);
            }
            return productViewModels;
        }

        public Task<ProductViewModel> GetProductById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ProductViewModel>> SearchForProducts(SearchFor searchTerm)
        {
            throw new NotImplementedException();
        }

        public Task UpdateProduct(ProductViewModel product)
        {
            throw new NotImplementedException();
        }
    }
}
