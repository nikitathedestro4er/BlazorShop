#pragma checksum "/Users/nikitapinchuk/RiderProjects/BlazorShop copy/BlazorShop/Client/Shared/ProductList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7e38174e0a5a51de5048222c3a13c1150f2a57a6"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorShop.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/nikitapinchuk/RiderProjects/BlazorShop copy/BlazorShop/Client/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/nikitapinchuk/RiderProjects/BlazorShop copy/BlazorShop/Client/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/nikitapinchuk/RiderProjects/BlazorShop copy/BlazorShop/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/nikitapinchuk/RiderProjects/BlazorShop copy/BlazorShop/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/nikitapinchuk/RiderProjects/BlazorShop copy/BlazorShop/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/nikitapinchuk/RiderProjects/BlazorShop copy/BlazorShop/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/nikitapinchuk/RiderProjects/BlazorShop copy/BlazorShop/Client/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/nikitapinchuk/RiderProjects/BlazorShop copy/BlazorShop/Client/_Imports.razor"
using BlazorShop.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/nikitapinchuk/RiderProjects/BlazorShop copy/BlazorShop/Client/_Imports.razor"
using BlazorShop.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/nikitapinchuk/RiderProjects/BlazorShop copy/BlazorShop/Client/_Imports.razor"
using BlazorShop.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/nikitapinchuk/RiderProjects/BlazorShop copy/BlazorShop/Client/_Imports.razor"
using BlazorShop.Client.Services.CategoryService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/Users/nikitapinchuk/RiderProjects/BlazorShop copy/BlazorShop/Client/_Imports.razor"
using BlazorShop.Client.Services.ProductService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/Users/nikitapinchuk/RiderProjects/BlazorShop copy/BlazorShop/Client/_Imports.razor"
using BlazorShop.Client.Services.CartService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "/Users/nikitapinchuk/RiderProjects/BlazorShop copy/BlazorShop/Client/_Imports.razor"
using BlazorShop.Client.Services.StatsService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "/Users/nikitapinchuk/RiderProjects/BlazorShop copy/BlazorShop/Client/_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "/Users/nikitapinchuk/RiderProjects/BlazorShop copy/BlazorShop/Client/_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "/Users/nikitapinchuk/RiderProjects/BlazorShop copy/BlazorShop/Client/_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "/Users/nikitapinchuk/RiderProjects/BlazorShop copy/BlazorShop/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "/Users/nikitapinchuk/RiderProjects/BlazorShop copy/BlazorShop/Client/_Imports.razor"
using Blazored.Typeahead;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "/Users/nikitapinchuk/RiderProjects/BlazorShop copy/BlazorShop/Client/_Imports.razor"
using BlazorShop.Shared.DTO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "/Users/nikitapinchuk/RiderProjects/BlazorShop copy/BlazorShop/Client/_Imports.razor"
using BlazorShop.Client.Services.AuthenticationService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "/Users/nikitapinchuk/RiderProjects/BlazorShop copy/BlazorShop/Client/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "/Users/nikitapinchuk/RiderProjects/BlazorShop copy/BlazorShop/Client/_Imports.razor"
using BlazorShop.Client.Pages.AdminPages.AdminShared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "/Users/nikitapinchuk/RiderProjects/BlazorShop copy/BlazorShop/Client/_Imports.razor"
using BlazorStrap;

#line default
#line hidden
#nullable disable
    public partial class ProductList : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 4 "/Users/nikitapinchuk/RiderProjects/BlazorShop copy/BlazorShop/Client/Shared/ProductList.razor"
 if (Products.Count > 0)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.OpenElement(1, "ul");
            __builder.AddAttribute(2, "class", "list-unstyled");
            __builder.AddMarkupContent(3, "\n");
#nullable restore
#line 7 "/Users/nikitapinchuk/RiderProjects/BlazorShop copy/BlazorShop/Client/Shared/ProductList.razor"
         foreach (var product in Products)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "            ");
            __builder.OpenElement(5, "li");
            __builder.AddAttribute(6, "class", "media my-3");
            __builder.AddMarkupContent(7, "\n                ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "media-img-wrapper mr-2");
            __builder.AddMarkupContent(10, "\n                    ");
            __builder.OpenElement(11, "a");
            __builder.AddAttribute(12, "href", "/product/" + (
#nullable restore
#line 11 "/Users/nikitapinchuk/RiderProjects/BlazorShop copy/BlazorShop/Client/Shared/ProductList.razor"
                                       product.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(13, "\n                        ");
            __builder.OpenElement(14, "img");
            __builder.AddAttribute(15, "class", "media-img");
            __builder.AddAttribute(16, "src", 
#nullable restore
#line 12 "/Users/nikitapinchuk/RiderProjects/BlazorShop copy/BlazorShop/Client/Shared/ProductList.razor"
                                                     product.Image

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(17, "alt", 
#nullable restore
#line 12 "/Users/nikitapinchuk/RiderProjects/BlazorShop copy/BlazorShop/Client/Shared/ProductList.razor"
                                                                          product.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\n                ");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "media-body");
            __builder.AddMarkupContent(23, "\n                    ");
            __builder.OpenElement(24, "a");
            __builder.AddAttribute(25, "href", "/product/" + (
#nullable restore
#line 16 "/Users/nikitapinchuk/RiderProjects/BlazorShop copy/BlazorShop/Client/Shared/ProductList.razor"
                                       product.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(26, "\n                        ");
            __builder.OpenElement(27, "h4");
            __builder.AddAttribute(28, "class", "mb-0");
            __builder.AddContent(29, 
#nullable restore
#line 17 "/Users/nikitapinchuk/RiderProjects/BlazorShop copy/BlazorShop/Client/Shared/ProductList.razor"
                                          product.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\n                    ");
            __builder.OpenElement(32, "p");
            __builder.AddContent(33, 
#nullable restore
#line 19 "/Users/nikitapinchuk/RiderProjects/BlazorShop copy/BlazorShop/Client/Shared/ProductList.razor"
                        product.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\n");
#nullable restore
#line 20 "/Users/nikitapinchuk/RiderProjects/BlazorShop copy/BlazorShop/Client/Shared/ProductList.razor"
                     if (product.OriginalPrice > product.Price)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(35, "                        ");
            __builder.OpenElement(36, "h6");
            __builder.AddAttribute(37, "class", "text-muted original-price");
            __builder.AddContent(38, "$");
            __builder.AddContent(39, 
#nullable restore
#line 22 "/Users/nikitapinchuk/RiderProjects/BlazorShop copy/BlazorShop/Client/Shared/ProductList.razor"
                                                                GetPriceString(product.OriginalPrice)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\n");
#nullable restore
#line 23 "/Users/nikitapinchuk/RiderProjects/BlazorShop copy/BlazorShop/Client/Shared/ProductList.razor"
                                
                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(41, "                    ");
            __builder.OpenElement(42, "h4");
            __builder.AddAttribute(43, "class", "price");
            __builder.AddMarkupContent(44, "\n                        $");
            __builder.AddContent(45, 
#nullable restore
#line 26 "/Users/nikitapinchuk/RiderProjects/BlazorShop copy/BlazorShop/Client/Shared/ProductList.razor"
                          GetPriceString(product.Price)

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(46, "\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\n            <li class=\"dropdown-divider\"></li>\n");
#nullable restore
#line 31 "/Users/nikitapinchuk/RiderProjects/BlazorShop copy/BlazorShop/Client/Shared/ProductList.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(50, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\n");
#nullable restore
#line 33 "/Users/nikitapinchuk/RiderProjects/BlazorShop copy/BlazorShop/Client/Shared/ProductList.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(52, "    ");
            __builder.AddMarkupContent(53, "<span>\n        Loading products...\n    </span>\n");
#nullable restore
#line 39 "/Users/nikitapinchuk/RiderProjects/BlazorShop copy/BlazorShop/Client/Shared/ProductList.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "/Users/nikitapinchuk/RiderProjects/BlazorShop copy/BlazorShop/Client/Shared/ProductList.razor"
       

    // [Parameter]
    // public int? CategoryId { get; set; } = null;
    [Parameter]
    public List<Product> Products { get; set; } = new List<Product>();
    
    protected override void OnInitialized()
    {
        //await ProductService.LoadProducts();
        ProductService.OnChange += StateHasChanged;
    }

    public void Dispose()
    {
        ProductService.OnChange -= StateHasChanged;
    }
    
    private string GetPriceString(decimal price)
    {
        if (price >= 1000000)
            return $"{((float)price / 1000000).ToString("#.##")}M";
        if (price > 100000)
            return $"{((float)price / 1000).ToString("#")}K";

        return price.ToString("0##");
    }

    


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProductService ProductService { get; set; }
    }
}
#pragma warning restore 1591
