#pragma checksum "C:\Users\takum\OneDrive\Desktop\BankWeb\BankWeb\Views\Accounts\Withdraw.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ddee75e6b2861557cdc59bb630f9d60c2d0eb544"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Accounts_Withdraw), @"mvc.1.0.view", @"/Views/Accounts/Withdraw.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Accounts/Withdraw.cshtml", typeof(AspNetCore.Views_Accounts_Withdraw))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ddee75e6b2861557cdc59bb630f9d60c2d0eb544", @"/Views/Accounts/Withdraw.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f79fbfc77f7ddccb03c73828356e7b57d7847fc", @"/Views/_ViewImports.cshtml")]
    public class Views_Accounts_Withdraw : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BankWeb.Models.BankEntity.Account>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Withdraw", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetChecking", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetBusiness", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetTermDeposit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(42, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\takum\OneDrive\Desktop\BankWeb\BankWeb\Views\Accounts\Withdraw.cshtml"
  
    ViewData["Title"] = "Withdraw";

#line default
#line hidden
            BeginContext(88, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(90, 681, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2cfe87692dbf45e28c056d32f751c9d9", async() => {
                BeginContext(96, 668, true);
                WriteLiteral(@"
    <style>
        body {
            background-image: url(""https://www.canva.com/ja_jp/learn/wp-content/uploads/sites/10/2019/04/2.jpg"");
            color: black;
        }
        #btn {
                padding: 9px 25px;
                background-color: rgba(50,0,70,0.4);
                border: none;
                border-radius: 50px;
                cursor: pointer;
                transition: all 0.3s ease 0s;
            }

            #btn:hover {
                background-color: rgba(50,0,70,0.7);
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
            BeginContext(771, 10, true);
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n");
            EndContext();
            BeginContext(781, 1157, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "feee5ee6ad4f42ab963c5c464ff10b37", async() => {
                BeginContext(787, 104, true);
                WriteLiteral("\r\n    <h2>Withdraw</h2>\r\n    <hr />\r\n    <div class=\"row\">\r\n        <div class=\"col-md-4\">\r\n            ");
                EndContext();
                BeginContext(891, 558, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4078e3aca8aa4d9f91ce9fa43faa51e8", async() => {
                    BeginContext(919, 2, true);
                    WriteLiteral("\r\n");
                    EndContext();
#line 41 "C:\Users\takum\OneDrive\Desktop\BankWeb\BankWeb\Views\Accounts\Withdraw.cshtml"
                 if(ViewBag.Message!=null)
                {

#line default
#line hidden
                    BeginContext(984, 46, true);
                    WriteLiteral("                    <p style=\"color:hotpink;\">");
                    EndContext();
                    BeginContext(1031, 15, false);
#line 43 "C:\Users\takum\OneDrive\Desktop\BankWeb\BankWeb\Views\Accounts\Withdraw.cshtml"
                                         Write(ViewBag.Message);

#line default
#line hidden
                    EndContext();
                    BeginContext(1046, 6, true);
                    WriteLiteral("</p>\r\n");
                    EndContext();
#line 44 "C:\Users\takum\OneDrive\Desktop\BankWeb\BankWeb\Views\Accounts\Withdraw.cshtml"
                }

#line default
#line hidden
                    BeginContext(1071, 371, true);
                    WriteLiteral(@"                <div class=""form-group"">
                    <label class=""control-label"">Withdraw Amount: </label>
                    <input type=""number"" name=""amount"" min=""0"" id=""input"" />
                </div>

                <div class=""form-group"">
                    <input type=""submit"" value=""Withdraw"" id=""btn"" />
                </div>
            ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1449, 43, true);
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div>\r\n");
                EndContext();
#line 58 "C:\Users\takum\OneDrive\Desktop\BankWeb\BankWeb\Views\Accounts\Withdraw.cshtml"
          
            if (Model.AccountType == "Checking")
            {

#line default
#line hidden
                BeginContext(1569, 16, true);
                WriteLiteral("                ");
                EndContext();
                BeginContext(1585, 44, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "03b0b88b4bbd44bfaac9aa391ea1ca7b", async() => {
                    BeginContext(1613, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1629, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 62 "C:\Users\takum\OneDrive\Desktop\BankWeb\BankWeb\Views\Accounts\Withdraw.cshtml"
            }
            else if (Model.AccountType == "Business")
            {

#line default
#line hidden
                BeginContext(1716, 16, true);
                WriteLiteral("                ");
                EndContext();
                BeginContext(1732, 44, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "744a90ff45f34b2894a3782923e305ab", async() => {
                    BeginContext(1760, 12, true);
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
                BeginContext(1776, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 66 "C:\Users\takum\OneDrive\Desktop\BankWeb\BankWeb\Views\Accounts\Withdraw.cshtml"
            }
            else
            {

#line default
#line hidden
                BeginContext(1826, 16, true);
                WriteLiteral("                ");
                EndContext();
                BeginContext(1842, 47, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d9f6739b4cd043e384319a15f7cad285", async() => {
                    BeginContext(1873, 12, true);
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
                BeginContext(1889, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 70 "C:\Users\takum\OneDrive\Desktop\BankWeb\BankWeb\Views\Accounts\Withdraw.cshtml"
            }
        

#line default
#line hidden
                BeginContext(1917, 14, true);
                WriteLiteral("    </div>\r\n\r\n");
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
            BeginContext(1938, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1960, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 77 "C:\Users\takum\OneDrive\Desktop\BankWeb\BankWeb\Views\Accounts\Withdraw.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
            }
            );
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