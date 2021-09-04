using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorShop.Client.Features;
using BlazorShop.Shared;
using BlazorShop.Shared.RequestFeatures;

namespace BlazorShop.Client.Services.ProductService
{
    public interface IProductService
    {
        event Action OnChange;
        Task<PagingResponse<Product>> GetProducts(ProductParameters productParameters,string categoryUrl = null);

        Task<Product> GetProduct(int id);

        Task CreateProduct(Product product);

        Task UpdateProduct(Product product);

        Task DeleteProduct(int id);
    }
}