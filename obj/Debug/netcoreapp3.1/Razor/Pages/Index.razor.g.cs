#pragma checksum "D:\BlazorDemo.server2_ClassReletionship\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "64d032ec697c1f9a22fcdb1e47b61a537f057024"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorDemo.server2.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\BlazorDemo.server2_ClassReletionship\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\BlazorDemo.server2_ClassReletionship\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\BlazorDemo.server2_ClassReletionship\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\BlazorDemo.server2_ClassReletionship\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\BlazorDemo.server2_ClassReletionship\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\BlazorDemo.server2_ClassReletionship\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\BlazorDemo.server2_ClassReletionship\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\BlazorDemo.server2_ClassReletionship\_Imports.razor"
using BlazorDemo.server2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\BlazorDemo.server2_ClassReletionship\_Imports.razor"
using BlazorDemo.server2.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\BlazorDemo.server2_ClassReletionship\_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\BlazorDemo.server2_ClassReletionship\_Imports.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\BlazorDemo.server2_ClassReletionship\_Imports.razor"
using BlazorDemo.server2.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\BlazorDemo.server2_ClassReletionship\_Imports.razor"
using Microsoft.Extensions.Logging;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\BlazorDemo.server2_ClassReletionship\_Imports.razor"
using Blazored;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\BlazorDemo.server2_ClassReletionship\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "D:\BlazorDemo.server2_ClassReletionship\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(2, "\r\n       \r\n        \r\n  \r\n");
                __builder2.AddMarkupContent(3, "<h1> You\'re authorized.</h1>\r\n\r\nWelcome to your new app. ");
                __builder2.OpenElement(4, "p");
                __builder2.AddContent(5, "click = ");
                __builder2.AddContent(6, 
#nullable restore
#line 12 "D:\BlazorDemo.server2_ClassReletionship\Pages\Index.razor"
                                      count

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(7, " ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(8, "      \r\n");
                __builder2.OpenElement(9, "button");
                __builder2.AddAttribute(10, "class", "btn btn-primary");
                __builder2.AddAttribute(11, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "D:\BlazorDemo.server2_ClassReletionship\Pages\Index.razor"
                                          Increment

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(12, "click ++");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(13, "<br>\r\n");
                __builder2.OpenElement(14, "button");
                __builder2.AddAttribute(15, "class", "btn btn-danger");
                __builder2.AddAttribute(16, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 14 "D:\BlazorDemo.server2_ClassReletionship\Pages\Index.razor"
                                         Decrement

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(17, "click--");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(18, "\r\n\r\n\r\n\r\n\r\n\r\n    ");
            }
            ));
            __builder.AddAttribute(19, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(20, "\r\n        ");
                __builder2.AddMarkupContent(21, "<h1>You aren\'t authorized.</h1>    \r\n");
                __builder2.OpenElement(22, "div");
                __builder2.AddAttribute(23, "class", "col-sm-12");
                __builder2.AddMarkupContent(24, "\r\n    ");
                __builder2.OpenElement(25, "div");
                __builder2.AddAttribute(26, "class", "col-sm-6");
                __builder2.AddMarkupContent(27, "\r\n        ");
                __builder2.OpenElement(28, "form");
                __builder2.AddAttribute(29, "method", "get");
                __builder2.AddAttribute(30, "action", "Login");
                __builder2.AddMarkupContent(31, "\r\n            ");
                __builder2.OpenElement(32, "div");
                __builder2.AddAttribute(33, "class", "form-group");
                __builder2.AddMarkupContent(34, "\r\n                ");
                __builder2.AddMarkupContent(35, "<label for=\"usn\">Username</label>\r\n                ");
                __builder2.OpenElement(36, "input");
                __builder2.AddAttribute(37, "type", "text");
                __builder2.AddAttribute(38, "class", "form-control");
                __builder2.AddAttribute(39, "id", "usn");
                __builder2.AddAttribute(40, "name", "username");
                __builder2.AddAttribute(41, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 37 "D:\BlazorDemo.server2_ClassReletionship\Pages\Index.razor"
                                                                         username

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(42, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => username = __value, username));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(43, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(44, "\r\n            ");
                __builder2.OpenElement(45, "div");
                __builder2.AddAttribute(46, "class", "form-group");
                __builder2.AddMarkupContent(47, "\r\n                ");
                __builder2.AddMarkupContent(48, "<label for=\"exampleInputPassword1\">Password</label>\r\n                ");
                __builder2.OpenElement(49, "input");
                __builder2.AddAttribute(50, "type", "password");
                __builder2.AddAttribute(51, "class", "form-control");
                __builder2.AddAttribute(52, "id", "exampleInputPassword1");
                __builder2.AddAttribute(53, "name", "password");
                __builder2.AddAttribute(54, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 41 "D:\BlazorDemo.server2_ClassReletionship\Pages\Index.razor"
                                                                                              password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(55, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => password = __value, password));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(56, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(57, "\r\n          \r\n            ");
                __builder2.OpenElement(58, "button");
                __builder2.AddAttribute(59, "type", "submit");
                __builder2.AddAttribute(60, "class", "btn btn-primary");
                __builder2.AddAttribute(61, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 44 "D:\BlazorDemo.server2_ClassReletionship\Pages\Index.razor"
                                                                    Login

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(62, "Login");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(63, "\r\n            ");
                __builder2.OpenElement(64, "button");
                __builder2.AddAttribute(65, "type", "submit");
                __builder2.AddAttribute(66, "class", "btn btn-primary");
                __builder2.AddAttribute(67, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 45 "D:\BlazorDemo.server2_ClassReletionship\Pages\Index.razor"
                                                                    Register

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(68, "Register");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(69, "\r\n           \r\n                ");
                __builder2.OpenElement(70, "div");
                __builder2.AddAttribute(71, "class", "form-group");
                __builder2.AddMarkupContent(72, "\r\n                    ");
                __builder2.OpenElement(73, "p");
                __builder2.AddContent(74, " Status : ");
                __builder2.AddContent(75, 
#nullable restore
#line 48 "D:\BlazorDemo.server2_ClassReletionship\Pages\Index.razor"
                                   msgSt

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(76, " ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(77, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(78, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(79, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(80, "\r\n");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(81, "        \r\n\r\n       \r\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 17 "D:\BlazorDemo.server2_ClassReletionship\Pages\Index.razor"
      
    int count = 0;
    void Increment(){
        count++;
    }
    void Decrement(){
        count--;
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "D:\BlazorDemo.server2_ClassReletionship\Pages\Index.razor"
      
    string msgSt;
    string username;
    string password;

     async void Register(){

        var user = new AppUser{UserName = username};
        var result = await userManager.CreateAsync(user,password);

        if(result.Succeeded)
        {
            logger.LogInformation("Register Successed");
        } 
        else
        {

            msgSt = result.ToString();
            logger.LogError("Register failed"+result.ToString());
            
        } 
        this.StateHasChanged();
        
    }
    void Login(){

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILogger<Index> logger { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserManager<AppUser> userManager { get; set; }
    }
}
#pragma warning restore 1591
