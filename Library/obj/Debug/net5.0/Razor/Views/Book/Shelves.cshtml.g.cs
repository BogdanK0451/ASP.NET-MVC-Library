#pragma checksum "F:\Bigger things\Library\Library\Library\Views\Book\Shelves.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c0c834a850ba7a85f74808461d90f398183733a8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_Shelves), @"mvc.1.0.view", @"/Views/Book/Shelves.cshtml")]
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
#nullable restore
#line 2 "F:\Bigger things\Library\Library\Library\Views\Book\Shelves.cshtml"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\Bigger things\Library\Library\Library\Views\Book\Shelves.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0c834a850ba7a85f74808461d90f398183733a8", @"/Views/Book/Shelves.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dadb7a731bfbb305c411bc5eb7a307dbd6008a89", @"/Views/_ViewImports.cshtml")]
    public class Views_Book_Shelves : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Library.ViewModels.BooksAndReservations>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "Hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("dateTime"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Order", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateReservation", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 6 "F:\Bigger things\Library\Library\Library\Views\Book\Shelves.cshtml"
  
    ViewData["Title"] = "Bookshelf";
    bool canReserve = true;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 11 "F:\Bigger things\Library\Library\Library\Views\Book\Shelves.cshtml"
   int j = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 14 "F:\Bigger things\Library\Library\Library\Views\Book\Shelves.cshtml"
 foreach (var book in Model.Books)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div");
            BeginWriteAttribute("id", " id=\"", 421, "\"", 434, 2);
            WriteAttributeValue("", 426, "modal_", 426, 6, true);
#nullable restore
#line 16 "F:\Bigger things\Library\Library\Library\Views\Book\Shelves.cshtml"
WriteAttributeValue("", 432, j, 432, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"modal\">\r\n        <div class=\"modal-content\">\r\n            <h5>");
#nullable restore
#line 18 "F:\Bigger things\Library\Library\Library\Views\Book\Shelves.cshtml"
           Write(book.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n            <p>");
#nullable restore
#line 19 "F:\Bigger things\Library\Library\Library\Views\Book\Shelves.cshtml"
          Write(book.Summary);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 22 "F:\Bigger things\Library\Library\Library\Views\Book\Shelves.cshtml"
    j++;
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section class=\"py-5 text-center container\">\r\n    <h1 class=\"fw-light\">Available</h1>\r\n");
#nullable restore
#line 27 "F:\Bigger things\Library\Library\Library\Views\Book\Shelves.cshtml"
     if (TempData["reservationProcessed"] != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p class=\"alert alert-info\">");
#nullable restore
#line 29 "F:\Bigger things\Library\Library\Library\Views\Book\Shelves.cshtml"
                               Write(TempData["reservationProcessed"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 30 "F:\Bigger things\Library\Library\Library\Views\Book\Shelves.cshtml"
    }
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "F:\Bigger things\Library\Library\Library\Views\Book\Shelves.cshtml"
     if (Model.ReservedBooksByUser >= 5)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p class=\"alert alert-danger\">You\'ve borrowed too many books, you should return some before trying to reserve more</p>\r\n");
#nullable restore
#line 35 "F:\Bigger things\Library\Library\Library\Views\Book\Shelves.cshtml"
        canReserve = false;
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</section>\r\n<div class=\"album py-5 bg-light\">\r\n    <div class=\"container\">\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 59 "F:\Bigger things\Library\Library\Library\Views\Book\Shelves.cshtml"
          
            int i = 0;
            List<string> shownISBNs = new List<string>();
            Dictionary<string, int> unusedBooksCount = countHelper(Model.Books);
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 64 "F:\Bigger things\Library\Library\Library\Views\Book\Shelves.cshtml"
         foreach (var book in Model.Books)
        {

            //check if book was already shown
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 68 "F:\Bigger things\Library\Library\Library\Views\Book\Shelves.cshtml"
             if (!shownISBNs.Contains(book.Isbn))
            {
                string author;
                string yearWritten;
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 72 "F:\Bigger things\Library\Library\Library\Views\Book\Shelves.cshtml"
                 if (String.IsNullOrEmpty(book.Author))
                    author = "N/A";
                else
                    author = book.Author;

#line default
#line hidden
#nullable disable
#nullable restore
#line 75 "F:\Bigger things\Library\Library\Library\Views\Book\Shelves.cshtml"
                                         
                //incase YearWritten is null (this field in database is nullable) print N/A
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 77 "F:\Bigger things\Library\Library\Library\Views\Book\Shelves.cshtml"
                 if (book.YearWritten.HasValue)
                    yearWritten = book.YearWritten.Value.Year.ToString();
                else
                    yearWritten = "N/A";

#line default
#line hidden
#nullable disable
#nullable restore
#line 81 "F:\Bigger things\Library\Library\Library\Views\Book\Shelves.cshtml"
                 if (i % 3 == 0)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 83 "F:\Bigger things\Library\Library\Library\Views\Book\Shelves.cshtml"
               Write(Html.Raw("<div class=\"row row-eq-height\">"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 83 "F:\Bigger things\Library\Library\Library\Views\Book\Shelves.cshtml"
                                                                  
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 84 "F:\Bigger things\Library\Library\Library\Views\Book\Shelves.cshtml"
                 
                string available = unusedBooksCount[book.Isbn] > 0 ? "Yes" : "No";


#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-4\">\r\n                    <div class=\"card shadow-sm\">\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 91 "F:\Bigger things\Library\Library\Library\Views\Book\Shelves.cshtml"
                         if (File.Exists(Directory.GetCurrentDirectory() + "/wwwroot" + book.ImageUrl))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <img style=\"object-fit:contain;height:300px;width:100%\"");
            BeginWriteAttribute("src", " src=\"", 3440, "\"", 3473, 1);
#nullable restore
#line 93 "F:\Bigger things\Library\Library\Library\Views\Book\Shelves.cshtml"
WriteAttributeValue("", 3446, Url.Content(book.ImageUrl), 3446, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 94 "F:\Bigger things\Library\Library\Library\Views\Book\Shelves.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <img style=\"object-fit:contain;height:300px;width:100%\"");
            BeginWriteAttribute("src", " src=\"", 3646, "\"", 3693, 1);
#nullable restore
#line 97 "F:\Bigger things\Library\Library\Library\Views\Book\Shelves.cshtml"
WriteAttributeValue("", 3652, Url.Content("/images/default-image.jpg"), 3652, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 98 "F:\Bigger things\Library\Library\Library\Views\Book\Shelves.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <div class=\"card-body\">\r\n                            <p class=\"card-text\" style=\"height:50px; overflow:auto;\"><b>");
#nullable restore
#line 101 "F:\Bigger things\Library\Library\Library\Views\Book\Shelves.cshtml"
                                                                                    Write(book.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b> by <b>");
#nullable restore
#line 101 "F:\Bigger things\Library\Library\Library\Views\Book\Shelves.cshtml"
                                                                                                            Write(author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>, Genres: ");
#nullable restore
#line 101 "F:\Bigger things\Library\Library\Library\Views\Book\Shelves.cshtml"
                                                                                                                                   Write(book.Genre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <div class=\"d-flex justify-content-between align-books-center\">\r\n                                <div class=\"btn-group\">\r\n");
#nullable restore
#line 105 "F:\Bigger things\Library\Library\Library\Views\Book\Shelves.cshtml"
                                       if (unusedBooksCount[book.Isbn] > 0 && !String.IsNullOrEmpty(HttpContextAccessor.HttpContext.Session.GetString("id")) && canReserve)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c0c834a850ba7a85f74808461d90f398183733a814953", async() => {
                WriteLiteral("\r\n                                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c0c834a850ba7a85f74808461d90f398183733a815260", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 108 "F:\Bigger things\Library\Library\Library\Views\Book\Shelves.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Reservation.BookID);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 108 "F:\Bigger things\Library\Library\Library\Views\Book\Shelves.cshtml"
                                                                                             WriteLiteral(book.ID);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c0c834a850ba7a85f74808461d90f398183733a817732", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 109 "F:\Bigger things\Library\Library\Library\Views\Book\Shelves.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Reservation.UserID);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 109 "F:\Bigger things\Library\Library\Library\Views\Book\Shelves.cshtml"
                                                                                             WriteLiteral(HttpContextAccessor.HttpContext.Session.GetString("id"));

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c0c834a850ba7a85f74808461d90f398183733a820252", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 110 "F:\Bigger things\Library\Library\Library\Views\Book\Shelves.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Reservation.RequestedAt);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                                <input type=\"submit\" value=\"Reserve\" class=\"btn btn-primary btn-outline-secondary\" />\r\n                                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 113 "F:\Bigger things\Library\Library\Library\Views\Book\Shelves.cshtml"
                                        }
                                        else
                                        {
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("<button type=\"button\" data-toggle=\"tooltip\" data-placement=\"top\" title=\"Sorry, you can\'t reserve the book right now\" disabled class=\"btn btn-primary btn-outline-primary\">Reserve</button>");
#nullable restore
#line 116 "F:\Bigger things\Library\Library\Library\Views\Book\Shelves.cshtml"
                                                                                                                                                                                                                                       }
                                        }
                                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <button type=\"button\"");
            BeginWriteAttribute("id", " id=\"", 5609, "\"", 5624, 2);
            WriteAttributeValue("", 5614, "summary_", 5614, 8, true);
#nullable restore
#line 119 "F:\Bigger things\Library\Library\Library\Views\Book\Shelves.cshtml"
WriteAttributeValue("", 5622, i, 5622, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-sm btn-outline-primary summary\">Summary</button>\r\n                                </div>\r\n\r\n                                <small class=\"text-muted font-weight-bold\">\r\n");
#nullable restore
#line 124 "F:\Bigger things\Library\Library\Library\Views\Book\Shelves.cshtml"
                                     if (unusedBooksCount[book.Isbn] > 0)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<span style=\"color:green;display:block\">Available: ");
#nullable restore
#line 125 "F:\Bigger things\Library\Library\Library\Views\Book\Shelves.cshtml"
                                                                                    Write(available);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>");
#nullable restore
#line 125 "F:\Bigger things\Library\Library\Library\Views\Book\Shelves.cshtml"
                                                                                                           }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<span style=\"color:red;display:block\">Available: ");
#nullable restore
#line 127 "F:\Bigger things\Library\Library\Library\Views\Book\Shelves.cshtml"
                                                                                  Write(available);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>");
#nullable restore
#line 127 "F:\Bigger things\Library\Library\Library\Views\Book\Shelves.cshtml"
                                                                                                         }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <span style=\"display:block\">Year: ");
#nullable restore
#line 128 "F:\Bigger things\Library\Library\Library\Views\Book\Shelves.cshtml"
                                                                  Write(yearWritten);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                </small>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 135 "F:\Bigger things\Library\Library\Library\Views\Book\Shelves.cshtml"
                 if (i % 3 == 2)
                {

#line default
#line hidden
#nullable disable
#nullable restore
#line 136 "F:\Bigger things\Library\Library\Library\Views\Book\Shelves.cshtml"
            Write(Html.Raw("</div>"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 136 "F:\Bigger things\Library\Library\Library\Views\Book\Shelves.cshtml"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 136 "F:\Bigger things\Library\Library\Library\Views\Book\Shelves.cshtml"
                                     
                i++;
                shownISBNs.Add(book.Isbn);
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 139 "F:\Bigger things\Library\Library\Library\Views\Book\Shelves.cshtml"
             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"

    <script type=""text/javascript"">
        ////probably a non optimal location for js..??
        let summary_buttons = document.querySelectorAll("".summary"");
        summary_buttons.forEach(summary_button => {
            summary_button.addEventListener(""click"", showSummary)
        })

        function showSummary(e) {
            //extract number from id
            let modal_index = e.target.id.replace(/[^0-9]/g, """");
            let modal = document.querySelector(`#modal_${modal_index}`);
            //show book summary popup
            modal.style.display = ""block"";
            let clickListener = window.addEventListener(""click"", e => { if (e.target == modal) modal.style.display = ""none"" })
            window.removeEventListener(""click"", clickListener);
        }

        let dateTimeInput = document.getElementById(""dateTime"");
        let forms = document.querySelectorAll("".form"");
        forms.forEach(form => {
            form.addEventListener(""submit"", getCurrentDateTime)");
                WriteLiteral(@"
        })

        // using this function to generate time at which the client is creating the reservation
        function getCurrentDateTime(e) {
            e.preventDefault();
            let dateTimeInput = e.target.querySelector("".dateTime"");
            dateTimeInput.value = new Date().toISOString();
            e.target.submit();

        }

    </script>
");
            }
            );
        }
        #pragma warning restore 1998
#nullable restore
#line 40 "F:\Bigger things\Library\Library\Library\Views\Book\Shelves.cshtml"
                   
            public Dictionary<string, int> countHelper(IEnumerable<Book> books)
            {
                Dictionary<string, int> unusedBooksCount = new Dictionary<string, int>();
                foreach (var book in books)
                {
                    if (!unusedBooksCount.ContainsKey(book.Isbn))
                    {
                        unusedBooksCount.Add(book.Isbn, 0);
                        if (book.Borrowed == false)
                        { // could break this loop upon finding 1 unusedBook instead of going through the whole array
                            unusedBooksCount[book.Isbn] += 1;
                        }
                    }
                }
                return unusedBooksCount;
            }
        

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHttpContextAccessor HttpContextAccessor { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Library.ViewModels.BooksAndReservations> Html { get; private set; }
    }
}
#pragma warning restore 1591
