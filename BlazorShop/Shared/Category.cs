using System.Collections;
using System.Collections.Generic;

namespace BlazorShop.Shared
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string Icon { get; set; }
        public IEnumerable<Product> Products { get; set; }
    }
} 