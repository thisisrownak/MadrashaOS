using MadrashaOS.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace MadrashaOS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        //private readonly ProductService _productService;

        //public ProductController(ProductService productService)
        //{
        //    _productService = productService;
        //}

        [HttpGet("error")]
        public IActionResult ThrowError()
        {
            // Forcefully throw an exception to test middleware
            throw new Exception("This is a test exception!");
        }
    }
}
