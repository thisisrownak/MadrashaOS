using MadrashaOS.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace MadrashaOS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ProductService _productService;

        public ProductController(ProductService productService)
        {
            _productService = productService;
        }
    }
}
