#pragma checksum "C:\Users\recep\OneDrive\Masaüstü\ConsultancyFirm\ConsultancyFirm.UI\Views\MemberService\MemberAppointment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ba67aabd4337a7e7c2158508a65146eddcb8682d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MemberService_MemberAppointment), @"mvc.1.0.view", @"/Views/MemberService/MemberAppointment.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba67aabd4337a7e7c2158508a65146eddcb8682d", @"/Views/MemberService/MemberAppointment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9987e781ecd7a30ac623ce2d0441271a0413840", @"/Views/_ViewImports.cshtml")]
    public class Views_MemberService_MemberAppointment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<MemberService>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "MemberService", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteAppointment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\recep\OneDrive\Masaüstü\ConsultancyFirm\ConsultancyFirm.UI\Views\MemberService\MemberAppointment.cshtml"
  
    ViewData["Title"] = "Authors Page";




#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-4\">\r\n        ");
#nullable restore
#line 15 "C:\Users\recep\OneDrive\Masaüstü\ConsultancyFirm\ConsultancyFirm.UI\Views\MemberService\MemberAppointment.cshtml"
   Write(await Component.InvokeAsync("MemberCard"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    </div>
    <div class=""col-md-7"">
        <h1 class=""display-4"">Randevular</h1><br />
        <table class=""table"">
            <thead>
                <tr>
                    <td>#</td>
                    <td>Hizmet Alınan Danışman Bilgileri</td>
                    <td>Randevu Zamanı</td>
                    <td>Randevu kategorisi</td>
                    <td>Randevu İptal Et</td>

                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 31 "C:\Users\recep\OneDrive\Masaüstü\ConsultancyFirm\ConsultancyFirm.UI\Views\MemberService\MemberAppointment.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>  ");
#nullable restore
#line 34 "C:\Users\recep\OneDrive\Masaüstü\ConsultancyFirm\ConsultancyFirm.UI\Views\MemberService\MemberAppointment.cshtml"
                     Write(item.MemberServiceId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                    <td>    ");
#nullable restore
#line 36 "C:\Users\recep\OneDrive\Masaüstü\ConsultancyFirm\ConsultancyFirm.UI\Views\MemberService\MemberAppointment.cshtml"
                       Write(item.Author.AuthorFullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>    ");
#nullable restore
#line 37 "C:\Users\recep\OneDrive\Masaüstü\ConsultancyFirm\ConsultancyFirm.UI\Views\MemberService\MemberAppointment.cshtml"
                       Write(item.Category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>      ");
#nullable restore
#line 38 "C:\Users\recep\OneDrive\Masaüstü\ConsultancyFirm\ConsultancyFirm.UI\Views\MemberService\MemberAppointment.cshtml"
                         Write(item.AppointmentTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ba67aabd4337a7e7c2158508a65146eddcb8682d8120", async() => {
                WriteLiteral("\r\n                            <input type=\"hidden\" name=\"MemberServiceId\"");
                BeginWriteAttribute("value", " value=\"", 1192, "\"", 1221, 1);
#nullable restore
#line 41 "C:\Users\recep\OneDrive\Masaüstü\ConsultancyFirm\ConsultancyFirm.UI\Views\MemberService\MemberAppointment.cshtml"
WriteAttributeValue("", 1200, item.MemberServiceId, 1200, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                            <input type=\"submit\" class=\"btn btn-danger\" value=\"Randevuyu İptal Et\" />\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 47 "C:\Users\recep\OneDrive\Masaüstü\ConsultancyFirm\ConsultancyFirm.UI\Views\MemberService\MemberAppointment.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<MemberService>> Html { get; private set; }
    }
}
#pragma warning restore 1591
