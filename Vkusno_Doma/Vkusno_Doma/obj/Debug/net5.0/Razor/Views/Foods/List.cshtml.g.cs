#pragma checksum "D:\ASP.NET MVC C#\Vkusno_Doma\Vkusno_Doma\Views\Foods\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "748a27e4f6d64f273fd92d9bd0973c79eb31df3a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Foods_List), @"mvc.1.0.view", @"/Views/Foods/List.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"748a27e4f6d64f273fd92d9bd0973c79eb31df3a", @"/Views/Foods/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a6349edcfb092624a9cdb45a0f5745bea6314df", @"/Views/_ViewImports.cshtml")]
    public class Views_Foods_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>Наша продукция</h1>\r\n<!--<h3>");
#nullable restore
#line 3 "D:\ASP.NET MVC C#\Vkusno_Doma\Vkusno_Doma\Views\Foods\List.cshtml"
   Write(Model.currentCategory);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>-->\r\n\r\n<div class=\"row mt-5 mb-2\">\r\n\r\n");
#nullable restore
#line 7 "D:\ASP.NET MVC C#\Vkusno_Doma\Vkusno_Doma\Views\Foods\List.cshtml"
       foreach (Food food in Model.AllFood)
          

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\ASP.NET MVC C#\Vkusno_Doma\Vkusno_Doma\Views\Foods\List.cshtml"
     Write(Html.Partial("AllFoods", food));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
