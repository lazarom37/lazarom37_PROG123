#pragma checksum "C:\Users\Marcus\Documents\GitHub\lazarom37_PROG123\Phase08\PROG123\Views\Lazaro\OneClickBuy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7103e71a2e2a96bf8dd87ce810a86e7d10433d36"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Lazaro_OneClickBuy), @"mvc.1.0.view", @"/Views/Lazaro/OneClickBuy.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7103e71a2e2a96bf8dd87ce810a86e7d10433d36", @"/Views/Lazaro/OneClickBuy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b44210dcadf1d9e0ad4e7680409e555499df7622", @"/Views/_ViewImports.cshtml")]
    public class Views_Lazaro_OneClickBuy : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PROG123.Models.PurchaseModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Marcus\Documents\GitHub\lazarom37_PROG123\Phase08\PROG123\Views\Lazaro\OneClickBuy.cshtml"
  
    ViewData["Title"] = "OneClickBuy";
    Layout = "~/Views/Shared/_LazaroLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("<h1>OneClickBuy</h1>\r\n\r\n<div>\r\n    Hi ");
#nullable restore
#line 10 "C:\Users\Marcus\Documents\GitHub\lazarom37_PROG123\Phase08\PROG123\Views\Lazaro\OneClickBuy.cshtml"
  Write(Model.PersonModel.FName);

#line default
#line hidden
#nullable disable
            WriteLiteral(",\r\n    <br />\r\n    Thanks for buying the ");
#nullable restore
#line 12 "C:\Users\Marcus\Documents\GitHub\lazarom37_PROG123\Phase08\PROG123\Views\Lazaro\OneClickBuy.cshtml"
                     Write(Model.ProductModel.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" .\r\n    Your credit card will be charged ");
#nullable restore
#line 13 "C:\Users\Marcus\Documents\GitHub\lazarom37_PROG123\Phase08\PROG123\Views\Lazaro\OneClickBuy.cshtml"
                                Write(Model.ProductModel.Price.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" and shipped to ");
#nullable restore
#line 13 "C:\Users\Marcus\Documents\GitHub\lazarom37_PROG123\Phase08\PROG123\Views\Lazaro\OneClickBuy.cshtml"
                                                                                       Write(Model.PersonModel.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <br />\r\n    Please come again :o)\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PROG123.Models.PurchaseModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
