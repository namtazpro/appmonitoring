#pragma checksum "F:\bin\ghnamtazpro\appmonitoring\apps\ASPNetCoreWebApp\Views\HW\Welcome.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ee51bdaf1f2804275d3e01d0f3fc552f0a09c7a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HW_Welcome), @"mvc.1.0.view", @"/Views/HW/Welcome.cshtml")]
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
#line 1 "F:\bin\ghnamtazpro\appmonitoring\apps\ASPNetCoreWebApp\Views\_ViewImports.cshtml"
using ASPNetCoreWebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\bin\ghnamtazpro\appmonitoring\apps\ASPNetCoreWebApp\Views\_ViewImports.cshtml"
using ASPNetCoreWebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ee51bdaf1f2804275d3e01d0f3fc552f0a09c7a", @"/Views/HW/Welcome.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9be51c3620d10b38ee34210b28528584c54bf21b", @"/Views/_ViewImports.cshtml")]
    public class Views_HW_Welcome : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "F:\bin\ghnamtazpro\appmonitoring\apps\ASPNetCoreWebApp\Views\HW\Welcome.cshtml"
  
    ViewData["Title"] = "Welcome";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Welcome</h2>\r\n\r\n<ul>\r\n");
#nullable restore
#line 8 "F:\bin\ghnamtazpro\appmonitoring\apps\ASPNetCoreWebApp\Views\HW\Welcome.cshtml"
     for (int i = 0; i < (int)ViewData["NumTimes"]; i++)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <li>");
#nullable restore
#line 10 "F:\bin\ghnamtazpro\appmonitoring\apps\ASPNetCoreWebApp\Views\HW\Welcome.cshtml"
   Write(ViewData["Message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 11 "F:\bin\ghnamtazpro\appmonitoring\apps\ASPNetCoreWebApp\Views\HW\Welcome.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\r\n");
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
