#pragma checksum "C:\Users\recep\source\repos\ConsultancyFirm\ConsultancyFirm.UI\Views\Authors\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0db0be41f960e48be5fcf097d8eeafaec8bc679c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Authors_List), @"mvc.1.0.view", @"/Views/Authors/List.cshtml")]
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
#line 1 "C:\Users\recep\source\repos\ConsultancyFirm\ConsultancyFirm.UI\Views\_ViewImports.cshtml"
using ConsultancyFirm.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\recep\source\repos\ConsultancyFirm\ConsultancyFirm.UI\Views\_ViewImports.cshtml"
using ConsultancyFirm.UI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\recep\source\repos\ConsultancyFirm\ConsultancyFirm.UI\Views\_ViewImports.cshtml"
using ConsultancyFirm.EL;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0db0be41f960e48be5fcf097d8eeafaec8bc679c", @"/Views/Authors/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54711e5a333ade32cc9c01ac96201239f9c0ffb1", @"/Views/_ViewImports.cshtml")]
    public class Views_Authors_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Heading>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\recep\source\repos\ConsultancyFirm\ConsultancyFirm.UI\Views\Authors\List.cshtml"
  
    ViewData["Title"] = "Authors Page";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-6\">\r\n        <div class=\"row\">\r\n            ");
#nullable restore
#line 10 "C:\Users\recep\source\repos\ConsultancyFirm\ConsultancyFirm.UI\Views\Authors\List.cshtml"
       Write(await Component.InvokeAsync("Authors"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

        </div>
      
    </div>
    <div class=""col-md-6 "" >
        <div style="" position:fixed;padding-right:inherit; top:20%; right:0%;height:500px;"">
          
                <h1>Pisikolog bilgileri</h1>
           
            
        </div>
       
    </div>
</div>




");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Heading>> Html { get; private set; }
    }
}
#pragma warning restore 1591
