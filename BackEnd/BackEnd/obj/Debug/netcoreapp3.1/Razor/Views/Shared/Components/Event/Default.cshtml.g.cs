#pragma checksum "C:\Users\admin\Desktop\code academiya\BackEndProject\BackEnd\BackEnd\Views\Shared\Components\Event\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "674c53e259e449c378534a83d81853896f18065b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Event_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Event/Default.cshtml")]
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
using BackEnd.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"674c53e259e449c378534a83d81853896f18065b", @"/Views/Shared/Components/Event/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"abcf76cd9b9e6c77262f5d76cf0f72ac7e78a6a0", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Event_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Event>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("event"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\admin\Desktop\code academiya\BackEndProject\BackEnd\BackEnd\Views\Shared\Components\Event\Default.cshtml"
  
    int count = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"col-md-6 col-sm-12 col-xs-12\">\r\n\r\n");
#nullable restore
#line 7 "C:\Users\admin\Desktop\code academiya\BackEndProject\BackEnd\BackEnd\Views\Shared\Components\Event\Default.cshtml"
     foreach (Event events in Model)
{
    if (count % 2 == 0 && count != 0)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\admin\Desktop\code academiya\BackEndProject\BackEnd\BackEnd\Views\Shared\Components\Event\Default.cshtml"
   Write(Html.Raw("</div><div class='col-md-6 col-sm-12 col-xs-12'>"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\admin\Desktop\code academiya\BackEndProject\BackEnd\BackEnd\Views\Shared\Components\Event\Default.cshtml"
                                                                     
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"single-event mb-35\">\r\n        <div class=\"event-img\">\r\n            <a href=\"event-details.html\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "674c53e259e449c378534a83d81853896f18065b5031", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 380, "~/img/event/", 380, 12, true);
#nullable restore
#line 15 "C:\Users\admin\Desktop\code academiya\BackEndProject\BackEnd\BackEnd\Views\Shared\Components\Event\Default.cshtml"
AddHtmlAttributeValue("", 392, events.Image, 392, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</a>\r\n        </div>\r\n        <div class=\"event-content text-left\">\r\n            <h3>");
#nullable restore
#line 18 "C:\Users\admin\Desktop\code academiya\BackEndProject\BackEnd\BackEnd\Views\Shared\Components\Event\Default.cshtml"
           Write(events.Date.Day);

#line default
#line hidden
#nullable disable
            WriteLiteral(",");
#nullable restore
#line 18 "C:\Users\admin\Desktop\code academiya\BackEndProject\BackEnd\BackEnd\Views\Shared\Components\Event\Default.cshtml"
                            Write(events.Date.ToString("MMMM"));

#line default
#line hidden
#nullable disable
            WriteLiteral(",");
#nullable restore
#line 18 "C:\Users\admin\Desktop\code academiya\BackEndProject\BackEnd\BackEnd\Views\Shared\Components\Event\Default.cshtml"
                                                          Write(events.Date.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            <h4><a href=\"event-details.html\">");
#nullable restore
#line 19 "C:\Users\admin\Desktop\code academiya\BackEndProject\BackEnd\BackEnd\Views\Shared\Components\Event\Default.cshtml"
                                        Write(events.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a></h4>
            <ul>
                <li><i class=""fa fa-clock-o""></i>9.00 AM - 4.45 PM</li>
                <li><i class=""fa fa-map-marker""></i>New Yourk City</li>
            </ul>
            <div class=""event-content-right"">
                <a class=""default-btn"" href=""event-details.html"">join now</a>
            </div>
        </div>
    </div>
");
#nullable restore
#line 29 "C:\Users\admin\Desktop\code academiya\BackEndProject\BackEnd\BackEnd\Views\Shared\Components\Event\Default.cshtml"
        count++;
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    \r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Event>> Html { get; private set; }
    }
}
#pragma warning restore 1591