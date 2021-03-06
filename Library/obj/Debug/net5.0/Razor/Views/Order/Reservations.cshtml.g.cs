#pragma checksum "F:\Bigger things\Library\Library\Library\Views\Order\Reservations.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3040d571411f9426333f780908ae5458425d06b5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Reservations), @"mvc.1.0.view", @"/Views/Order/Reservations.cshtml")]
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
#line 1 "F:\Bigger things\Library\Library\Library\Views\_ViewImports.cshtml"
using Library;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Bigger things\Library\Library\Library\Views\_ViewImports.cshtml"
using Library.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3040d571411f9426333f780908ae5458425d06b5", @"/Views/Order/Reservations.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dadb7a731bfbb305c411bc5eb7a307dbd6008a89", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Reservations : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Library.ViewModels.ReservationsVm>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Order", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AcceptReservation", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeclineReservation", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "F:\Bigger things\Library\Library\Library\Views\Order\Reservations.cshtml"
  
    ViewData["Title"] = "Reservations";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""container"">
    <div class=""row"">
        <div class=""col-xs-10"">
            <div class=""panel panel-primary"">
                <div class=""panel-heading"">
                    <h2 class=""panel-title"">
                        Reservations
                    </h2>
");
#nullable restore
#line 16 "F:\Bigger things\Library\Library\Library\Views\Order\Reservations.cshtml"
                     if (TempData["reservationDeletion"] != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p class=\"alert alert-info\">");
#nullable restore
#line 18 "F:\Bigger things\Library\Library\Library\Views\Order\Reservations.cshtml"
                                               Write(TempData["reservationDeletion"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 19 "F:\Bigger things\Library\Library\Library\Views\Order\Reservations.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "F:\Bigger things\Library\Library\Library\Views\Order\Reservations.cshtml"
                     if (TempData["noBookCopies"] != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p class=\"alert alert-info\">");
#nullable restore
#line 22 "F:\Bigger things\Library\Library\Library\Views\Order\Reservations.cshtml"
                                               Write(TempData["noBookCopies"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 23 "F:\Bigger things\Library\Library\Library\Views\Order\Reservations.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>

                <table class=""table table-hover"" style=""cursor:default"">
                    <thead>
                        <tr>
                            <th>Reservation ID</th>
                            <th>Customer Name</th>
                            <th>Customer ID</th>
                            <th>Book ISBN</th>
                            <th>Book Name</th>
                            <th>Book Author</th>
                            <th>Requested on</th>
                            <th>Accept</th>
                            <th>Decline</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 41 "F:\Bigger things\Library\Library\Library\Views\Order\Reservations.cshtml"
                         foreach (var res in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 44 "F:\Bigger things\Library\Library\Library\Views\Order\Reservations.cshtml"
                               Write(res.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 45 "F:\Bigger things\Library\Library\Library\Views\Order\Reservations.cshtml"
                               Write(res.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 46 "F:\Bigger things\Library\Library\Library\Views\Order\Reservations.cshtml"
                               Write(res.UserID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 47 "F:\Bigger things\Library\Library\Library\Views\Order\Reservations.cshtml"
                               Write(res.BookISBN);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 48 "F:\Bigger things\Library\Library\Library\Views\Order\Reservations.cshtml"
                               Write(res.BookName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 49 "F:\Bigger things\Library\Library\Library\Views\Order\Reservations.cshtml"
                               Write(res.BookAuthor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 50 "F:\Bigger things\Library\Library\Library\Views\Order\Reservations.cshtml"
                               Write(res.RequestedAt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3040d571411f9426333f780908ae5458425d06b59691", async() => {
                WriteLiteral("\r\n                                        <input type=\"Hidden\" name=\"id\"");
                BeginWriteAttribute("value", " value=\"", 2199, "\"", 2214, 1);
#nullable restore
#line 53 "F:\Bigger things\Library\Library\Library\Views\Order\Reservations.cshtml"
WriteAttributeValue("", 2207, res.ID, 2207, 7, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                        <input type=\"submit\" value=\"Accept\" class=\"btn btn-primary btn-outline-secondary\" />\r\n                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3040d571411f9426333f780908ae5458425d06b512141", async() => {
                WriteLiteral("\r\n                                        <input type=\"Hidden\" name=\"id\"");
                BeginWriteAttribute("value", " value=\"", 2650, "\"", 2665, 1);
#nullable restore
#line 59 "F:\Bigger things\Library\Library\Library\Views\Order\Reservations.cshtml"
WriteAttributeValue("", 2658, res.ID, 2658, 7, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                        <input type=\"submit\" value=\"Decline\" class=\"btn btn-primary btn-outline-secondary\" />\r\n                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 64 "F:\Bigger things\Library\Library\Library\Views\Order\Reservations.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Library.ViewModels.ReservationsVm>> Html { get; private set; }
    }
}
#pragma warning restore 1591
