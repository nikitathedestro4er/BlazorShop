#pragma checksum "/Users/nikitapinchuk/RiderProjects/BlazorShop copy/BlazorShop/Client/Pages/AdminPages/AdminProducts.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "af433efedd59835391b04cfb3fdb97d8aa5561fd"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorShop.Client.Pages.AdminPages
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
#nullable restore
#line 2 "/Users/nikitapinchuk/RiderProjects/BlazorShop copy/BlazorShop/Client/Pages/AdminPages/AdminProducts.razor"
using BlazorShop.Shared.RequestFeatures;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/nikitapinchuk/RiderProjects/BlazorShop copy/BlazorShop/Client/Pages/AdminPages/AdminProducts.razor"
           [Authorize(Roles = "Administrator")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(SimpleLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/edit/products")]
    public partial class AdminProducts : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row");
            __builder.AddMarkupContent(2, "\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "col-md-5");
            __builder.AddMarkupContent(5, "\n        ");
            __builder.OpenComponent<BlazorShop.Client.Shared.Search>(6);
            __builder.AddAttribute(7, "OnSearchChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#nullable restore
#line 9 "/Users/nikitapinchuk/RiderProjects/BlazorShop copy/BlazorShop/Client/Pages/AdminPages/AdminProducts.razor"
                                 SearchChanged

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(8, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\n");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "col-md-5");
            __builder.AddMarkupContent(12, "\n    ");
            __builder.OpenComponent<BlazorShop.Client.Shared.Sort>(13);
            __builder.AddAttribute(14, "OnSortChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#nullable restore
#line 12 "/Users/nikitapinchuk/RiderProjects/BlazorShop copy/BlazorShop/Client/Pages/AdminPages/AdminProducts.razor"
                         SortChanged

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(15, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\n    ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "col-md-2");
            __builder.AddMarkupContent(19, "\n        ");
            __builder.OpenElement(20, "button");
            __builder.AddAttribute(21, "type", "button");
            __builder.AddAttribute(22, "class", "btn btn-primary");
            __builder.AddAttribute(23, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "/Users/nikitapinchuk/RiderProjects/BlazorShop copy/BlazorShop/Client/Pages/AdminPages/AdminProducts.razor"
                                                                () => RedirectToCreate()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(24, "Create Product");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\n");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "row");
            __builder.AddMarkupContent(30, "\n    ");
            __builder.OpenComponent<BlazorShop.Client.Pages.AdminPages.AdminShared.AdminProductList>(31);
            __builder.AddAttribute(32, "Products", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<BlazorShop.Shared.Product>>(
#nullable restore
#line 19 "/Users/nikitapinchuk/RiderProjects/BlazorShop copy/BlazorShop/Client/Pages/AdminPages/AdminProducts.razor"
                                ProductList

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(33, "OnDeleted", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, 
#nullable restore
#line 19 "/Users/nikitapinchuk/RiderProjects/BlazorShop copy/BlazorShop/Client/Pages/AdminPages/AdminProducts.razor"
                                                        DeleteProduct

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(34, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\n");
            __builder.OpenElement(36, "div");
            __builder.AddAttribute(37, "class", "row");
            __builder.AddMarkupContent(38, "\n    ");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "class", "col");
            __builder.AddMarkupContent(41, "\n        ");
            __builder.OpenComponent<BlazorShop.Client.Shared.Pagination>(42);
            __builder.AddAttribute(43, "MetaData", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorShop.Shared.RequestFeatures.MetaData>(
#nullable restore
#line 23 "/Users/nikitapinchuk/RiderProjects/BlazorShop copy/BlazorShop/Client/Pages/AdminPages/AdminProducts.razor"
                              MetaData

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(44, "Spread", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 23 "/Users/nikitapinchuk/RiderProjects/BlazorShop copy/BlazorShop/Client/Pages/AdminPages/AdminProducts.razor"
                                                2

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(45, "SelectedPage", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, 
#nullable restore
#line 23 "/Users/nikitapinchuk/RiderProjects/BlazorShop copy/BlazorShop/Client/Pages/AdminPages/AdminProducts.razor"
                                                                 SelectedPage

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(46, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 26 "/Users/nikitapinchuk/RiderProjects/BlazorShop copy/BlazorShop/Client/Pages/AdminPages/AdminProducts.razor"
       
    
    [Parameter]
    public string CategoryUrl { get; set; }
    
    [Inject]
    public NavigationManager NavigationManager { get; set; }
    
    public List<Product> ProductList { get; set; } = new List<Product>();
    public MetaData MetaData { get; set; } = new MetaData();

    private ProductParameters _productParameters = new ProductParameters();

    [Inject]
    public IProductService ProductService { get; set; }

    protected async override Task OnParametersSetAsync()
    {
        await GetProducts();
    }
    

    private async Task SelectedPage(int page)
    {
        _productParameters.PageNumber = page;
        await GetProducts();
    }

    private async Task GetProducts()
    {
        var pagingResponse = await ProductService.GetProducts(_productParameters,CategoryUrl);
        ProductList = pagingResponse.Items;
        MetaData = pagingResponse.MetaData;
    }
    
    private async Task SearchChanged(string searchTerm)
    {
        Console.WriteLine(searchTerm);
        _productParameters.PageNumber = 1;
        _productParameters.SearchTerm = searchTerm;
        await GetProducts();
    }
    
    private async Task SortChanged(string orderBy)
    {
        Console.WriteLine(orderBy);
        _productParameters.OrderBy = orderBy;
        await GetProducts();
    }

    private async Task DeleteProduct(int id)
    {
        await ProductService.DeleteProduct(id);
        _productParameters.PageNumber = 1;
        await GetProducts();
    }
    
    private void RedirectToCreate()
    {
        NavigationManager.NavigateTo($"edit/createproduct");
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
