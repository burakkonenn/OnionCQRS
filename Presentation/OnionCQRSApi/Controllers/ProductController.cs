using Application.Abstractions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace OnionCQRSApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            this._productService = productService;
        }

        public IActionResult GetProducts()
        {
            var allProducts = _productService.GetAllProducts().Select(a => new {a.Id, a.Name}).ToList();
            return Ok(allProducts);
        }
    }
}
