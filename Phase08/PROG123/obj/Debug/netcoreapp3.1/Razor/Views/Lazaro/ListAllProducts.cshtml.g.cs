#pragma checksum "C:\Users\Marcus\Documents\GitHub\lazarom37_PROG123\Phase08\PROG123\Views\Lazaro\ListAllProducts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ca4868dbc9e0bbf6ef210b120ecc484da53e4874"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Lazaro_ListAllProducts), @"mvc.1.0.view", @"/Views/Lazaro/ListAllProducts.cshtml")]
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
#line 1 "C:\Users\Marcus\Documents\GitHub\lazarom37_PROG123\Phase08\PROG123\Views\_ViewImports.cshtml"
using PROG123;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Marcus\Documents\GitHub\lazarom37_PROG123\Phase08\PROG123\Views\_ViewImports.cshtml"
using PROG123.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca4868dbc9e0bbf6ef210b120ecc484da53e4874", @"/Views/Lazaro/ListAllProducts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b44210dcadf1d9e0ad4e7680409e555499df7622", @"/Views/_ViewImports.cshtml")]
    public class Views_Lazaro_ListAllProducts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LinkedList<PROG123.Models.ProductModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Marcus\Documents\GitHub\lazarom37_PROG123\Phase08\PROG123\Views\Lazaro\ListAllProducts.cshtml"
  
    ViewData["Title"] = "ListAllProducts";
    Layout = "~/Views/Shared/_LazaroLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("<h1>ListAllProducts</h1>\r\n\r\n");
#nullable restore
#line 10 "C:\Users\Marcus\Documents\GitHub\lazarom37_PROG123\Phase08\PROG123\Views\Lazaro\ListAllProducts.cshtml"
 foreach (PROG123.Models.ProductModel productModel in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"inputwrap\">\r\n    <label>");
#nullable restore
#line 13 "C:\Users\Marcus\Documents\GitHub\lazarom37_PROG123\Phase08\PROG123\Views\Lazaro\ListAllProducts.cshtml"
      Write(productModel.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" || </label>\r\n    <label style=\"width:120px;\">");
#nullable restore
#line 14 "C:\Users\Marcus\Documents\GitHub\lazarom37_PROG123\Phase08\PROG123\Views\Lazaro\ListAllProducts.cshtml"
                           Write(productModel.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(" || </label>\r\n    <label>Price: ");
#nullable restore
#line 15 "C:\Users\Marcus\Documents\GitHub\lazarom37_PROG123\Phase08\PROG123\Views\Lazaro\ListAllProducts.cshtml"
             Write(productModel.Price.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" || </label>\r\n    <label>Available: ");
#nullable restore
#line 16 "C:\Users\Marcus\Documents\GitHub\lazarom37_PROG123\Phase08\PROG123\Views\Lazaro\ListAllProducts.cshtml"
                 Write(productModel.InventoryAmount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" || </label>\r\n    <label>PID: ");
#nullable restore
#line 17 "C:\Users\Marcus\Documents\GitHub\lazarom37_PROG123\Phase08\PROG123\Views\Lazaro\ListAllProducts.cshtml"
           Write(productModel.PID);

#line default
#line hidden
#nullable disable
            WriteLiteral(" || </label>\r\n\r\n    <a");
            BeginWriteAttribute("href", " href=\"", 573, "\"", 643, 1);
#nullable restore
#line 19 "C:\Users\Marcus\Documents\GitHub\lazarom37_PROG123\Phase08\PROG123\Views\Lazaro\ListAllProducts.cshtml"
WriteAttributeValue("", 580, Url.Action("OneClickBuy","Lazaro", new {PID=productModel.PID}), 580, 63, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Buy One Instantly</a>\r\n</div>\r\n");
#nullable restore
#line 21 "C:\Users\Marcus\Documents\GitHub\lazarom37_PROG123\Phase08\PROG123\Views\Lazaro\ListAllProducts.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LinkedList<PROG123.Models.ProductModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
