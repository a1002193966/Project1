#pragma checksum "C:\Users\takum\OneDrive\Desktop\BankWeb\BankWeb\Views\Accounts\Close.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "47e45ae05e341aa129efc4337bc1609b37263011"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Accounts_Close), @"mvc.1.0.view", @"/Views/Accounts/Close.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Accounts/Close.cshtml", typeof(AspNetCore.Views_Accounts_Close))]
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
#line 1 "C:\Users\takum\OneDrive\Desktop\BankWeb\BankWeb\Views\_ViewImports.cshtml"
using BankWeb;

#line default
#line hidden
#line 2 "C:\Users\takum\OneDrive\Desktop\BankWeb\BankWeb\Views\_ViewImports.cshtml"
using BankWeb.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47e45ae05e341aa129efc4337bc1609b37263011", @"/Views/Accounts/Close.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f79fbfc77f7ddccb03c73828356e7b57d7847fc", @"/Views/_ViewImports.cshtml")]
    public class Views_Accounts_Close : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BankWeb.Models.BankEntity.Account>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Close", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetChecking", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetBusiness", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetTermDeposit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetTermLoan", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(42, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\takum\OneDrive\Desktop\BankWeb\BankWeb\Views\Accounts\Close.cshtml"
  
    ViewData["Title"] = "Close";

#line default
#line hidden
            BeginContext(85, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(91, 709, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "087500123d814b4ca280c6ddafacca62", async() => {
                BeginContext(97, 696, true);
                WriteLiteral(@"
        <style>
            body {
                background-image: url(""https://www.canva.com/ja_jp/learn/wp-content/uploads/sites/10/2019/04/2.jpg"");
            color: black;
            }
            #btn {
                padding: 9px 25px;
                background-color: rgba(136,0,50,0.4);
                border: none;
                border-radius: 50px;
                cursor: pointer;
                transition: all 0.3s ease 0s;
            }
            #btn:hover {
                background-color: rgba(136,0,50,0.7);
            }
            a{
                text-decoration: none;
                color: black;
            }
        </style>
    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(800, 8, true);
            WriteLiteral("\r\n\r\n\r\n\r\n");
            EndContext();
            BeginContext(808, 1516, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a70286637424458fa689e9b13c725332", async() => {
                BeginContext(814, 98, true);
                WriteLiteral("\r\n<h2>Closing</h2>\r\n<h3>Are you sure you want to close this account?</h3>\r\n<div>\r\n    <hr />\r\n    ");
                EndContext();
                BeginContext(912, 781, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "882d9bb303a64924b92bbe14045c7e6c", async() => {
                    BeginContext(937, 108, true);
                    WriteLiteral("\r\n        <table class=\"table table-bordered\">\r\n            <tr>\r\n                <td>\r\n                    ");
                    EndContext();
                    BeginContext(1046, 49, false);
#line 42 "C:\Users\takum\OneDrive\Desktop\BankWeb\BankWeb\Views\Accounts\Close.cshtml"
               Write(Html.DisplayNameFor(model => model.AccountNumber));

#line default
#line hidden
                    EndContext();
                    BeginContext(1095, 22, true);
                    WriteLiteral("\r\n                    ");
                    EndContext();
                    BeginContext(1118, 45, false);
#line 43 "C:\Users\takum\OneDrive\Desktop\BankWeb\BankWeb\Views\Accounts\Close.cshtml"
               Write(Html.DisplayFor(model => model.AccountNumber));

#line default
#line hidden
                    EndContext();
                    BeginContext(1163, 67, true);
                    WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
                    EndContext();
                    BeginContext(1231, 43, false);
#line 46 "C:\Users\takum\OneDrive\Desktop\BankWeb\BankWeb\Views\Accounts\Close.cshtml"
               Write(Html.DisplayNameFor(model => model.Balance));

#line default
#line hidden
                    EndContext();
                    BeginContext(1274, 22, true);
                    WriteLiteral("\r\n                    ");
                    EndContext();
                    BeginContext(1297, 39, false);
#line 47 "C:\Users\takum\OneDrive\Desktop\BankWeb\BankWeb\Views\Accounts\Close.cshtml"
               Write(Html.DisplayFor(model => model.Balance));

#line default
#line hidden
                    EndContext();
                    BeginContext(1336, 67, true);
                    WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
                    EndContext();
                    BeginContext(1404, 47, false);
#line 50 "C:\Users\takum\OneDrive\Desktop\BankWeb\BankWeb\Views\Accounts\Close.cshtml"
               Write(Html.DisplayNameFor(model => model.AccountType));

#line default
#line hidden
                    EndContext();
                    BeginContext(1451, 22, true);
                    WriteLiteral("\r\n                    ");
                    EndContext();
                    BeginContext(1474, 43, false);
#line 51 "C:\Users\takum\OneDrive\Desktop\BankWeb\BankWeb\Views\Accounts\Close.cshtml"
               Write(Html.DisplayFor(model => model.AccountType));

#line default
#line hidden
                    EndContext();
                    BeginContext(1517, 70, true);
                    WriteLiteral("\r\n                </td>\r\n            </tr>\r\n        </table>\r\n        ");
                    EndContext();
                    BeginContext(1587, 36, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1139c191a46645b58dfef321ff2d0dd2", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 55 "C:\Users\takum\OneDrive\Desktop\BankWeb\BankWeb\Views\Accounts\Close.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(1623, 63, true);
                    WriteLiteral("\r\n        <input type=\"submit\" value=\"Close\" id=\"btn\" /> \r\n    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1693, 25, true);
                WriteLiteral("\r\n    <br />\r\n    <div>\r\n");
                EndContext();
#line 60 "C:\Users\takum\OneDrive\Desktop\BankWeb\BankWeb\Views\Accounts\Close.cshtml"
          
            if (Model.AccountType == "Checking")
            {

#line default
#line hidden
                BeginContext(1795, 16, true);
                WriteLiteral("                ");
                EndContext();
                BeginContext(1811, 44, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f8c1aa88374e486c95bf19502e18c733", async() => {
                    BeginContext(1839, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1855, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 64 "C:\Users\takum\OneDrive\Desktop\BankWeb\BankWeb\Views\Accounts\Close.cshtml"
            }
            else if (Model.AccountType == "Business")
            {

#line default
#line hidden
                BeginContext(1942, 16, true);
                WriteLiteral("                ");
                EndContext();
                BeginContext(1958, 44, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ed942866c9dd493cbdfc1f46ce178a17", async() => {
                    BeginContext(1986, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2002, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 68 "C:\Users\takum\OneDrive\Desktop\BankWeb\BankWeb\Views\Accounts\Close.cshtml"
            }
            else if (Model.AccountType == "TermDeposit")
            {

#line default
#line hidden
                BeginContext(2092, 16, true);
                WriteLiteral("                ");
                EndContext();
                BeginContext(2108, 47, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6728bf9c9e204eec968cf2b28a31816d", async() => {
                    BeginContext(2139, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2155, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 72 "C:\Users\takum\OneDrive\Desktop\BankWeb\BankWeb\Views\Accounts\Close.cshtml"
            }
            else
            {

#line default
#line hidden
                BeginContext(2205, 16, true);
                WriteLiteral("                ");
                EndContext();
                BeginContext(2221, 44, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a02e6d5d84ae4b0d87c80ab952870066", async() => {
                    BeginContext(2249, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2265, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 76 "C:\Users\takum\OneDrive\Desktop\BankWeb\BankWeb\Views\Accounts\Close.cshtml"
            }
        

#line default
#line hidden
                BeginContext(2293, 24, true);
                WriteLiteral("    </div>\r\n\r\n</div>\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2324, 2, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BankWeb.Models.BankEntity.Account> Html { get; private set; }
    }
}
#pragma warning restore 1591