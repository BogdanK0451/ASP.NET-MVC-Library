#pragma checksum "F:\Bigger things\Library\Library\Library\Views\Order\Transactions.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a7efa0797f6ce2f90464c1cf1ea4df50ef19e5e5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Transactions), @"mvc.1.0.view", @"/Views/Order/Transactions.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7efa0797f6ce2f90464c1cf1ea4df50ef19e5e5", @"/Views/Order/Transactions.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dadb7a731bfbb305c411bc5eb7a307dbd6008a89", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Transactions : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Library.ViewModels.OrderVm>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Book", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Returned", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "F:\Bigger things\Library\Library\Library\Views\Order\Transactions.cshtml"
  
    ViewData["Title"] = "Transactions";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""container-md"">
    <div class=""row"">
        <div class=""col-xs-10"">
            <div class=""panel panel-primary"">
                <div class=""panel-heading"">
                    <h2 class=""panel-title"">
                        List of all transactions
                    </h2>
                </div>

                <table class=""table table-hover"" style=""cursor:default"">
                    <thead>
                        <tr>
                            <th>Order ID</th>
                            <th>Customer Name</th>
                            <th>Customer ID</th>
                            <th>Book ID</th>
                            <th class=""align-text-top"">Book ISBN</th>
                            <th>Book Name</th>
                            <th>Book Author</th>
                            <th>Requested On</th>
                            <th class=""align-text-top"">Return By</th>
                            <th>Returned On</th>
                          ");
            WriteLiteral("  <th class=\"align-text-top\">Status</th>\r\n                        </tr>\r\n                    </thead>\r\n                    <tbody>\r\n");
#nullable restore
#line 35 "F:\Bigger things\Library\Library\Library\Views\Order\Transactions.cshtml"
                         foreach (var order in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr valign=\"top\">\r\n                                <td>");
#nullable restore
#line 38 "F:\Bigger things\Library\Library\Library\Views\Order\Transactions.cshtml"
                               Write(order.Order.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 39 "F:\Bigger things\Library\Library\Library\Views\Order\Transactions.cshtml"
                               Write(order.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 40 "F:\Bigger things\Library\Library\Library\Views\Order\Transactions.cshtml"
                               Write(order.Order.UserID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 41 "F:\Bigger things\Library\Library\Library\Views\Order\Transactions.cshtml"
                               Write(order.Order.BookID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 42 "F:\Bigger things\Library\Library\Library\Views\Order\Transactions.cshtml"
                               Write(order.BookISBN);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 43 "F:\Bigger things\Library\Library\Library\Views\Order\Transactions.cshtml"
                               Write(order.BookName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 44 "F:\Bigger things\Library\Library\Library\Views\Order\Transactions.cshtml"
                               Write(order.BookAuthor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 45 "F:\Bigger things\Library\Library\Library\Views\Order\Transactions.cshtml"
                               Write(order.RequestedOn);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 46 "F:\Bigger things\Library\Library\Library\Views\Order\Transactions.cshtml"
                               Write(order.Order.ReturnBy);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 47 "F:\Bigger things\Library\Library\Library\Views\Order\Transactions.cshtml"
                               Write(order.Order.ReturnedOn);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 48 "F:\Bigger things\Library\Library\Library\Views\Order\Transactions.cshtml"
                               Write(order.Order.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 49 "F:\Bigger things\Library\Library\Library\Views\Order\Transactions.cshtml"
                                 if (order.Order.Status == "active")
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td>\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a7efa0797f6ce2f90464c1cf1ea4df50ef19e5e59493", async() => {
                WriteLiteral("\r\n                                            <input type=\"Hidden\" name=\"bookId\"");
                BeginWriteAttribute("value", " value=\"", 2382, "\"", 2409, 1);
#nullable restore
#line 53 "F:\Bigger things\Library\Library\Library\Views\Order\Transactions.cshtml"
WriteAttributeValue("", 2390, order.Order.BookID, 2390, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                            <input type=\"Hidden\" name=\"orderId\"");
                BeginWriteAttribute("value", " value=\"", 2494, "\"", 2517, 1);
#nullable restore
#line 54 "F:\Bigger things\Library\Library\Library\Views\Order\Transactions.cshtml"
WriteAttributeValue("", 2502, order.Order.ID, 2502, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                            <input type=\"submit\" value=\"Return\" class=\"btn btn-primary btn-outline-primary\" />\r\n                                        ");
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
            WriteLiteral("\r\n                                    </td>\r\n");
#nullable restore
#line 58 "F:\Bigger things\Library\Library\Library\Views\Order\Transactions.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </tr>\r\n");
#nullable restore
#line 60 "F:\Bigger things\Library\Library\Library\Views\Order\Transactions.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Library.ViewModels.OrderVm>> Html { get; private set; }
    }
}
#pragma warning restore 1591
