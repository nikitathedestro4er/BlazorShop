using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorShop.Shared;

namespace BlazorShop.Client.Services.CategoryService
{
    public interface ICategoryService
    {
        List<Category> Categories { get; set; }
        Task LoadCategories();
        Task<Dictionary<string, int>> GetCategories();
    }
}