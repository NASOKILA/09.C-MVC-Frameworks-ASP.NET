#pragma checksum "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\Pets\PetFoundCompleted.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "49c565a06f7774c9721c2d2a199522905fea006f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pets_PetFoundCompleted), @"mvc.1.0.view", @"/Views/Pets/PetFoundCompleted.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pets/PetFoundCompleted.cshtml", typeof(AspNetCore.Views_Pets_PetFoundCompleted))]
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
#line 1 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\_ViewImports.cshtml"
using FindMyPet.Web;

#line default
#line hidden
#line 2 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\_ViewImports.cshtml"
using FindMyPet.Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49c565a06f7774c9721c2d2a199522905fea006f", @"/Views/Pets/PetFoundCompleted.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a72a3507736061eb4800cfa095c8cb4e67dac9f7", @"/Views/_ViewImports.cshtml")]
    public class Views_Pets_PetFoundCompleted : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Asus\Desktop\FindMyPet\FindMyPet\FindMyPet.Web\Views\Pets\PetFoundCompleted.cshtml"
  
    ViewData["Title"] = "PetFoundCompleted";

#line default
#line hidden
            BeginContext(55, 374, true);
            WriteLiteral(@"

<div class=""container"">
    <div class=""row"">
        <h1 class=""top"">Congratulations.</h1>
        <h2 class=""left"">Check your profile.</h2>
        <h2 class=""right"">You received additional credit for the pet you found.</h2>

        <a id=""btn-add-game"" href=""/Pets/All"" class=""tableDataRotateTop btn btn-primary btn-lg"">Back To Home</a>
    </div>
</div>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
