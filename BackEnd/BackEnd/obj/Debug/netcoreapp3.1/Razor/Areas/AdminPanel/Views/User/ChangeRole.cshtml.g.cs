#pragma checksum "C:\Users\admin\Desktop\code academiya\BackEndProject\BackEnd\BackEnd\Areas\AdminPanel\Views\User\ChangeRole.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f3058bb859df4a7771438102069abc20aa4a2246"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdminPanel_Views_User_ChangeRole), @"mvc.1.0.view", @"/Areas/AdminPanel/Views/User/ChangeRole.cshtml")]
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
#line 1 "C:\Users\admin\Desktop\code academiya\BackEndProject\BackEnd\BackEnd\Areas\AdminPanel\Views\_ViewImports.cshtml"
using BackEnd;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\admin\Desktop\code academiya\BackEndProject\BackEnd\BackEnd\Areas\AdminPanel\Views\_ViewImports.cshtml"
using BackEnd.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\admin\Desktop\code academiya\BackEndProject\BackEnd\BackEnd\Areas\AdminPanel\Views\_ViewImports.cshtml"
using BackEnd.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3058bb859df4a7771438102069abc20aa4a2246", @"/Areas/AdminPanel/Views/User/ChangeRole.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34ef4389fcfd53f0f922742bac588a83109523e6", @"/Areas/AdminPanel/Views/_ViewImports.cshtml")]
    public class Areas_AdminPanel_Views_User_ChangeRole : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UserVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary mt-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\admin\Desktop\code academiya\BackEndProject\BackEnd\BackEnd\Areas\AdminPanel\Views\User\ChangeRole.cshtml"
  
    ViewData["Title"] = "ChangeRole";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"col-md-6 grid-margin stretch-card\">\r\n    <div class=\"card\">\r\n        <div class=\"card-body\">\r\n            <h4 class=\"card-title\">");
#nullable restore
#line 9 "C:\Users\admin\Desktop\code academiya\BackEndProject\BackEnd\BackEnd\Areas\AdminPanel\Views\User\ChangeRole.cshtml"
                              Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n            <h5>");
#nullable restore
#line 10 "C:\Users\admin\Desktop\code academiya\BackEndProject\BackEnd\BackEnd\Areas\AdminPanel\Views\User\ChangeRole.cshtml"
           Write(Model.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n            <h5>");
#nullable restore
#line 11 "C:\Users\admin\Desktop\code academiya\BackEndProject\BackEnd\BackEnd\Areas\AdminPanel\Views\User\ChangeRole.cshtml"
           Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n        </div>\r\n    </div>\r\n</div>\r\n<h3 class=\"text-danger\">Are you sure</h3>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f3058bb859df4a7771438102069abc20aa4a22466056", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 17 "C:\Users\admin\Desktop\code academiya\BackEndProject\BackEnd\BackEnd\Areas\AdminPanel\Views\User\ChangeRole.cshtml"
     foreach (string role in Model.Roles)
    {
        if (Model.Role == role)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div class=\"form-group\">\r\n                <input type=\"radio\" name=\"role\" checked");
                BeginWriteAttribute("value", " value=\"", 583, "\"", 596, 1);
#nullable restore
#line 22 "C:\Users\admin\Desktop\code academiya\BackEndProject\BackEnd\BackEnd\Areas\AdminPanel\Views\User\ChangeRole.cshtml"
WriteAttributeValue("", 591, role, 591, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />");
#nullable restore
#line 22 "C:\Users\admin\Desktop\code academiya\BackEndProject\BackEnd\BackEnd\Areas\AdminPanel\Views\User\ChangeRole.cshtml"
                                                                   Write(role);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n");
#nullable restore
#line 24 "C:\Users\admin\Desktop\code academiya\BackEndProject\BackEnd\BackEnd\Areas\AdminPanel\Views\User\ChangeRole.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div class=\"form-group\">\r\n                <input type=\"radio\" name=\"role\"");
                BeginWriteAttribute("value", " value=\"", 748, "\"", 761, 1);
#nullable restore
#line 28 "C:\Users\admin\Desktop\code academiya\BackEndProject\BackEnd\BackEnd\Areas\AdminPanel\Views\User\ChangeRole.cshtml"
WriteAttributeValue("", 756, role, 756, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />");
#nullable restore
#line 28 "C:\Users\admin\Desktop\code academiya\BackEndProject\BackEnd\BackEnd\Areas\AdminPanel\Views\User\ChangeRole.cshtml"
                                                           Write(role);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n");
#nullable restore
#line 30 "C:\Users\admin\Desktop\code academiya\BackEndProject\BackEnd\BackEnd\Areas\AdminPanel\Views\User\ChangeRole.cshtml"
        }

    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <button type=\"submit\" class=\"btn btn-danger\">Change Role</button>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f3058bb859df4a7771438102069abc20aa4a224610079", async() => {
                WriteLiteral("Go Back");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserVM> Html { get; private set; }
    }
}
#pragma warning restore 1591