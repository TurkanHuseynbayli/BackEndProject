#pragma checksum "C:\Users\admin\Desktop\code academiya\BackEndProject\BackEnd\BackEnd\Views\Shared\Components\Notice\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "09576db93a6c0b4cac925d3dae5b7b47e148fff0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Notice_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Notice/Default.cshtml")]
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
#line 1 "C:\Users\admin\Desktop\code academiya\BackEndProject\BackEnd\BackEnd\Views\_ViewImports.cshtml"
using BackEnd;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\admin\Desktop\code academiya\BackEndProject\BackEnd\BackEnd\Views\_ViewImports.cshtml"
using BackEnd.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\admin\Desktop\code academiya\BackEndProject\BackEnd\BackEnd\Views\_ViewImports.cshtml"
using BackEnd.Models.Categories;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\admin\Desktop\code academiya\BackEndProject\BackEnd\BackEnd\Views\_ViewImports.cshtml"
using BackEnd.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09576db93a6c0b4cac925d3dae5b7b47e148fff0", @"/Views/Shared/Components/Notice/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e91b8d91c086b60546e5c8046138d7a7c398ab06", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Notice_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""container"">
    <div class=""row"">
        <div class=""col-md-6 col-sm-6 col-xs-12"">
            <div class=""notice-right-wrapper mb-25 pb-25"">
                <h3>TAKE A VIDEO TOUR</h3>
                <div class=""notice-video"">
                    <div class=""video-icon video-hover"">
                        <a class=""video-popup""");
            BeginWriteAttribute("href", " href=\"", 366, "\"", 387, 2);
#nullable restore
#line 9 "C:\Users\admin\Desktop\code academiya\BackEndProject\BackEnd\BackEnd\Views\Shared\Components\Notice\Default.cshtml"
WriteAttributeValue("", 373, Model.Videos, 373, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 386, ".", 386, 1, true);
            EndWriteAttribute();
            WriteLiteral(@">
                            <i class=""zmdi zmdi-play""></i>
                        </a>
                    </div>
                </div>
            </div>
        </div>
        <div class=""col-md-6 col-sm-6 col-xs-12"">
            <div class=""notice-left-wrapper"">
                <h3>notice board</h3>
                <div class=""notice-left"">
");
#nullable restore
#line 20 "C:\Users\admin\Desktop\code academiya\BackEndProject\BackEnd\BackEnd\Views\Shared\Components\Notice\Default.cshtml"
                     foreach (Board board in Model.Boards)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"single-notice-left mb-23 pb-20\">\r\n                            <h4>");
#nullable restore
#line 23 "C:\Users\admin\Desktop\code academiya\BackEndProject\BackEnd\BackEnd\Views\Shared\Components\Notice\Default.cshtml"
                           Write(board.Time.Day);

#line default
#line hidden
#nullable disable
            WriteLiteral(",");
#nullable restore
#line 23 "C:\Users\admin\Desktop\code academiya\BackEndProject\BackEnd\BackEnd\Views\Shared\Components\Notice\Default.cshtml"
                                           Write(board.Time.ToString("MMMM"));

#line default
#line hidden
#nullable disable
            WriteLiteral(",");
#nullable restore
#line 23 "C:\Users\admin\Desktop\code academiya\BackEndProject\BackEnd\BackEnd\Views\Shared\Components\Notice\Default.cshtml"
                                                                        Write(board.Time.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                            <p>");
#nullable restore
#line 24 "C:\Users\admin\Desktop\code academiya\BackEndProject\BackEnd\BackEnd\Views\Shared\Components\Notice\Default.cshtml"
                          Write(board.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                        </div>\r\n");
#nullable restore
#line 26 "C:\Users\admin\Desktop\code academiya\BackEndProject\BackEnd\BackEnd\Views\Shared\Components\Notice\Default.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                   \r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
