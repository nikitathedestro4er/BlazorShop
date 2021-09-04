using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorShop.Server.Paging;
using BlazorShop.Server.Services.ProductService;
using BlazorShop.Shared;
using BlazorShop.Shared.RequestFeatures;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace BlazorShop.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<ActionResult<PagedList<Product>>> GetAllProducts([FromQuery] ProductParameters productParameters)
        {
            var products = await _productService.GetAllProducts(productParameters);
            Response.Headers.Add("X-Pagination",JsonConvert.SerializeObject(products.MetaData));
            return Ok(products);
        }

        [HttpGet("Category/{categoryUrl}")]
        public async Task<ActionResult<PagedList<Product>>> GetProductsByCategory(string categoryUrl,[FromQuery] ProductParameters productParameters)
        {
            var products = await _productService.GetProductsByCategory(categoryUrl, productParameters);
            Response.Headers.Add("X-Pagination",JsonConvert.SerializeObject(products.MetaData));
            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id) 
        {
            return Ok(await _productService.GetProduct(id));
        }

        
        [HttpPost]
        public async Task<IActionResult> CreateProduct([FromBody] Product product)
        {
            if (product == null)
                return BadRequest();
            await _productService.CreateProduct(product);

            return Created("", product);

        }
        
        [HttpPut("{id}")]
        public async Task<ActionResult<Product>> UpdateProduct(int id,[FromBody]Product product)
        {
            var dbProduct = await _productService.GetProduct(id);
            if (dbProduct == null)
                return NotFound();
            
            await _productService.UpdateProduct(product, dbProduct);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteProduct(int id)
        {
            var product = await _productService.GetProduct(id);
            if(product == null) 
                return NotFound();

            await _productService.DeleteProduct(product);

            return NoContent();
        }
        
    }
}