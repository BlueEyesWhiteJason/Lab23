#pragma checksum "C:\Users\Jarmo\source\repos\Lab23Again2\Lab23Again2\Views\Login\LoginSuccess.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "36ac3b9240b59efbfec06f731542242e96d36175"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Login_LoginSuccess), @"mvc.1.0.view", @"/Views/Login/LoginSuccess.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Login/LoginSuccess.cshtml", typeof(AspNetCore.Views_Login_LoginSuccess))]
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
#line 1 "C:\Users\Jarmo\source\repos\Lab23Again2\Lab23Again2\Views\_ViewImports.cshtml"
using Lab23Again2;

#line default
#line hidden
#line 2 "C:\Users\Jarmo\source\repos\Lab23Again2\Lab23Again2\Views\_ViewImports.cshtml"
using Lab23Again2.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36ac3b9240b59efbfec06f731542242e96d36175", @"/Views/Login/LoginSuccess.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5be238e981f03f91f9a63566bf2bf4ade0ea374", @"/Views/_ViewImports.cshtml")]
    public class Views_Login_LoginSuccess : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Jarmo\source\repos\Lab23Again2\Lab23Again2\Views\Login\LoginSuccess.cshtml"
  
    ViewData["Title"] = "LoginSuccess";

#line default
#line hidden
            BeginContext(50, 33, true);
            WriteLiteral("\r\n<h1>LoginSuccess</h1>\r\nWelcome ");
            EndContext();
            BeginContext(84, 20, false);
#line 7 "C:\Users\Jarmo\source\repos\Lab23Again2\Lab23Again2\Views\Login\LoginSuccess.cshtml"
   Write(ViewData["username"]);

#line default
#line hidden
            EndContext();
            BeginContext(104, 4, true);
            WriteLiteral("\r\n\r\n");
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