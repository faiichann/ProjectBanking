#pragma checksum "C:\Users\GP62M\source\repos\ProjectBanking\ProjectBanking\Views\Home\Fixed.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ecd2c9db8657bfddc7b5374a3d3e6d152e3ba1d0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Fixed), @"mvc.1.0.view", @"/Views/Home/Fixed.cshtml")]
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
#line 1 "C:\Users\GP62M\source\repos\ProjectBanking\ProjectBanking\Views\_ViewImports.cshtml"
using ProjectBanking;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\GP62M\source\repos\ProjectBanking\ProjectBanking\Views\_ViewImports.cshtml"
using ProjectBanking.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ecd2c9db8657bfddc7b5374a3d3e6d152e3ba1d0", @"/Views/Home/Fixed.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"836032e52e80d6e35594ba437c40b281933943cc", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Fixed : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjectBanking.Models.FixedDeposit>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Fixed", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CalFixed", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\GP62M\source\repos\ProjectBanking\ProjectBanking\Views\Home\Fixed.cshtml"
  
    ViewData["Title"] = "Fixed";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Fixed</h1>\r\n<div>\r\n    <p>ฝากประจำ</p>\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ecd2c9db8657bfddc7b5374a3d3e6d152e3ba1d05223", async() => {
                WriteLiteral(@"

        <span>เงินฝากต้น: </span><input step=""0.01"" type=""number"" name=""Fmoney"" /><br />
        <span>ระยะฝากต่อเดือน : </span>
        <input id=""Fday"" type=""radio"" name=""Fday"" value=""3"" /><span>  3  </span>
        <input id=""Fday"" type=""radio"" name=""Fday"" value=""6"" /><span>  6  </span>
        <input id=""Fday"" type=""radio"" name=""Fday"" value=""12"" /><span>  12  </span><br />
        <span>เงินฝากต่อเดือน : </span><input step=""0.01"" type=""number"" name=""Fmonth"" /><br />
        <input id=""cal2"" type=""submit"" value=""Calculation"" /><br />
        <hr />
        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ecd2c9db8657bfddc7b5374a3d3e6d152e3ba1d06098", async() => {
                    WriteLiteral("\r\n            <table class=\"table\">\r\n                <thead>\r\n                    <tr>\r\n                        <th>\r\n                            ");
#nullable restore
#line 28 "C:\Users\GP62M\source\repos\ProjectBanking\ProjectBanking\Views\Home\Fixed.cshtml"
                       Write(Html.DisplayNameFor(model => model.FBankName));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 31 "C:\Users\GP62M\source\repos\ProjectBanking\ProjectBanking\Views\Home\Fixed.cshtml"
                       Write(Html.DisplayNameFor(model => model.FInterestRate));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 34 "C:\Users\GP62M\source\repos\ProjectBanking\ProjectBanking\Views\Home\Fixed.cshtml"
                       Write(Html.DisplayNameFor(model => model.FTermperMonth));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 37 "C:\Users\GP62M\source\repos\ProjectBanking\ProjectBanking\Views\Home\Fixed.cshtml"
                       Write(Html.DisplayNameFor(model => model.FEarlyDeposit));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 40 "C:\Users\GP62M\source\repos\ProjectBanking\ProjectBanking\Views\Home\Fixed.cshtml"
                       Write(Html.DisplayNameFor(model => model.FMonthDeposit));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 43 "C:\Users\GP62M\source\repos\ProjectBanking\ProjectBanking\Views\Home\Fixed.cshtml"
                       Write(Html.DisplayNameFor(model => model.FRate));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 46 "C:\Users\GP62M\source\repos\ProjectBanking\ProjectBanking\Views\Home\Fixed.cshtml"
                       Write(Html.DisplayNameFor(model => model.FTotal));

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"
                        </th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>
                            กรุงศรี
                        </td>
                        <td>
                            1.1
                        </td>
                        <td>
                            ");
#nullable restore
#line 59 "C:\Users\GP62M\source\repos\ProjectBanking\ProjectBanking\Views\Home\Fixed.cshtml"
                       Write(ViewBag.Fterm);

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 62 "C:\Users\GP62M\source\repos\ProjectBanking\ProjectBanking\Views\Home\Fixed.cshtml"
                       Write(ViewBag.Earlyfixsavingb3);

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 65 "C:\Users\GP62M\source\repos\ProjectBanking\ProjectBanking\Views\Home\Fixed.cshtml"
                       Write(ViewBag.Summoneyb3);

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 68 "C:\Users\GP62M\source\repos\ProjectBanking\ProjectBanking\Views\Home\Fixed.cshtml"
                       Write(ViewBag.Ratesfixavingb3);

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 71 "C:\Users\GP62M\source\repos\ProjectBanking\ProjectBanking\Views\Home\Fixed.cshtml"
                       Write(ViewBag.Totalfixsavingb3);

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"
                        </td>
                    </tr>
                    <tr>
                        <td>
                            กสิกรไทย
                        </td>
                        <td>
                            0.865
                        </td>
                        <td>
                            ");
#nullable restore
#line 82 "C:\Users\GP62M\source\repos\ProjectBanking\ProjectBanking\Views\Home\Fixed.cshtml"
                       Write(ViewBag.Fterm);

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 85 "C:\Users\GP62M\source\repos\ProjectBanking\ProjectBanking\Views\Home\Fixed.cshtml"
                       Write(ViewBag.Earlyfixsavingb2);

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 88 "C:\Users\GP62M\source\repos\ProjectBanking\ProjectBanking\Views\Home\Fixed.cshtml"
                       Write(ViewBag.Summoneyb2);

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 91 "C:\Users\GP62M\source\repos\ProjectBanking\ProjectBanking\Views\Home\Fixed.cshtml"
                       Write(ViewBag.Ratesfixavingb2);

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 94 "C:\Users\GP62M\source\repos\ProjectBanking\ProjectBanking\Views\Home\Fixed.cshtml"
                       Write(ViewBag.Totalfixsavingb2);

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"
                        </td>
                    </tr>
                    <tr>
                        <td>
                            ไทยพาณิชย์
                        </td>
                        <td>
                            0.375
                        </td>
                        <td>
                            ");
#nullable restore
#line 105 "C:\Users\GP62M\source\repos\ProjectBanking\ProjectBanking\Views\Home\Fixed.cshtml"
                       Write(ViewBag.Fterm);

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 108 "C:\Users\GP62M\source\repos\ProjectBanking\ProjectBanking\Views\Home\Fixed.cshtml"
                       Write(ViewBag.Earlyfixsavingb1);

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 111 "C:\Users\GP62M\source\repos\ProjectBanking\ProjectBanking\Views\Home\Fixed.cshtml"
                       Write(ViewBag.Summoneyb1);

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 114 "C:\Users\GP62M\source\repos\ProjectBanking\ProjectBanking\Views\Home\Fixed.cshtml"
                       Write(ViewBag.Ratesfixavingb1);

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 117 "C:\Users\GP62M\source\repos\ProjectBanking\ProjectBanking\Views\Home\Fixed.cshtml"
                       Write(ViewBag.Totalfixsavingb1);

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n                </tbody>\r\n            </table>\r\n            <hr />\r\n        ");
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
                WriteLiteral("\r\n\r\n    ");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ecd2c9db8657bfddc7b5374a3d3e6d152e3ba1d017846", async() => {
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
#line 132 "C:\Users\GP62M\source\repos\ProjectBanking\ProjectBanking\Views\Home\Fixed.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjectBanking.Models.FixedDeposit> Html { get; private set; }
    }
}
#pragma warning restore 1591
