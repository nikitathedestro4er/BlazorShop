using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorShop.Server.Data;
using BlazorShop.Server.Services.CategoryService;
using BlazorShop.Shared;
using Microsoft.AspNetCore.Mvc;


namespace BlazorShop.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        private readonly DataContext _context;

        public CategoryController(ICategoryService categoryService,DataContext context)
        {
            _categoryService = categoryService;
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IAsyncEnumerable<Category>>> GetCategories()
        {
            return Ok(await _categoryService.GetCategories());
        }
        
        
        
    }
}