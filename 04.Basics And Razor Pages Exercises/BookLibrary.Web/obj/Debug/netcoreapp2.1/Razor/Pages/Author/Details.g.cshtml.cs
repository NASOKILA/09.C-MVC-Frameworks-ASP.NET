#pragma checksum "C:\Users\Asus\SoftUni\9.C# Web\C# Web MVC Frameworks ASP.NET\04.Basics And Razor Pages Exercises\BookLibrary.Web\Pages\Author\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2aac95704ee9c5605724a52e10d699f47c7985d1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(BookLibrary.Web.Pages.Author.Pages_Author_Details), @"mvc.1.0.razor-page", @"/Pages/Author/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Author/Details.cshtml", typeof(BookLibrary.Web.Pages.Author.Pages_Author_Details), @"{id}")]
namespace BookLibrary.Web.Pages.Author
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 2 "C:\Users\Asus\SoftUni\9.C# Web\C# Web MVC Frameworks ASP.NET\04.Basics And Razor Pages Exercises\BookLibrary.Web\Pages\_ViewImports.cshtml"
using BookLibrary.Web;

#line default
#line hidden
#line 3 "C:\Users\Asus\SoftUni\9.C# Web\C# Web MVC Frameworks ASP.NET\04.Basics And Razor Pages Exercises\BookLibrary.Web\Pages\_ViewImports.cshtml"
using BookLibrary.Web.BindingModels;

#line default
#line hidden
#line 3 "C:\Users\Asus\SoftUni\9.C# Web\C# Web MVC Frameworks ASP.NET\04.Basics And Razor Pages Exercises\BookLibrary.Web\Pages\Author\Details.cshtml"
using BookLibrary.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{id}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2aac95704ee9c5605724a52e10d699f47c7985d1", @"/Pages/Author/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ff36466da1b22f276565f2db2f5eb59ca1c94b5", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Author_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 4 "C:\Users\Asus\SoftUni\9.C# Web\C# Web MVC Frameworks ASP.NET\04.Basics And Razor Pages Exercises\BookLibrary.Web\Pages\Author\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(135, 14, true);
            WriteLiteral("\r\n<br />\r\n<h2>");
            EndContext();
            BeginContext(150, 17, false);
#line 9 "C:\Users\Asus\SoftUni\9.C# Web\C# Web MVC Frameworks ASP.NET\04.Basics And Razor Pages Exercises\BookLibrary.Web\Pages\Author\Details.cshtml"
Write(Model.Author.Name);

#line default
#line hidden
            EndContext();
            BeginContext(167, 25, true);
            WriteLiteral("</h2>\r\n\r\n<ul>\r\n    \r\n    ");
            EndContext();
            BeginContext(193, 27, false);
#line 13 "C:\Users\Asus\SoftUni\9.C# Web\C# Web MVC Frameworks ASP.NET\04.Basics And Razor Pages Exercises\BookLibrary.Web\Pages\Author\Details.cshtml"
Write(Html.Raw(Model.BooksString));

#line default
#line hidden
            EndContext();
            BeginContext(220, 9, true);
            WriteLiteral("\r\n</ul>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BookLibrary.Web.Pages.Author.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BookLibrary.Web.Pages.Author.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BookLibrary.Web.Pages.Author.DetailsModel>)PageContext?.ViewData;
        public BookLibrary.Web.Pages.Author.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
