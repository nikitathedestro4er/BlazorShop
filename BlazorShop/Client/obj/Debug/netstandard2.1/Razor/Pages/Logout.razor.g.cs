#pragma checksum "/Users/nikitapinchuk/RiderProjects/BlazorShop copy/BlazorShop/Client/Pages/Logout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e0f8b10023281a6ef0c7345dccb4ee2646bca233"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorShop.Client.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Logout")]
    public partial class Logout : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 5 "/Users/nikitapinchuk/RiderProjects/BlazorShop copy/BlazorShop/Client/Pages/Logout.razor"
       
    
    [Inject]
    public IAuthenticationService AuthenticationService { get; set; }
    
    [Inject]
    public NavigationManager NavigationManager { get; set; }

    protected override async Task OnInitializedAsync()
    {
        await AuthenticationService.Logout();
        NavigationManager.NavigateTo("/");
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
