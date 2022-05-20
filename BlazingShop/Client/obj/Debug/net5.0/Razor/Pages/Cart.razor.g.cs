#pragma checksum "C:\Users\king\Downloads\Compressed\BlazingShop-master\BlazingShop\Client\Pages\Cart.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6c0d233044ab5ae05345ff05ce0823faed10740d"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazingShop.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\king\Downloads\Compressed\BlazingShop-master\BlazingShop\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\king\Downloads\Compressed\BlazingShop-master\BlazingShop\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\king\Downloads\Compressed\BlazingShop-master\BlazingShop\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\king\Downloads\Compressed\BlazingShop-master\BlazingShop\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\king\Downloads\Compressed\BlazingShop-master\BlazingShop\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\king\Downloads\Compressed\BlazingShop-master\BlazingShop\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\king\Downloads\Compressed\BlazingShop-master\BlazingShop\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\king\Downloads\Compressed\BlazingShop-master\BlazingShop\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\king\Downloads\Compressed\BlazingShop-master\BlazingShop\Client\_Imports.razor"
using BlazingShop.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\king\Downloads\Compressed\BlazingShop-master\BlazingShop\Client\_Imports.razor"
using BlazingShop.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\king\Downloads\Compressed\BlazingShop-master\BlazingShop\Client\_Imports.razor"
using BlazingShop.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\king\Downloads\Compressed\BlazingShop-master\BlazingShop\Client\_Imports.razor"
using BlazingShop.Client.Services.ProductService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\king\Downloads\Compressed\BlazingShop-master\BlazingShop\Client\_Imports.razor"
using BlazingShop.Client.Services.CategoryService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\king\Downloads\Compressed\BlazingShop-master\BlazingShop\Client\_Imports.razor"
using BlazingShop.Client.Services.CartService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\king\Downloads\Compressed\BlazingShop-master\BlazingShop\Client\_Imports.razor"
using BlazingShop.Client.Services.StatsService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\king\Downloads\Compressed\BlazingShop-master\BlazingShop\Client\_Imports.razor"
using BlazingShop.Client.Services.AuthService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\king\Downloads\Compressed\BlazingShop-master\BlazingShop\Client\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\king\Downloads\Compressed\BlazingShop-master\BlazingShop\Client\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\king\Downloads\Compressed\BlazingShop-master\BlazingShop\Client\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\king\Downloads\Compressed\BlazingShop-master\BlazingShop\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\king\Downloads\Compressed\BlazingShop-master\BlazingShop\Client\_Imports.razor"
using Blazored.Typeahead;

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
#line 4 "C:\Users\king\Downloads\Compressed\BlazingShop-master\BlazingShop\Client\Pages\Cart.razor"
 if (!orderPlaced)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<h3 b-awyj8ajjqg>Shopping Cart</h3>");
#nullable restore
#line 7 "C:\Users\king\Downloads\Compressed\BlazingShop-master\BlazingShop\Client\Pages\Cart.razor"
     if (cartItems == null || cartItems.Count <= 0)
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<span b-awyj8ajjqg>You have no items in your cart.</span>");
#nullable restore
#line 10 "C:\Users\king\Downloads\Compressed\BlazingShop-master\BlazingShop\Client\Pages\Cart.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "b-awyj8ajjqg");
#nullable restore
#line 14 "C:\Users\king\Downloads\Compressed\BlazingShop-master\BlazingShop\Client\Pages\Cart.razor"
             foreach (var item in cartItems)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "item-container");
            __builder.AddAttribute(6, "b-awyj8ajjqg");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "item-image-wrapper");
            __builder.AddAttribute(9, "b-awyj8ajjqg");
            __builder.OpenElement(10, "img");
            __builder.AddAttribute(11, "src", 
#nullable restore
#line 17 "C:\Users\king\Downloads\Compressed\BlazingShop-master\BlazingShop\Client\Pages\Cart.razor"
                                                               item.Image

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(12, "class", "item-image");
            __builder.AddAttribute(13, "b-awyj8ajjqg");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\n                    ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "item-name");
            __builder.AddAttribute(17, "b-awyj8ajjqg");
            __builder.OpenElement(18, "h5");
            __builder.AddAttribute(19, "b-awyj8ajjqg");
            __builder.OpenElement(20, "a");
            __builder.AddAttribute(21, "href", "/product/" + (
#nullable restore
#line 19 "C:\Users\king\Downloads\Compressed\BlazingShop-master\BlazingShop\Client\Pages\Cart.razor"
                                               item.ProductId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "b-awyj8ajjqg");
#nullable restore
#line 19 "C:\Users\king\Downloads\Compressed\BlazingShop-master\BlazingShop\Client\Pages\Cart.razor"
__builder.AddContent(23, item.ProductTitle);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\n                        ");
            __builder.OpenElement(25, "span");
            __builder.AddAttribute(26, "b-awyj8ajjqg");
#nullable restore
#line 20 "C:\Users\king\Downloads\Compressed\BlazingShop-master\BlazingShop\Client\Pages\Cart.razor"
__builder.AddContent(27, item.EditionName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "<br b-awyj8ajjqg>\n                        ");
            __builder.OpenElement(29, "button");
            __builder.AddAttribute(30, "class", "btn-delete");
            __builder.AddAttribute(31, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 21 "C:\Users\king\Downloads\Compressed\BlazingShop-master\BlazingShop\Client\Pages\Cart.razor"
                                                               () => DeleteItem(item)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(32, "b-awyj8ajjqg");
            __builder.AddContent(33, "Delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\n                        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(35);
            __builder.AddAttribute(36, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 22 "C:\Users\king\Downloads\Compressed\BlazingShop-master\BlazingShop\Client\Pages\Cart.razor"
                                         item

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(37, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __Blazor.BlazingShop.Client.Pages.Cart.TypeInference.CreateInputNumber_0(__builder2, 38, 39, "quantity", 40, "form-control", 41, "width: 70px", 42, 
#nullable restore
#line 23 "C:\Users\king\Downloads\Compressed\BlazingShop-master\BlazingShop\Client\Pages\Cart.razor"
                                                                    item.Quantity

#line default
#line hidden
#nullable disable
                , 43, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => item.Quantity = __value, item.Quantity)), 44, () => item.Quantity);
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\n                    ");
            __builder.OpenElement(46, "div");
            __builder.AddAttribute(47, "class", "item-price");
            __builder.AddAttribute(48, "b-awyj8ajjqg");
            __builder.AddContent(49, "$");
#nullable restore
#line 27 "C:\Users\king\Downloads\Compressed\BlazingShop-master\BlazingShop\Client\Pages\Cart.razor"
__builder.AddContent(50, item.Price * item.Quantity);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 29 "C:\Users\king\Downloads\Compressed\BlazingShop-master\BlazingShop\Client\Pages\Cart.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(51, "div");
            __builder.AddAttribute(52, "class", "item-price");
            __builder.AddAttribute(53, "b-awyj8ajjqg");
            __builder.AddMarkupContent(54, "\n                Total (");
#nullable restore
#line 31 "C:\Users\king\Downloads\Compressed\BlazingShop-master\BlazingShop\Client\Pages\Cart.razor"
__builder.AddContent(55, cartItems.Count);

#line default
#line hidden
#nullable disable
            __builder.AddContent(56, "): $");
#nullable restore
#line 31 "C:\Users\king\Downloads\Compressed\BlazingShop-master\BlazingShop\Client\Pages\Cart.razor"
__builder.AddContent(57, cartItems.Sum(item => item.Price * item.Quantity));

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\n            ");
            __builder.OpenElement(59, "div");
            __builder.AddAttribute(60, "style", "text-align: center; margin-top: 10px;");
            __builder.AddAttribute(61, "b-awyj8ajjqg");
            __builder.OpenElement(62, "button");
            __builder.AddAttribute(63, "class", "btn btn-primary btn-lg");
            __builder.AddAttribute(64, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 34 "C:\Users\king\Downloads\Compressed\BlazingShop-master\BlazingShop\Client\Pages\Cart.razor"
                                                                 PlaceOrder

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(65, "b-awyj8ajjqg");
            __builder.AddContent(66, "Place Order");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 37 "C:\Users\king\Downloads\Compressed\BlazingShop-master\BlazingShop\Client\Pages\Cart.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\Users\king\Downloads\Compressed\BlazingShop-master\BlazingShop\Client\Pages\Cart.razor"
     
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(67, "<h3 b-awyj8ajjqg>Thank you for your order!</h3>\n    ");
            __builder.AddMarkupContent(68, "<h4 b-awyj8ajjqg>Here\'s what you\'ll get:</h4>\n    ");
            __builder.OpenElement(69, "div");
            __builder.AddAttribute(70, "b-awyj8ajjqg");
#nullable restore
#line 44 "C:\Users\king\Downloads\Compressed\BlazingShop-master\BlazingShop\Client\Pages\Cart.razor"
         foreach (var item in cartItems)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(71, "div");
            __builder.AddAttribute(72, "class", "item-container");
            __builder.AddAttribute(73, "b-awyj8ajjqg");
            __builder.OpenElement(74, "div");
            __builder.AddAttribute(75, "class", "item-image-wrapper");
            __builder.AddAttribute(76, "b-awyj8ajjqg");
            __builder.OpenElement(77, "img");
            __builder.AddAttribute(78, "src", 
#nullable restore
#line 47 "C:\Users\king\Downloads\Compressed\BlazingShop-master\BlazingShop\Client\Pages\Cart.razor"
                                                           item.Image

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(79, "class", "item-image");
            __builder.AddAttribute(80, "b-awyj8ajjqg");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\n                ");
            __builder.OpenElement(82, "div");
            __builder.AddAttribute(83, "class", "item-name");
            __builder.AddAttribute(84, "b-awyj8ajjqg");
            __builder.OpenElement(85, "h5");
            __builder.AddAttribute(86, "b-awyj8ajjqg");
            __builder.OpenElement(87, "a");
            __builder.AddAttribute(88, "href", "/product/" + (
#nullable restore
#line 49 "C:\Users\king\Downloads\Compressed\BlazingShop-master\BlazingShop\Client\Pages\Cart.razor"
                                           item.ProductId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(89, "b-awyj8ajjqg");
#nullable restore
#line 49 "C:\Users\king\Downloads\Compressed\BlazingShop-master\BlazingShop\Client\Pages\Cart.razor"
__builder.AddContent(90, item.ProductTitle);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\n                    ");
            __builder.OpenElement(92, "span");
            __builder.AddAttribute(93, "b-awyj8ajjqg");
#nullable restore
#line 50 "C:\Users\king\Downloads\Compressed\BlazingShop-master\BlazingShop\Client\Pages\Cart.razor"
__builder.AddContent(94, item.EditionName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "<br b-awyj8ajjqg>");
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\n                ");
            __builder.OpenElement(97, "div");
            __builder.AddAttribute(98, "class", "item-price");
            __builder.AddAttribute(99, "b-awyj8ajjqg");
            __builder.AddContent(100, "$");
#nullable restore
#line 52 "C:\Users\king\Downloads\Compressed\BlazingShop-master\BlazingShop\Client\Pages\Cart.razor"
__builder.AddContent(101, item.Price * item.Quantity);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 54 "C:\Users\king\Downloads\Compressed\BlazingShop-master\BlazingShop\Client\Pages\Cart.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(102, "div");
            __builder.AddAttribute(103, "class", "item-price");
            __builder.AddAttribute(104, "b-awyj8ajjqg");
            __builder.AddMarkupContent(105, "\n            Total (");
#nullable restore
#line 56 "C:\Users\king\Downloads\Compressed\BlazingShop-master\BlazingShop\Client\Pages\Cart.razor"
__builder.AddContent(106, cartItems.Count);

#line default
#line hidden
#nullable disable
            __builder.AddContent(107, "): $");
#nullable restore
#line 56 "C:\Users\king\Downloads\Compressed\BlazingShop-master\BlazingShop\Client\Pages\Cart.razor"
__builder.AddContent(108, cartItems.Sum(item => item.Price * item.Quantity));

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 59 "C:\Users\king\Downloads\Compressed\BlazingShop-master\BlazingShop\Client\Pages\Cart.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 61 "C:\Users\king\Downloads\Compressed\BlazingShop-master\BlazingShop\Client\Pages\Cart.razor"
       
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
namespace __Blazor.BlazingShop.Client.Pages.Cart
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