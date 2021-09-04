using System;
using System.Linq;
using System.Reflection;
using System.Text;
using BlazorShop.Shared;
using System.Linq.Dynamic.Core;
using Microsoft.EntityFrameworkCore;

namespace BlazorShop.Server.Services.ProductService
{
    public static class ProductServiceExtensions
    {
        public static IQueryable<Product> Search(this IQueryable<Product> products, string searchTearm)
        {
            if (string.IsNullOrWhiteSpace(searchTearm))
                return products;

            var lowerCaseSearchTerm = searchTearm.Trim().ToLower();

            return products.Where(p => p.Title.ToLower().Contains(lowerCaseSearchTerm));
        }

        public static IQueryable<Product> Sort(this IQueryable<Product> products, string orderByQueryString)
        {
            if (string.IsNullOrWhiteSpace(orderByQueryString))
                return products.OrderBy(e => e.Title);

            // switch (orderByQueryString)
            // {
            //     case "title":
            //         return products.OrderBy(p => p.Title);
            //     case "title desc":
            //         return products.OrderByDescending(p => p.Title);
            //     case "price":
            //         return products.OrderBy(p => p.Price);
            //     case "price desc":
            //         return products.OrderByDescending(p => p.Title);
            //     default:
            //         return products.OrderBy(p => p.Title);
            // }
            
            var orderParams = orderByQueryString.Trim().Split(','); 
            var propertyInfos = typeof(Product).GetProperties(BindingFlags.Public | BindingFlags.Instance); 
            var orderQueryBuilder = new StringBuilder(); 
            
            foreach (var param in orderParams) 
            { 
                if (string.IsNullOrWhiteSpace(param)) 
                    continue; 
                
                var propertyFromQueryName = param.Split(" ")[0]; 
                var objectProperty = propertyInfos.FirstOrDefault(pi => pi.Name.Equals(propertyFromQueryName, StringComparison.InvariantCultureIgnoreCase)); 
                
                if (objectProperty == null) 
                    continue; 
                
                var direction = param.EndsWith(" desc") ? "descending" : "ascending"; 
                orderQueryBuilder.Append($"{objectProperty.Name} {direction}, "); 
            } 
            
            var orderQuery = orderQueryBuilder.ToString().TrimEnd(',', ' '); 
            if (string.IsNullOrWhiteSpace(orderQuery)) 
                return products.OrderBy(e => e.Title); 
            
            return products.OrderBy(orderQuery); 

            

            
        }
    }
}