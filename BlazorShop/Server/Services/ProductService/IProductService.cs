using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorShop.Shared;
using BlazorShop.Shared.RequestFeatures;
using BlazorShop.Server.Paging;

namespace BlazorShop.Server.Services.ProductService
{
    public interface IProductService
    {
        Task<PagedList<Product>> GetAllProducts(ProductParameters productParameters);
        Task<PagedList<Product>> GetProductsByCategory(string categoryUrl,ProductParameters productParameters);
        Task<Product> GetProduct(int id);
        Task CreateProduct(Product product);

        Task UpdateProduct(Product product, Product dbProduct);

        Task DeleteProduct(Product product);


    }
}