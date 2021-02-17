#pragma checksum "F:\Bigger things\Library\Library\Library\Views\User\MyBooks.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "699ce7eb5709303d4b1b36161e0a43e81dc8112b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_MyBooks), @"mvc.1.0.view", @"/Views/User/MyBooks.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"699ce7eb5709303d4b1b36161e0a43e81dc8112b", @"/Views/User/MyBooks.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dadb7a731bfbb305c411bc5eb7a307dbd6008a89", @"/Views/_ViewImports.cshtml")]
    public class Views_User_MyBooks : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Library.ViewModels.BorrowedBookVm>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "F:\Bigger things\Library\Library\Library\Views\User\MyBooks.cshtml"
  
    ViewData["Title"] = "My Books";

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
                        My Books
                    </h2>
                </div>
");
#nullable restore
#line 17 "F:\Bigger things\Library\Library\Library\Views\User\MyBooks.cshtml"
                 if (!Model.Any())
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p class=\"alert alert-info\">Sorry, you don\'t have any books, maybe you should order some!</p>\r\n");
#nullable restore
#line 20 "F:\Bigger things\Library\Library\Library\Views\User\MyBooks.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <table class=""table table-hover"" style=""cursor:default"">
                        <thead>
                            <tr>
                                <th>Book Name</th>
                                <th>Book Author</th>
                                <th>Return By</th>
                            </tr>
                        </thead>
                        <tbody>

");
#nullable restore
#line 33 "F:\Bigger things\Library\Library\Library\Views\User\MyBooks.cshtml"
                             foreach (var book in Model)
                            {
                                string author;
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "F:\Bigger things\Library\Library\Library\Views\User\MyBooks.cshtml"
                                 if (String.IsNullOrEmpty(book.Author))
                                    author = "N/A";
                                else
                                    author = book.Author;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr valign=\"top\">\r\n                                    <td>");
#nullable restore
#line 41 "F:\Bigger things\Library\Library\Library\Views\User\MyBooks.cshtml"
                                   Write(book.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 42 "F:\Bigger things\Library\Library\Library\Views\User\MyBooks.cshtml"
                                   Write(author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n");
#nullable restore
#line 44 "F:\Bigger things\Library\Library\Library\Views\User\MyBooks.cshtml"
                                     if (@book.ReturnBy.Subtract(DateTime.Now).Days < 3)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td style=\"background-color:indianred\">");
#nullable restore
#line 46 "F:\Bigger things\Library\Library\Library\Views\User\MyBooks.cshtml"
                                                                          Write(book.ReturnBy.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 47 "F:\Bigger things\Library\Library\Library\Views\User\MyBooks.cshtml"
                                    }
                                    else if (@book.ReturnBy.Subtract(DateTime.Now).Days < 7)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td style=\"background-color:orange\">");
#nullable restore
#line 50 "F:\Bigger things\Library\Library\Library\Views\User\MyBooks.cshtml"
                                                                       Write(book.ReturnBy.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("e</td>\r\n");
#nullable restore
#line 51 "F:\Bigger things\Library\Library\Library\Views\User\MyBooks.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td style=\"background-color:lightgreen\">");
#nullable restore
#line 54 "F:\Bigger things\Library\Library\Library\Views\User\MyBooks.cshtml"
                                                                           Write(book.ReturnBy.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 55 "F:\Bigger things\Library\Library\Library\Views\User\MyBooks.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </tr>\r\n");
#nullable restore
#line 57 "F:\Bigger things\Library\Library\Library\Views\User\MyBooks.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n");
#nullable restore
#line 60 "F:\Bigger things\Library\Library\Library\Views\User\MyBooks.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Library.ViewModels.BorrowedBookVm>> Html { get; private set; }
    }
}
#pragma warning restore 1591
