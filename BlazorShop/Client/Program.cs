using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Blazored.LocalStorage;
using Blazored.Toast;
using BlazorShop.Client.AuthProviders;
using BlazorShop.Client.Services.AuthenticationService;
using BlazorShop.Client.Services.CartService;
using BlazorShop.Client.Services.ProductService;
using BlazorShop.Client.Services.CategoryService;
using BlazorShop.Client.Services.StatsService;
using Microsoft.AspNetCore.Components.Authorization;

namespace BlazorShop.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddScoped<IProductService, ProductService>();
            builder.Services.AddScoped<ICategoryService, CategoryService>();
            builder.Services.AddScoped<ICartService, CartService>();
            builder.Services.AddBlazoredLocalStorage();
            builder.Services.AddBlazoredToast();
            builder.Services.AddOptions();
            builder.Services.AddAuthorizationCore();
            builder.Services.AddScoped<AuthenticationStateProvider, AuthStateProvider>();
            builder.Services.AddScoped<IStatsService, StatsService>();
            builder.Services.AddScoped<IAuthenticationService, AuthenticationService>();
            
            await builder.Build().RunAsync();
        }
    }
}
