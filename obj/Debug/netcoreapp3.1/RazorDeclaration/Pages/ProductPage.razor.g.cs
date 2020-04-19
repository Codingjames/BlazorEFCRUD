#pragma checksum "D:\BlazorDemo.server2_ClassReletionship\Pages\ProductPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9f064d0debdf2d112fcbe30206f6f4e623db202d"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#nullable restore
#line 2 "D:\BlazorDemo.server2_ClassReletionship\Pages\ProductPage.razor"
using BlazorDemo.server2.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/productMgr")]
    public partial class ProductPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 87 "D:\BlazorDemo.server2_ClassReletionship\Pages\ProductPage.razor"
      
    bool isLoaded ;
    string ProductCateName;
    List<CategoryModel> cateList = new List<CategoryModel>();
      
    async Task CategoriesListAsync(){
       cateList = await db.Categories.ToListAsync();
    }
    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
      if(firstRender)
      {
        await CategoriesListAsync();
        isLoaded = true;
        logger.LogInformation($"Categories successed");

        StateHasChanged();

      }
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 107 "D:\BlazorDemo.server2_ClassReletionship\Pages\ProductPage.razor"
                                
    async void createProductCate()
    {
        isLoaded = false;
      
        var cate = new CategoryModel{
            CateName = ProductCateName,
            CreatedDate = DateTime.UtcNow
        };

        await db.AddAsync(cate);
        await db.SaveChangesAsync();
        await CategoriesListAsync();

        isLoaded = true;
        

        

#line default
#line hidden
#nullable disable
#nullable restore
#line 124 "D:\BlazorDemo.server2_ClassReletionship\Pages\ProductPage.razor"
                                   
        logger.LogInformation("Categories create successed.");
        StateHasChanged();
  
    }

    async Task CategoriesDeleteAsync(int id,string catenName)
    {
      bool confirm = await JsRuntime.InvokeAsync<bool>("confirm", "You will deleting {catenName}. Are you sure?");
      if(confirm)
      {
         isLoaded = false ;
        StateHasChanged();

        var category = await db.Categories.FindAsync(id);

        db.Remove(category);
        await db.SaveChangesAsync();
        logger.LogInformation("Categories deleted successed.");

        await CategoriesListAsync();
        isLoaded = true;
        StateHasChanged();
      }
     


    }
  
//End Code

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IModalService Modal { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILogger<ProductPage> logger { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AppDbContext db { get; set; }
    }
}
#pragma warning restore 1591
