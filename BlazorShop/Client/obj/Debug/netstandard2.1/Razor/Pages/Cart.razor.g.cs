#pragma checksum "/Users/nikitapinchuk/RiderProjects/BlazorShop copy/BlazorShop/Client/Pages/Cart.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "655423ee22ae83f49d0c72d6262b237bec24de92"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/cart")]
    public partial class Cart : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 4 "/Users/nikitapinchuk/RiderProjects/BlazorShop copy/BlazorShop/Client/Pages/Cart.razor"
 if (!orderPlaced)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.AddMarkupContent(1, "<h3>Shopping Cart</h3>\n");
#nullable restore
#line 7 "/Users/nikitapinchuk/RiderProjects/BlazorShop copy/BlazorShop/Client/Pages/Cart.razor"
     if (cartItems == null || cartItems.Count <= 0)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "        ");
            __builder.AddMarkupContent(3, "<span>You have no items in your cart.</span>\n");
#nullable restore
#line 10 "/Users/nikitapinchuk/RiderProjects/BlazorShop copy/BlazorShop/Client/Pages/Cart.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "        ");
            __builder.OpenElement(5, "div");
            __builder.AddMarkupContent(6, "\n");
#nullable restore
#line 14 "/Users/nikitapinchuk/RiderProjects/BlazorShop copy/BlazorShop/Client/Pages/Cart.razor"
             foreach (var item in cartItems)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(7, "                ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "cart-item-container");
            __builder.AddMarkupContent(10, "\n                    ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "cart-item-image-wrapper");
            __builder.OpenElement(13, "img");
            __builder.AddAttribute(14, "src", 
#nullable restore
#line 17 "/Users/nikitapinchuk/RiderProjects/BlazorShop copy/BlazorShop/Client/Pages/Cart.razor"
                                                                    item.Image

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(15, "class", "cart-item-image");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\n                    ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "cart-item-name");
            __builder.AddMarkupContent(19, "\n                        ");
            __builder.OpenElement(20, "h5");
            __builder.OpenElement(21, "a");
            __builder.AddAttribute(22, "href", "/product/" + (
#nullable restore
#line 19 "/Users/nikitapinchuk/RiderProjects/BlazorShop copy/BlazorShop/Client/Pages/Cart.razor"
                                               item.ProductId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(23, 
#nullable restore
#line 19 "/Users/nikitapinchuk/RiderProjects/BlazorShop copy/BlazorShop/Client/Pages/Cart.razor"
                                                                item.ProductTitle

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\n                        ");
            __builder.OpenElement(25, "button");
            __builder.AddAttribute(26, "class", "cart-btn-delete");
            __builder.AddAttribute(27, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 20 "/Users/nikitapinchuk/RiderProjects/BlazorShop copy/BlazorShop/Client/Pages/Cart.razor"
                                                                    ()=> DeleteItem(item)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(28, "Delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\n                        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(30);
            __builder.AddAttribute(31, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 21 "/Users/nikitapinchuk/RiderProjects/BlazorShop copy/BlazorShop/Client/Pages/Cart.razor"
                                         item

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(32, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(33, "\n                            ");
                __Blazor.BlazorShop.Client.Pages.Cart.TypeInference.CreateInputNumber_0(__builder2, 34, 35, "quantity", 36, "form-control", 37, "width: 70px", 38, 
#nullable restore
#line 22 "/Users/nikitapinchuk/RiderProjects/BlazorShop copy/BlazorShop/Client/Pages/Cart.razor"
                                                                    item.Quantity

#line default
#line hidden
#nullable disable
                , 39, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => item.Quantity = __value, item.Quantity)), 40, () => item.Quantity);
                __builder2.AddMarkupContent(41, "\n                        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(42, "\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\n                    ");
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "class", "cart-item-price");
            __builder.AddContent(46, "$");
            __builder.AddContent(47, 
#nullable restore
#line 25 "/Users/nikitapinchuk/RiderProjects/BlazorShop copy/BlazorShop/Client/Pages/Cart.razor"
                                                    item.Price * item.Quantity

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "    \n");
#nullable restore
#line 27 "/Users/nikitapinchuk/RiderProjects/BlazorShop copy/BlazorShop/Client/Pages/Cart.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(50, "            ");
            __builder.OpenElement(51, "div");
            __builder.AddAttribute(52, "class", "cart-item-price");
            __builder.AddMarkupContent(53, "\n                Total (");
            __builder.AddContent(54, 
#nullable restore
#line 29 "/Users/nikitapinchuk/RiderProjects/BlazorShop copy/BlazorShop/Client/Pages/Cart.razor"
                        cartItems.Count

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(55, "): $");
            __builder.AddContent(56, 
#nullable restore
#line 29 "/Users/nikitapinchuk/RiderProjects/BlazorShop copy/BlazorShop/Client/Pages/Cart.razor"
                                            cartItems.Sum(item=>item.Price * item.Quantity)

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(57, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\n            ");
            __builder.OpenElement(59, "div");
            __builder.AddAttribute(60, "style", "text-align: center; margin-top: 10px;");
            __builder.AddMarkupContent(61, "\n                ");
            __builder.OpenElement(62, "button");
            __builder.AddAttribute(63, "class", "btn btn-primary btn-lg");
            __builder.AddAttribute(64, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 32 "/Users/nikitapinchuk/RiderProjects/BlazorShop copy/BlazorShop/Client/Pages/Cart.razor"
                                                                 PlaceOrder

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(65, "Place Order");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\n");
#nullable restore
#line 35 "/Users/nikitapinchuk/RiderProjects/BlazorShop copy/BlazorShop/Client/Pages/Cart.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "/Users/nikitapinchuk/RiderProjects/BlazorShop copy/BlazorShop/Client/Pages/Cart.razor"
     
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(69, "    ");
            __builder.AddMarkupContent(70, "<h3>Thank you for your order!</h3>\n    ");
            __builder.AddMarkupContent(71, "<h4>Here\'s what you\'ll get:</h4>\n    ");
            __builder.OpenElement(72, "div");
            __builder.AddMarkupContent(73, "\n");
#nullable restore
#line 42 "/Users/nikitapinchuk/RiderProjects/BlazorShop copy/BlazorShop/Client/Pages/Cart.razor"
         foreach (var item in cartItems)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(74, "            ");
            __builder.OpenElement(75, "div");
            __builder.AddAttribute(76, "class", "cart-item-container");
            __builder.AddMarkupContent(77, "\n                ");
            __builder.OpenElement(78, "div");
            __builder.AddAttribute(79, "class", "cart-item-image-wrapper");
            __builder.OpenElement(80, "img");
            __builder.AddAttribute(81, "src", 
#nullable restore
#line 45 "/Users/nikitapinchuk/RiderProjects/BlazorShop copy/BlazorShop/Client/Pages/Cart.razor"
                                                                item.Image

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(82, "class", "cart-item-image");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\n                ");
            __builder.OpenElement(84, "div");
            __builder.AddAttribute(85, "class", "cart-item-name");
            __builder.AddMarkupContent(86, "\n                    ");
            __builder.OpenElement(87, "h5");
            __builder.OpenElement(88, "a");
            __builder.AddAttribute(89, "href", "/product/" + (
#nullable restore
#line 47 "/Users/nikitapinchuk/RiderProjects/BlazorShop copy/BlazorShop/Client/Pages/Cart.razor"
                                           item.ProductId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(90, 
#nullable restore
#line 47 "/Users/nikitapinchuk/RiderProjects/BlazorShop copy/BlazorShop/Client/Pages/Cart.razor"
                                                            item.ProductTitle

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\n                    ");
            __builder.OpenElement(92, "span");
            __builder.AddContent(93, 
#nullable restore
#line 48 "/Users/nikitapinchuk/RiderProjects/BlazorShop copy/BlazorShop/Client/Pages/Cart.razor"
                            item.Quantity

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(94, "X");
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "<br>\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\n                ");
            __builder.OpenElement(97, "div");
            __builder.AddAttribute(98, "class", "cart-item-price");
            __builder.AddContent(99, "$");
            __builder.AddContent(100, 
#nullable restore
#line 50 "/Users/nikitapinchuk/RiderProjects/BlazorShop copy/BlazorShop/Client/Pages/Cart.razor"
                                                item.Price * item.Quantity

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(101, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(102, "    \n");
#nullable restore
#line 52 "/Users/nikitapinchuk/RiderProjects/BlazorShop copy/BlazorShop/Client/Pages/Cart.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(103, "        ");
            __builder.OpenElement(104, "div");
            __builder.AddAttribute(105, "class", "cart-item-price");
            __builder.AddMarkupContent(106, "\n            Total (");
            __builder.AddContent(107, 
#nullable restore
#line 54 "/Users/nikitapinchuk/RiderProjects/BlazorShop copy/BlazorShop/Client/Pages/Cart.razor"
                    cartItems.Count

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(108, "): $");
            __builder.AddContent(109, 
#nullable restore
#line 54 "/Users/nikitapinchuk/RiderProjects/BlazorShop copy/BlazorShop/Client/Pages/Cart.razor"
                                        cartItems.Sum(item=>item.Price * item.Quantity)

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(110, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(111, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(112, "\n");
#nullable restore
#line 57 "/Users/nikitapinchuk/RiderProjects/BlazorShop copy/BlazorShop/Client/Pages/Cart.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 60 "/Users/nikitapinchuk/RiderProjects/BlazorShop copy/BlazorShop/Client/Pages/Cart.razor"
       
    List<CartItem> cartItems = new List<CartItem>();

    bool orderPlaced = false;
    
    protected override async Task OnInitializedAsync()
    {
        cartItems = await CartService.GetCartItems();
    }

    private async Task DeleteItem(CartItem item)
    {
        await CartService.DeleteItem(item);
        cartItems = await CartService.GetCartItems();
    }

    private async Task PlaceOrder()
    {
        orderPlaced = true;
        await CartService.EmptyCart();
    }
    
    


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICartService CartService { get; set; }
    }
}
namespace __Blazor.BlazorShop.Client.Pages.Cart
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, System.Object __arg2, int __seq3, TValue __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "style", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
