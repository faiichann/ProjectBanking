#pragma checksum "C:\Users\win10\source\repos\ProjectBanking\ProjectBanking\Views\Home\saveasync.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "66f06edf665fa184158eacb48ac59be780d9b769"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_saveasync), @"mvc.1.0.view", @"/Views/Home/saveasync.cshtml")]
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
#line 1 "C:\Users\win10\source\repos\ProjectBanking\ProjectBanking\Views\_ViewImports.cshtml"
using ProjectBanking;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\win10\source\repos\ProjectBanking\ProjectBanking\Views\_ViewImports.cshtml"
using ProjectBanking.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66f06edf665fa184158eacb48ac59be780d9b769", @"/Views/Home/saveasync.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"836032e52e80d6e35594ba437c40b281933943cc", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_saveasync : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjectBanking.Models.Savings>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Save", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CalSaving", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 5 "C:\Users\win10\source\repos\ProjectBanking\ProjectBanking\Views\Home\saveasync.cshtml"
  
    ViewData["Title"] = "saveasync";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>saveasync</h1>\r\n\r\n<h4>Savings</h4>\r\n<div>\r\n    <p>ฝากออมทรัพย์</p>\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "66f06edf665fa184158eacb48ac59be780d9b7695247", async() => {
                WriteLiteral(@"
        <span>เงินฝากต้น: </span><input step=""0.01"" type=""number"" name=""Smoney"" /><br />
        <span>ระยะฝาก : </span><input step=""0.01"" type=""number"" name=""Sday"" /><br />
        <span>อัตราดอกเบี้ย : </span><input step=""0.01"" type=""number"" name=""Srate"" hidden /><br />
        <input id=""cal2"" type=""submit"" value=""Calculation2"" /><br />

        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "66f06edf665fa184158eacb48ac59be780d9b7695884", async() => {
                    WriteLiteral(@"

            <hr />
                    <h1>แบบใช้ Async await</h1>
                    <div class=""table"">
                        <div>
                            <div class=""row"">
                                <div class=""col"">
                                    ");
#nullable restore
#line 29 "C:\Users\win10\source\repos\ProjectBanking\ProjectBanking\Views\Home\saveasync.cshtml"
                               Write(Html.DisplayNameFor(model => model.SBankName));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                                </div>\r\n                                <div class=\"col\">\r\n                                    ");
#nullable restore
#line 32 "C:\Users\win10\source\repos\ProjectBanking\ProjectBanking\Views\Home\saveasync.cshtml"
                               Write(Html.DisplayNameFor(model => model.SRate));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                                </div>\r\n                                <div class=\"col\">\r\n                                    ");
#nullable restore
#line 35 "C:\Users\win10\source\repos\ProjectBanking\ProjectBanking\Views\Home\saveasync.cshtml"
                               Write(Html.DisplayNameFor(model => model.Sday));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                                </div>\r\n                                <div class=\"col\">\r\n                                    ");
#nullable restore
#line 38 "C:\Users\win10\source\repos\ProjectBanking\ProjectBanking\Views\Home\saveasync.cshtml"
                               Write(Html.DisplayNameFor(model => model.Smoney));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                                </div>\r\n                                <div class=\"col\">\r\n                                    ");
#nullable restore
#line 41 "C:\Users\win10\source\repos\ProjectBanking\ProjectBanking\Views\Home\saveasync.cshtml"
                               Write(Html.DisplayNameFor(model => model.SInterestRate));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                                </div>\r\n                                <div class=\"col\">\r\n                                    ");
#nullable restore
#line 44 "C:\Users\win10\source\repos\ProjectBanking\ProjectBanking\Views\Home\saveasync.cshtml"
                               Write(Html.DisplayNameFor(model => model.STotal));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                        <div>\r\n                            <div class=\"row\">\r\n                                <div class=\"col-4\">\r\n");
#nullable restore
#line 51 "C:\Users\win10\source\repos\ProjectBanking\ProjectBanking\Views\Home\saveasync.cshtml"
                                     foreach (var item in ViewBag.orderRate)
                                    {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                                        <div class=\"row\">\r\n                                            <div class=\"col\">\r\n                                                ");
#nullable restore
#line 55 "C:\Users\win10\source\repos\ProjectBanking\ProjectBanking\Views\Home\saveasync.cshtml"
                                           Write(item.BankName);

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                                            </div>\r\n                                            <div class=\"col\">\r\n                                                ");
#nullable restore
#line 58 "C:\Users\win10\source\repos\ProjectBanking\ProjectBanking\Views\Home\saveasync.cshtml"
                                           Write(item.BankInterestRate);

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                                            </div>\r\n                                        </div>\r\n");
#nullable restore
#line 61 "C:\Users\win10\source\repos\ProjectBanking\ProjectBanking\Views\Home\saveasync.cshtml"
                                    }

#line default
#line hidden
#nullable disable
                    WriteLiteral("                                </div>\r\n                                <div class=\"col-8\">\r\n");
#nullable restore
#line 64 "C:\Users\win10\source\repos\ProjectBanking\ProjectBanking\Views\Home\saveasync.cshtml"
                                     foreach (var i in ViewBag.SaveRank)
                                    {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                                        <div class=\"row\">\r\n                                            <div class=\"col\">\r\n                                                ");
#nullable restore
#line 68 "C:\Users\win10\source\repos\ProjectBanking\ProjectBanking\Views\Home\saveasync.cshtml"
                                           Write(i.STerm);

#line default
#line hidden
#nullable disable
                    WriteLiteral(" เดือน\r\n                                            </div>\r\n                                            <div class=\"col\">\r\n                                                ");
#nullable restore
#line 71 "C:\Users\win10\source\repos\ProjectBanking\ProjectBanking\Views\Home\saveasync.cshtml"
                                           Write(i.SEarlyDeposit);

#line default
#line hidden
#nullable disable
                    WriteLiteral(" บาท\r\n                                            </div>\r\n                                            <div class=\"col\">\r\n                                                ");
#nullable restore
#line 74 "C:\Users\win10\source\repos\ProjectBanking\ProjectBanking\Views\Home\saveasync.cshtml"
                                           Write(i.SRate);

#line default
#line hidden
#nullable disable
                    WriteLiteral(" บาท\r\n                                            </div>\r\n                                            <div class=\"col\">\r\n                                                ");
#nullable restore
#line 77 "C:\Users\win10\source\repos\ProjectBanking\ProjectBanking\Views\Home\saveasync.cshtml"
                                           Write(i.STotal);

#line default
#line hidden
#nullable disable
                    WriteLiteral(" บาท\r\n                                            </div>\r\n                                        </div>\r\n");
#nullable restore
#line 80 "C:\Users\win10\source\repos\ProjectBanking\ProjectBanking\Views\Home\saveasync.cshtml"
                                    }

#line default
#line hidden
#nullable disable
                    WriteLiteral("                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "66f06edf665fa184158eacb48ac59be780d9b76915962", async() => {
                WriteLiteral("Back to List");
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
            WriteLiteral("\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 93 "C:\Users\win10\source\repos\ProjectBanking\ProjectBanking\Views\Home\saveasync.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjectBanking.Models.Savings> Html { get; private set; }
    }
}
#pragma warning restore 1591
