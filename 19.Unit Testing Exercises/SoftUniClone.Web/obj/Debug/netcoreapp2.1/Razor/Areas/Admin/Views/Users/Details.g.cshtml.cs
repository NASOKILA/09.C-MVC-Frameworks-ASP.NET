#pragma checksum "C:\Users\Asus\SoftUni\9.C# Web\C# Web MVC Frameworks ASP.NET\19.Unit Testing Exercises\SoftUniClone.Web\Areas\Admin\Views\Users\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c2a2a7d155fac9efd1a991f55c1d05458202382e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SoftUniClone.Web.Areas.Admin.Users.Areas_Admin_Views_Users_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/Users/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Users/Details.cshtml", typeof(SoftUniClone.Web.Areas.Admin.Users.Areas_Admin_Views_Users_Details))]
namespace SoftUniClone.Web.Areas.Admin.Users
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Asus\SoftUni\9.C# Web\C# Web MVC Frameworks ASP.NET\19.Unit Testing Exercises\SoftUniClone.Web\Areas\Admin\Views\_ViewImports.cshtml"
using SoftUniClone.Models;

#line default
#line hidden
#line 2 "C:\Users\Asus\SoftUni\9.C# Web\C# Web MVC Frameworks ASP.NET\19.Unit Testing Exercises\SoftUniClone.Web\Areas\Admin\Views\_ViewImports.cshtml"
using SoftUniClone.Web.Helpers;

#line default
#line hidden
#line 3 "C:\Users\Asus\SoftUni\9.C# Web\C# Web MVC Frameworks ASP.NET\19.Unit Testing Exercises\SoftUniClone.Web\Areas\Admin\Views\_ViewImports.cshtml"
using SoftUniClone.Web.Helpers.Messages;

#line default
#line hidden
#line 4 "C:\Users\Asus\SoftUni\9.C# Web\C# Web MVC Frameworks ASP.NET\19.Unit Testing Exercises\SoftUniClone.Web\Areas\Admin\Views\_ViewImports.cshtml"
using SoftUniClone.Services.Admin;

#line default
#line hidden
#line 5 "C:\Users\Asus\SoftUni\9.C# Web\C# Web MVC Frameworks ASP.NET\19.Unit Testing Exercises\SoftUniClone.Web\Areas\Admin\Views\_ViewImports.cshtml"
using SoftUniClone.Common.Admin.BindingModels;

#line default
#line hidden
#line 6 "C:\Users\Asus\SoftUni\9.C# Web\C# Web MVC Frameworks ASP.NET\19.Unit Testing Exercises\SoftUniClone.Web\Areas\Admin\Views\_ViewImports.cshtml"
using SoftUniClone.Common.Admin.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2a2a7d155fac9efd1a991f55c1d05458202382e", @"/Areas/Admin/Views/Users/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"299c73edc11a09cb6ebfc7ed0006662814a8393c", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Users_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UserDetailsViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Asus\SoftUni\9.C# Web\C# Web MVC Frameworks ASP.NET\19.Unit Testing Exercises\SoftUniClone.Web\Areas\Admin\Views\Users\Details.cshtml"
  
    ViewData["Title"] = "Details for " + Model.Username;

#line default
#line hidden
            BeginContext(94, 18, true);
            WriteLiteral("\r\n<h2>Details for ");
            EndContext();
            BeginContext(113, 14, false);
#line 6 "C:\Users\Asus\SoftUni\9.C# Web\C# Web MVC Frameworks ASP.NET\19.Unit Testing Exercises\SoftUniClone.Web\Areas\Admin\Views\Users\Details.cshtml"
           Write(Model.Username);

#line default
#line hidden
            EndContext();
            BeginContext(127, 7, true);
            WriteLiteral("</h2>\r\n");
            EndContext();
            BeginContext(135, 22, false);
#line 7 "C:\Users\Asus\SoftUni\9.C# Web\C# Web MVC Frameworks ASP.NET\19.Unit Testing Exercises\SoftUniClone.Web\Areas\Admin\Views\Users\Details.cshtml"
Write(Html.DisplayForModel());

#line default
#line hidden
            EndContext();
            BeginContext(157, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
