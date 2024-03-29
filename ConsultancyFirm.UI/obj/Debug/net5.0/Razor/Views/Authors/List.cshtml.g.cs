#pragma checksum "C:\Users\recep\OneDrive\Masaüstü\ConsultancyFirm\ConsultancyFirm.UI\Views\Authors\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "11ea6899c22cc71687041259da49455040b14560"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"11ea6899c22cc71687041259da49455040b14560", @"/Views/Authors/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9987e781ecd7a30ac623ce2d0441271a0413840", @"/Views/_ViewImports.cshtml")]
    public class Views_Authors_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AuthorListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\recep\OneDrive\Masaüstü\ConsultancyFirm\ConsultancyFirm.UI\Views\Authors\List.cshtml"
  
    ViewData["Title"] = "Authors Page";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-6\">\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 11 "C:\Users\recep\OneDrive\Masaüstü\ConsultancyFirm\ConsultancyFirm.UI\Views\Authors\List.cshtml"
             foreach (var author in Model.AuthorInfos)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-6\">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 401, "\"", 469, 4);
            WriteAttributeValue("", 408, "/authors?id=", 408, 12, true);
#nullable restore
#line 14 "C:\Users\recep\OneDrive\Masaüstü\ConsultancyFirm\ConsultancyFirm.UI\Views\Authors\List.cshtml"
WriteAttributeValue("", 420, author.AuthorId, 420, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 436, "&page=", 436, 6, true);
#nullable restore
#line 14 "C:\Users\recep\OneDrive\Masaüstü\ConsultancyFirm\ConsultancyFirm.UI\Views\Authors\List.cshtml"
WriteAttributeValue("", 442, Model.PageInfo.CurrentPage, 442, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <div class=\"cards-list\">\r\n\r\n                            <div class=\"carda \">\r\n                                <div class=\"card_image\"> <img");
            BeginWriteAttribute("src", " src=\"", 636, "\"", 655, 1);
#nullable restore
#line 18 "C:\Users\recep\OneDrive\Masaüstü\ConsultancyFirm\ConsultancyFirm.UI\Views\Authors\List.cshtml"
WriteAttributeValue("", 642, author.Image, 642, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /> </div>\r\n                                <div class=\"card_title title-white\">\r\n                                    <p style=\"background-color:black !important;\">");
#nullable restore
#line 20 "C:\Users\recep\OneDrive\Masaüstü\ConsultancyFirm\ConsultancyFirm.UI\Views\Authors\List.cshtml"
                                                                             Write(author.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                </div>\r\n                            </div>\r\n\r\n                        </div>\r\n                    </a>\r\n\r\n\r\n                </div>\r\n");
#nullable restore
#line 29 "C:\Users\recep\OneDrive\Masaüstü\ConsultancyFirm\ConsultancyFirm.UI\Views\Authors\List.cshtml"


            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n");
            WriteLiteral("\r\n\r\n    </div>\r\n    <div class=\"col-md-6 \">\r\n        <div class=\"text-center\">\r\n            <h1>Pisikolog bilgileri</h1>\r\n        </div>\r\n");
#nullable restore
#line 42 "C:\Users\recep\OneDrive\Masaüstü\ConsultancyFirm\ConsultancyFirm.UI\Views\Authors\List.cshtml"
         if (Model.SelectedAuthor != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h3>");
#nullable restore
#line 44 "C:\Users\recep\OneDrive\Masaüstü\ConsultancyFirm\ConsultancyFirm.UI\Views\Authors\List.cshtml"
           Write(Model.SelectedAuthor.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            <h5>Mail Adresi: ");
#nullable restore
#line 45 "C:\Users\recep\OneDrive\Masaüstü\ConsultancyFirm\ConsultancyFirm.UI\Views\Authors\List.cshtml"
                        Write(Model.SelectedAuthor.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n            <h5>Yazar Hakkında: ");
#nullable restore
#line 46 "C:\Users\recep\OneDrive\Masaüstü\ConsultancyFirm\ConsultancyFirm.UI\Views\Authors\List.cshtml"
                           Write(Model.SelectedAuthor.About);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n            <h5>YAZARIN YAZDIĞI YAZILAR EKLENİCEK</h5>\r\n");
#nullable restore
#line 48 "C:\Users\recep\OneDrive\Masaüstü\ConsultancyFirm\ConsultancyFirm.UI\Views\Authors\List.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"text-center\">\r\n                <P> DANIŞMANA AİT BİLGİLERİ GÖRMEK İÇİN YAZARI TIKLAYINIZ !!!</P>\r\n            </div>\r\n");
#nullable restore
#line 54 "C:\Users\recep\OneDrive\Masaüstü\ConsultancyFirm\ConsultancyFirm.UI\Views\Authors\List.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n\r\n</div>\r\n<nav class=\"d-flex justify-content-center\">\r\n    <ul class=\"pagination\">\r\n");
#nullable restore
#line 61 "C:\Users\recep\OneDrive\Masaüstü\ConsultancyFirm\ConsultancyFirm.UI\Views\Authors\List.cshtml"
         for (int i = 0; i < Model.PageInfo.TotalPages(); i++)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"page-item\" ");
#nullable restore
#line 63 "C:\Users\recep\OneDrive\Masaüstü\ConsultancyFirm\ConsultancyFirm.UI\Views\Authors\List.cshtml"
                              Write(Model.PageInfo.CurrentPage == i + 1 ? "active" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 1979, "\"", 2006, 2);
            WriteAttributeValue("", 1986, "/authors?page=", 1986, 14, true);
#nullable restore
#line 64 "C:\Users\recep\OneDrive\Masaüstü\ConsultancyFirm\ConsultancyFirm.UI\Views\Authors\List.cshtml"
WriteAttributeValue("", 2000, i+1, 2000, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"page-link\">");
#nullable restore
#line 64 "C:\Users\recep\OneDrive\Masaüstü\ConsultancyFirm\ConsultancyFirm.UI\Views\Authors\List.cshtml"
                                                             Write(i+1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n            </li>\r\n");
#nullable restore
#line 66 "C:\Users\recep\OneDrive\Masaüstü\ConsultancyFirm\ConsultancyFirm.UI\Views\Authors\List.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </ul>\r\n</nav>\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AuthorListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
