#pragma checksum "C:\Users\king\Downloads\Compressed\BlazingShop-master\BlazingShop\Client\Pages\AdminPages\Admin.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b3e96cc3d60cb1fa0a8756c658e242773aefc292"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazingShop.Client.Pages.AdminPages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin")]
    public partial class Admin : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Roles", "Administrator");
            __builder.AddAttribute(2, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(3, "<h1>You are not allowed in admin page</h1>");
            }
            ));
            __builder.AddAttribute(4, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(5, "h1");
                __builder2.AddContent(6, "Welcome back, ");
#nullable restore
#line 8 "C:\Users\king\Downloads\Compressed\BlazingShop-master\BlazingShop\Client\Pages\AdminPages\Admin.razor"
__builder2.AddContent(7, context.User.Identity.Name);

#line default
#line hidden
#nullable disable
                __builder2.AddContent(8, "!");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591