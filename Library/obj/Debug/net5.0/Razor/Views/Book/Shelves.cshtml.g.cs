#pragma checksum "F:\Bigger things\Library\Library\Library\Views\Book\Shelves.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4104d7d4b448d5a6e87f5b4e4bb1814a001517e3"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4104d7d4b448d5a6e87f5b4e4bb1814a001517e3", @"/Views/Book/Shelves.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dadb7a731bfbb305c411bc5eb7a307dbd6008a89", @"/Views/_ViewImports.cshtml")]
    public class Views_Book_Shelves : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Library.Models.Book>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "F:\Bigger things\Library\Library\Library\Views\Book\Shelves.cshtml"
  
    ViewData["Title"] = "Bookshelf";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<style>
      .bd-placeholder-img {
        font-size: 1.125rem;
        text-anchor: middle;
        -webkit-user-select: none;
        -moz-user-select: none;
        user-select: none;
      }

    
     
</style>

<section class=""py-5 text-center container"">
    <h1 class=""fw-light"">Available</h1>
</section>
<div class=""album py-5 bg-light"">
    <div class=""container-fluid"">
");
#nullable restore
#line 27 "F:\Bigger things\Library\Library\Library\Views\Book\Shelves.cshtml"
          int i = 0;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "F:\Bigger things\Library\Library\Library\Views\Book\Shelves.cshtml"
         foreach (var item in Model)
        {
            string Author;
            string yearWritten;
            if (String.IsNullOrEmpty(item.Author))
                Author = "N/A";
            else
                Author = item.Author;
            //incase YearWritten is null (this field in database is nullable) print N/A
            if (item.YearWritten.HasValue)
                yearWritten = item.YearWritten.Value.Year.ToString();
            else
                yearWritten = "N/A";
            string toPrint = "Author: " + Author + " Written in: " + yearWritten;
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "F:\Bigger things\Library\Library\Library\Views\Book\Shelves.cshtml"
             if (i % 3 == 0) 
            { 
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "F:\Bigger things\Library\Library\Library\Views\Book\Shelves.cshtml"
           Write(Html.Raw("<div class=\"row\">"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "F:\Bigger things\Library\Library\Library\Views\Book\Shelves.cshtml"
                                                
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-md-4\" >\r\n                        <div class=\"card shadow-sm\">\r\n\r\n");
#nullable restore
#line 49 "F:\Bigger things\Library\Library\Library\Views\Book\Shelves.cshtml"
                             if (item.ImageUrl != null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <img");
            BeginWriteAttribute("src", "   src=\"", 1445, "\"", 1480, 1);
#nullable restore
#line 51 "F:\Bigger things\Library\Library\Library\Views\Book\Shelves.cshtml"
WriteAttributeValue("", 1453, Url.Content(item.ImageUrl), 1453, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 52 "F:\Bigger things\Library\Library\Library\Views\Book\Shelves.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <img class=\".img-fluid\"  max-width: 100%; height:auto;");
            BeginWriteAttribute("src", " src=\"", 1668, "\"", 1715, 1);
#nullable restore
#line 55 "F:\Bigger things\Library\Library\Library\Views\Book\Shelves.cshtml"
WriteAttributeValue("", 1674, Url.Content("/images/default-image.jpg"), 1674, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 56 "F:\Bigger things\Library\Library\Library\Views\Book\Shelves.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            <div class=\"card-body\">\r\n                                <p class=\"card-text\">");
#nullable restore
#line 59 "F:\Bigger things\Library\Library\Library\Views\Book\Shelves.cshtml"
                                                Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                <div class=""d-flex justify-content-between align-items-center"">
                                    <div class=""btn-group"">
                                        <button type=""button"" class=""btn btn-sm btn-outline-secondary"">Reserve</button>
                                        <button type=""button"" class=""btn btn-sm btn-outline-secondary"">Summary</button>
                                    </div>
                                    <small class=""text-muted font-weight-bold""> 
                                        ");
#nullable restore
#line 66 "F:\Bigger things\Library\Library\Library\Views\Book\Shelves.cshtml"
                                   Write(toPrint);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </small>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 73 "F:\Bigger things\Library\Library\Library\Views\Book\Shelves.cshtml"
             if (i % 3 == 2) { 

#line default
#line hidden
#nullable disable
#nullable restore
#line 73 "F:\Bigger things\Library\Library\Library\Views\Book\Shelves.cshtml"
                          Write(Html.Raw("</div>"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 73 "F:\Bigger things\Library\Library\Library\Views\Book\Shelves.cshtml"
                                                  }

#line default
#line hidden
#nullable disable
#nullable restore
#line 73 "F:\Bigger things\Library\Library\Library\Views\Book\Shelves.cshtml"
                                                   
            i++;
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Library.Models.Book>> Html { get; private set; }
    }
}
#pragma warning restore 1591
