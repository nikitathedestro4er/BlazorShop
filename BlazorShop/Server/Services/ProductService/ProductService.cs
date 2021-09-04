using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorShop.Server.Data;
using BlazorShop.Server.Paging;
using BlazorShop.Server.Services.CategoryService;
using BlazorShop.Shared;
using BlazorShop.Shared.RequestFeatures;
using Microsoft.EntityFrameworkCore;

namespace BlazorShop.Server.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly ICategoryService _categoryService;
        private readonly DataContext _context;

        public ProductService(ICategoryService categoryService, DataContext context)
        {
            _categoryService = categoryService;
            _context = context;
        }

        public async Task<PagedList<Product>> GetAllProducts(ProductParameters productParameters)
        {
            var products = await _context.Products
                .Search(productParameters.SearchTerm)
                .Sort(productParameters.OrderBy).ToListAsync();
            
            return PagedList<Product>.ToPagedList(products, productParameters.PageNumber, productParameters.PageSize);
        }
        
        public async Task<PagedList<Product>> GetProductsByCategory(string categoryUrl,ProductParameters productParameters)
        {
            Category category = await _categoryService.GetCategoryByUrl(categoryUrl);
            var products = await _context.Products
                .Search(productParameters.SearchTerm)
                .Sort(productParameters.OrderBy)
                .Where(p => p.CategoryId == category.Id).ToListAsync();
            
            return PagedList<Product>.ToPagedList(products, productParameters.PageNumber, productParameters.PageSize);
        }

        public async Task<Product> GetProduct(int id)
        {
            Product product = await _context.Products
                .FirstOrDefaultAsync(p => p.Id == id);

            product.Views++;

            await _context.SaveChangesAsync();
            
            return product;
        }

        public async Task CreateProduct(Product product)
        {
            _context.Add(product);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateProduct(Product product, Product dbProduct)
        {
            dbProduct.Title = product.Title;
            dbProduct.Description = product.Description;
            dbProduct.Image = product.Image;
            dbProduct.CategoryId = product.CategoryId;
            dbProduct.Price = product.Price;
            dbProduct.OriginalPrice = product.OriginalPrice;
            dbProduct.DateUpdated = DateTime.Now;

            await _context.SaveChangesAsync();
        }

        public async Task DeleteProduct(Product product)
        {
            _context.Remove(product);
            await _context.SaveChangesAsync();
        }
    }
}