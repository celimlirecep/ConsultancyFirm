#pragma checksum "C:\Users\recep\OneDrive\Masaüstü\ConsultancyFirm\ConsultancyFirm.UI\Views\Account\MemberPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c5d87e5a36168dc0ad3ea9449d59403a5537cdb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_MemberPage), @"mvc.1.0.view", @"/Views/Account/MemberPage.cshtml")]
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
#line 1 "C:\Users\recep\OneDrive\Masaüstü\ConsultancyFirm\ConsultancyFirm.UI\Views\_ViewImports.cshtml"
using ConsultancyFirm.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\recep\OneDrive\Masaüstü\ConsultancyFirm\ConsultancyFirm.UI\Views\_ViewImports.cshtml"
using ConsultancyFirm.UI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\recep\OneDrive\Masaüstü\ConsultancyFirm\ConsultancyFirm.UI\Views\_ViewImports.cshtml"
using ConsultancyFirm.EL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\recep\OneDrive\Masaüstü\ConsultancyFirm\ConsultancyFirm.UI\Views\_ViewImports.cshtml"
using ConsultancyFirm.UI.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\recep\OneDrive\Masaüstü\ConsultancyFirm\ConsultancyFirm.UI\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\recep\OneDrive\Masaüstü\ConsultancyFirm\ConsultancyFirm.UI\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\recep\OneDrive\Masaüstü\ConsultancyFirm\ConsultancyFirm.UI\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c5d87e5a36168dc0ad3ea9449d59403a5537cdb", @"/Views/Account/MemberPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9987e781ecd7a30ac623ce2d0441271a0413840", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_MemberPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\recep\OneDrive\Masaüstü\ConsultancyFirm\ConsultancyFirm.UI\Views\Account\MemberPage.cshtml"
  
    ViewData["Title"] = "Authors Page";

    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-4\">\r\n        ");
#nullable restore
#line 10 "C:\Users\recep\OneDrive\Masaüstü\ConsultancyFirm\ConsultancyFirm.UI\Views\Account\MemberPage.cshtml"
   Write(await Component.InvokeAsync("MemberCard"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"col-md-6\">\r\n\r\n\r\n\r\n        <section>\r\n            <div class=\"row\">\r\n                <br />\r\n                <div class=\"col-md-12\">\r\n                    <h5 class=\"display-4 text-center\">Sayın ");
#nullable restore
#line 20 "C:\Users\recep\OneDrive\Masaüstü\ConsultancyFirm\ConsultancyFirm.UI\Views\Account\MemberPage.cshtml"
                                                       Write(Model.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                </div>\r\n\r\n\r\n                <hr />\r\n               \r\n\r\n            </div>\r\n        </section>\r\n\r\n\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<User> Html { get; private set; }
    }
}
#pragma warning restore 1591
