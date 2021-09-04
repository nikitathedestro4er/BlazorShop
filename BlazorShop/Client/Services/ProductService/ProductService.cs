using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using BlazorShop.Client.Features;
using BlazorShop.Shared;
using BlazorShop.Shared.RequestFeatures;
using Microsoft.AspNetCore.WebUtilities;

namespace BlazorShop.Client.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _http;
        private readonly JsonSerializerOptions _options;

        public event Action OnChange;

        public ProductService(HttpClient http)
        {
            _http = http;
            _options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        }

        public async Task<PagingResponse<Product>> GetProducts(ProductParameters productParameters,string categoryUrl = null)
        {
            var queryStringParam = new Dictionary<string, string>
            {
                ["pageNumber"] = productParameters.PageNumber.ToString(),
                ["searchTerm"] = productParameters.SearchTerm == null ? "" : productParameters.SearchTerm,
                ["orderBy"] = productParameters.OrderBy
            };
            HttpResponseMessage response;
            if (categoryUrl == null)
            {
                //Products = await _http.GetFromJsonAsync<List<Product>>("api/Product");
                response = await _http.GetAsync(QueryHelpers.AddQueryString("api/Product", queryStringParam));
            }
            else
            { 
                //Products = await _http.GetFromJsonAsync<List<Product>>($"api/Product/Category/{categoryUrl}");
                response = await _http.GetAsync(QueryHelpers.AddQueryString($"api/Product/Category/{categoryUrl}", queryStringParam));
            }
            var content = await response.Content.ReadAsStringAsync();

            var pagingResponse = new PagingResponse<Product>
            {
                Items = JsonSerializer.Deserialize<List<Product>>(content,_options),
                MetaData = JsonSerializer.Deserialize<MetaData>(response.Headers.GetValues("X-Pagination").First(),_options)
            };
            
            OnChange.Invoke();

            return pagingResponse;
        }

        public async Task<Product> GetProduct(int id)
        {
            return await _http.GetFromJsonAsync<Product>($"api/Product/{id}");
        }

        public async Task CreateProduct(Product product)
        {
            var content = JsonSerializer.Serialize(product);
            var bodyContent = new StringContent(content, Encoding.UTF8, "application/json");

            var postResult = await _http.PostAsync("api/Product", bodyContent);

            var postContent = await postResult.Content.ReadAsStringAsync();

            if (!postResult.IsSuccessStatusCode)
            {
                throw new ApplicationException(postContent);
            }

        }

        public async Task UpdateProduct(Product product)
        {
            var content = JsonSerializer.Serialize(product);
            var bodyContent = new StringContent(content, Encoding.UTF8, "application/json");

            var putResult = await _http.PutAsync($"api/Product/{product.Id}", bodyContent);
            var putContent = await putResult.Content.ReadAsStringAsync();

            if (!putResult.IsSuccessStatusCode)
            {
                throw new ApplicationException(putContent);
            }
        }

        public async Task DeleteProduct(int id)
        {
            var deleteResult = await _http.DeleteAsync($"api/Product/{id}");
            var deleteContent = await deleteResult.Content.ReadAsStringAsync();

            if (!deleteResult.IsSuccessStatusCode)
            {
                throw new ApplicationException(deleteContent);
            }
        }
    }
}