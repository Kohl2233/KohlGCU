using Microsoft.AspNetCore.Mvc;
using ProductsApp.Models;
using ProductsApp.Services;
using System.Diagnostics;

namespace ProductsApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductService _productService; // second item added by dependency injection

        public HomeController(ILogger<HomeController> logger, IProductService productService)
        {
            _logger = logger;
            _productService = productService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult ShowCreateProductForm()
        {
            var productViewModel = new ProductViewModel();
            productViewModel.CreatedAt = DateTime.Now;
            return View(productViewModel);
        }
        [HttpPost]
        public async Task<IActionResult> CreateProduct(ProductViewModel productViewModel)
        {
            await _productService.AddProduct(productViewModel);
            return RedirectToAction(nameof(Index));
        }
        /*
        public IActionResult ShowAllProducts()
        {
            List<ProductViewModel> products = _productService.GetAllProducts().Result.ToList();
            return View(products);
        }
        */
        public async Task<IActionResult> ShowAllProducts()
        {
            IEnumerable<ProductViewModel> products = await _productService.GetAllProducts();
            return View(products);
        }
        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
