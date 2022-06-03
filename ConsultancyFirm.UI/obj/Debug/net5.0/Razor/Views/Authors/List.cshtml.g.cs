#pragma checksum "C:\Users\recep\OneDrive\Masaüstü\ConsultancyFirm\ConsultancyFirm.UI\Views\Authors\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0731a85a10af1eaba22f9186d4937ed194400782"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0731a85a10af1eaba22f9186d4937ed194400782", @"/Views/Authors/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db4aab4caa02fe1d901515e66f8b1dab031c0e3c", @"/Views/_ViewImports.cshtml")]
    public class Views_Authors_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AuthorListViewModel>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
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
             foreach (var author in Model.Authors)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-6\">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 397, "\"", 465, 4);
            WriteAttributeValue("", 404, "/authors?id=", 404, 12, true);
#nullable restore
#line 14 "C:\Users\recep\OneDrive\Masaüstü\ConsultancyFirm\ConsultancyFirm.UI\Views\Authors\List.cshtml"
WriteAttributeValue("", 416, author.AuthorId, 416, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 432, "&page=", 432, 6, true);
#nullable restore
#line 14 "C:\Users\recep\OneDrive\Masaüstü\ConsultancyFirm\ConsultancyFirm.UI\Views\Authors\List.cshtml"
WriteAttributeValue("", 438, Model.PageInfo.CurrentPage, 438, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <div class=\"cards-list\">\r\n\r\n                            <div class=\"carda \">\r\n                                <div class=\"card_image\"> ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0731a85a10af1eaba22f9186d4937ed1944007825619", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 638, "~/images/defaultAuthor/", 638, 23, true);
#nullable restore
#line 18 "C:\Users\recep\OneDrive\Masaüstü\ConsultancyFirm\ConsultancyFirm.UI\Views\Authors\List.cshtml"
AddHtmlAttributeValue("", 661, author.AuthorImages, 661, 20, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" </div>\r\n                                <div class=\"card_title title-white\">\r\n                                    <p style=\"background-color:black !important;\">");
#nullable restore
#line 20 "C:\Users\recep\OneDrive\Masaüstü\ConsultancyFirm\ConsultancyFirm.UI\Views\Authors\List.cshtml"
                                                                             Write(author.AuthorFullName);

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
           Write(Model.SelectedAuthor.AuthorFullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            <h5>Mail Adresi: ");
#nullable restore
#line 45 "C:\Users\recep\OneDrive\Masaüstü\ConsultancyFirm\ConsultancyFirm.UI\Views\Authors\List.cshtml"
                        Write(Model.SelectedAuthor.AuthorMail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n            <h5>Telefon Numarası: ");
#nullable restore
#line 46 "C:\Users\recep\OneDrive\Masaüstü\ConsultancyFirm\ConsultancyFirm.UI\Views\Authors\List.cshtml"
                             Write(Model.SelectedAuthor.AuthorPhone);

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
            BeginWriteAttribute("href", " href=\"", 2030, "\"", 2057, 2);
            WriteAttributeValue("", 2037, "/authors?page=", 2037, 14, true);
#nullable restore
#line 64 "C:\Users\recep\OneDrive\Masaüstü\ConsultancyFirm\ConsultancyFirm.UI\Views\Authors\List.cshtml"
WriteAttributeValue("", 2051, i+1, 2051, 6, false);

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
