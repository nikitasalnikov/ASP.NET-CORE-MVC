#pragma checksum "D:\ASP.NET MVC C#\Vkusno_Doma\Vkusno_Doma\Views\FoodCart\FoodCartIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3765837bfcbd92cc96484869cfdc8f7fd0c8a2a6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_FoodCart_FoodCartIndex), @"mvc.1.0.view", @"/Views/FoodCart/FoodCartIndex.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\ASP.NET MVC C#\Vkusno_Doma\Vkusno_Doma\Views\_ViewImports.cshtml"
using Vkusno_Doma.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\ASP.NET MVC C#\Vkusno_Doma\Vkusno_Doma\Views\_ViewImports.cshtml"
using Vkusno_Doma.Data.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3765837bfcbd92cc96484869cfdc8f7fd0c8a2a6", @"/Views/FoodCart/FoodCartIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a6349edcfb092624a9cdb45a0f5745bea6314df", @"/Views/_ViewImports.cshtml")]
    public class Views_FoodCart_FoodCartIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FoodCartViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"container\">\r\n");
#nullable restore
#line 4 "D:\ASP.NET MVC C#\Vkusno_Doma\Vkusno_Doma\Views\FoodCart\FoodCartIndex.cshtml"
     foreach (var element in Model.foodCart.listFoodItem)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"alert alert-warning mt-3\">\r\n                    <b>Товар:</b>");
#nullable restore
#line 7 "D:\ASP.NET MVC C#\Vkusno_Doma\Vkusno_Doma\Views\FoodCart\FoodCartIndex.cshtml"
                            Write(element.food.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n                    <b>Цена:</b>");
#nullable restore
#line 8 "D:\ASP.NET MVC C#\Vkusno_Doma\Vkusno_Doma\Views\FoodCart\FoodCartIndex.cshtml"
                           Write(element.food.Price.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n                </div>\r\n");
#nullable restore
#line 12 "D:\ASP.NET MVC C#\Vkusno_Doma\Vkusno_Doma\Views\FoodCart\FoodCartIndex.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <hr />\r\n    <div class=\"btn btn-danger\" asp-controller=\"Order\">Оплатить</div>\r\n\r\n\r\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FoodCartViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591