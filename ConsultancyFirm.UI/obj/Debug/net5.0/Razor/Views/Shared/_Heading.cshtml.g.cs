#pragma checksum "C:\Users\recep\source\repos\ConsultancyFirm\ConsultancyFirm.UI\Views\Shared\_Heading.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f8d0140dafb9844f4a045ab8655c2caebad7ed00"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Heading), @"mvc.1.0.view", @"/Views/Shared/_Heading.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8d0140dafb9844f4a045ab8655c2caebad7ed00", @"/Views/Shared/_Heading.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54711e5a333ade32cc9c01ac96201239f9c0ffb1", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Heading : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Heading>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

    <div class=""blog-card"" style=""box-sizing: border-box;"">
        <div class=""meta"">
            <div class=""photo"" style=""background-image: url(https://storage.googleapis.com/chydlx/codepen/blog-cards/image-1.jpg)""></div>
            <ul class=""details "">
                <li class=""author""><a href=""#"">John Doe</a></li>
                <li class=""date"">Aug. 24, 2015</li>
                <li class=""tags"">
                    <ul>
                        <li><a href=""#"">Learn</a></li>
                        <li><a href=""#"">Code</a></li>
                        <li><a href=""#"">HTML</a></li>
                        <li><a href=""#"">CSS</a></li>
                    </ul>
                </li>
            </ul>
        </div>
        <div class=""description"">
            <h1>");
#nullable restore
#line 21 "C:\Users\recep\source\repos\ConsultancyFirm\ConsultancyFirm.UI\Views\Shared\_Heading.cshtml"
           Write(Model.HeadingName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n            <h2>Opening a door to the future</h2>\r\n            <p> ");
#nullable restore
#line 23 "C:\Users\recep\source\repos\ConsultancyFirm\ConsultancyFirm.UI\Views\Shared\_Heading.cshtml"
           Write(Model.HeadingContent);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p class=\"read-more\">\r\n                <a class=\"a-tagi\" href=\"#\">Read More</a>\r\n            </p>\r\n        </div>\r\n    </div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Heading> Html { get; private set; }
    }
}
#pragma warning restore 1591
