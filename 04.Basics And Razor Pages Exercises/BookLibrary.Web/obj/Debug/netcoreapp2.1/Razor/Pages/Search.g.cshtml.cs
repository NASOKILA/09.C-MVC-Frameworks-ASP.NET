#pragma checksum "C:\Users\Asus\SoftUni\9.C# Web\C# Web MVC Frameworks ASP.NET\04.Basics And Razor Pages Exercises\BookLibrary.Web\Pages\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3bbaa3438073f5121ec4e137a1d5f2f58329225e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(BookLibrary.Web.Pages.Pages_Search), @"mvc.1.0.razor-page", @"/Pages/Search.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Search.cshtml", typeof(BookLibrary.Web.Pages.Pages_Search), null)]
namespace BookLibrary.Web.Pages
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3bbaa3438073f5121ec4e137a1d5f2f58329225e", @"/Pages/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ff36466da1b22f276565f2db2f5eb59ca1c94b5", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Search : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\Asus\SoftUni\9.C# Web\C# Web MVC Frameworks ASP.NET\04.Basics And Razor Pages Exercises\BookLibrary.Web\Pages\Search.cshtml"
  
    Layout = "_Layout";
    ViewData["Title"] = "Search";

#line default
#line hidden
            BeginContext(116, 21, true);
            WriteLiteral("<h1>Search results: \"");
            EndContext();
            BeginContext(138, 12, false);
#line 7 "C:\Users\Asus\SoftUni\9.C# Web\C# Web MVC Frameworks ASP.NET\04.Basics And Razor Pages Exercises\BookLibrary.Web\Pages\Search.cshtml"
                Write(Model.Search);

#line default
#line hidden
            EndContext();
            BeginContext(150, 20, true);
            WriteLiteral("\"</h1>\r\n\r\n<ul>\r\n    ");
            EndContext();
            BeginContext(171, 23, false);
#line 10 "C:\Users\Asus\SoftUni\9.C# Web\C# Web MVC Frameworks ASP.NET\04.Basics And Razor Pages Exercises\BookLibrary.Web\Pages\Search.cshtml"
Write(Html.Raw(Model.Authors));

#line default
#line hidden
            EndContext();
            BeginContext(194, 26, true);
            WriteLiteral("\r\n</ul>\r\n<br/>\r\n<ul>\r\n    ");
            EndContext();
            BeginContext(221, 21, false);
#line 14 "C:\Users\Asus\SoftUni\9.C# Web\C# Web MVC Frameworks ASP.NET\04.Basics And Razor Pages Exercises\BookLibrary.Web\Pages\Search.cshtml"
Write(Html.Raw(Model.Books));

#line default
#line hidden
            EndContext();
            BeginContext(242, 7, true);
            WriteLiteral("\r\n</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BookLibrary.Web.Pages.SearchModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BookLibrary.Web.Pages.SearchModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BookLibrary.Web.Pages.SearchModel>)PageContext?.ViewData;
        public BookLibrary.Web.Pages.SearchModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
