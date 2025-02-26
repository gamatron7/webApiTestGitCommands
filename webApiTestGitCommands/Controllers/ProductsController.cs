using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using webApiTestGitCommands.Models;
using webApiTestGitCommands.Repositories;

namespace webApiTestGitCommands.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductsController(IProductRepository productRepository)
        {
            this._productRepository = productRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                return Ok(await _productRepository.GetProductsAsync());
            }
            catch (System.Exception)
            {
                return this.StatusCode(500, "Ocurrió un error al llamar al endpoint que agrega un producto");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post(Product product)
        {
            try
            {
                await _productRepository.AddProduct(product);
                return this.StatusCode(200);
            }
            catch (System.Exception)
            {
                return this.StatusCode(500, "Ocurrió un error al llamar al endpoint Get de Productos");
            }
        }

    }
}
