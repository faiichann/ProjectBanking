#pragma checksum "C:\Users\win10\source\repos\ProjectBanking\ProjectBanking\Views\Home\cal2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b4d52ed654d388cdc0edafcfb19e75a3e581662b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_cal2), @"mvc.1.0.view", @"/Views/Home/cal2.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4d52ed654d388cdc0edafcfb19e75a3e581662b", @"/Views/Home/cal2.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"836032e52e80d6e35594ba437c40b281933943cc", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_cal2 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjectBanking.Models.FixedDeposit>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/bank3.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Card image cap"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/bank1.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/bank2.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/circlebank1.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/circlebank3.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/circlebank2.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b4d52ed654d388cdc0edafcfb19e75a3e581662b6074", async() => {
                WriteLiteral(@"

    <section class=""table-cal"">
        <div class=""container"">
            <div class=""text-cal"">
                <h1 class=""textbanner"">
                    ตารางเปรียบเทียบอัตราดอกเบี้ย
                </h1>
            </div>
            <div asp-action=""cal2"">
                <table class=""table"">
                    <thead>
                        <tr>
                            <th scope=""col""></th>
                            <th scope=""col""> ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b4d52ed654d388cdc0edafcfb19e75a3e581662b6817", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</th>\r\n                            <th scope=\"col\">");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b4d52ed654d388cdc0edafcfb19e75a3e581662b8129", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</th>\r\n                            <th scope=\"col\">");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b4d52ed654d388cdc0edafcfb19e75a3e581662b9441", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td></td>
                            <td>ธนาคารกรุงศรีอยุธยา</td>
                            <td>ธนาคารไทยพาณิชย์</td>
                            <td>ธนาคารกสิกรไทย</td>
                        </tr>
                        <tr>
                            <th scope=""row"">");
#nullable restore
#line 29 "C:\Users\win10\source\repos\ProjectBanking\ProjectBanking\Views\Home\cal2.cshtml"
                                       Write(Html.DisplayNameFor(model => model.Fmoney));

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                            <td><br />");
#nullable restore
#line 30 "C:\Users\win10\source\repos\ProjectBanking\ProjectBanking\Views\Home\cal2.cshtml"
                                 Write(ViewBag.Earlyfixsavingb2);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            <td><br />");
#nullable restore
#line 31 "C:\Users\win10\source\repos\ProjectBanking\ProjectBanking\Views\Home\cal2.cshtml"
                                 Write(ViewBag.Earlyfixsavingb1);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            <td><br />");
#nullable restore
#line 32 "C:\Users\win10\source\repos\ProjectBanking\ProjectBanking\Views\Home\cal2.cshtml"
                                 Write(ViewBag.Earlyfixsavingb3);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        </tr>\r\n                        <tr>\r\n                            <th scope=\"row\">");
#nullable restore
#line 35 "C:\Users\win10\source\repos\ProjectBanking\ProjectBanking\Views\Home\cal2.cshtml"
                                       Write(Html.DisplayNameFor(model => model.Fmonth));

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                            <td><br />");
#nullable restore
#line 36 "C:\Users\win10\source\repos\ProjectBanking\ProjectBanking\Views\Home\cal2.cshtml"
                                 Write(ViewBag.Monthlyfixsavingb2);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            <td><br />");
#nullable restore
#line 37 "C:\Users\win10\source\repos\ProjectBanking\ProjectBanking\Views\Home\cal2.cshtml"
                                 Write(ViewBag.Monthlyfixsavingb1);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            <td><br />");
#nullable restore
#line 38 "C:\Users\win10\source\repos\ProjectBanking\ProjectBanking\Views\Home\cal2.cshtml"
                                 Write(ViewBag.Monthlyfixsavingb3);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        </tr>\r\n                        <tr>\r\n                            <th scope=\"row\">");
#nullable restore
#line 41 "C:\Users\win10\source\repos\ProjectBanking\ProjectBanking\Views\Home\cal2.cshtml"
                                       Write(Html.DisplayNameFor(model => model.Fday));

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                            <td><br />");
#nullable restore
#line 42 "C:\Users\win10\source\repos\ProjectBanking\ProjectBanking\Views\Home\cal2.cshtml"
                                 Write(ViewBag.Fterm);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            <td><br />");
#nullable restore
#line 43 "C:\Users\win10\source\repos\ProjectBanking\ProjectBanking\Views\Home\cal2.cshtml"
                                 Write(ViewBag.Fterm);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            <td><br />");
#nullable restore
#line 44 "C:\Users\win10\source\repos\ProjectBanking\ProjectBanking\Views\Home\cal2.cshtml"
                                 Write(ViewBag.Fterm);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        </tr>\r\n                        <tr>\r\n                            <th scope=\"row\">");
#nullable restore
#line 47 "C:\Users\win10\source\repos\ProjectBanking\ProjectBanking\Views\Home\cal2.cshtml"
                                       Write(Html.DisplayNameFor(model => model.Fsum));

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                            <td><br />");
#nullable restore
#line 48 "C:\Users\win10\source\repos\ProjectBanking\ProjectBanking\Views\Home\cal2.cshtml"
                                 Write(ViewBag.Summoneyb2);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            <td><br />");
#nullable restore
#line 49 "C:\Users\win10\source\repos\ProjectBanking\ProjectBanking\Views\Home\cal2.cshtml"
                                 Write(ViewBag.Summoneyb1);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            <td><br />");
#nullable restore
#line 50 "C:\Users\win10\source\repos\ProjectBanking\ProjectBanking\Views\Home\cal2.cshtml"
                                 Write(ViewBag.Summoneyb3);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        </tr>\r\n                        <tr>\r\n                            <th scope=\"row\">");
#nullable restore
#line 53 "C:\Users\win10\source\repos\ProjectBanking\ProjectBanking\Views\Home\cal2.cshtml"
                                       Write(Html.DisplayNameFor(model => model.FInterestRate));

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                            <td><br />");
#nullable restore
#line 54 "C:\Users\win10\source\repos\ProjectBanking\ProjectBanking\Views\Home\cal2.cshtml"
                                 Write(ViewBag.InterestRateb2);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            <td><br />");
#nullable restore
#line 55 "C:\Users\win10\source\repos\ProjectBanking\ProjectBanking\Views\Home\cal2.cshtml"
                                 Write(ViewBag.InterestRateb1);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            <td><br />");
#nullable restore
#line 56 "C:\Users\win10\source\repos\ProjectBanking\ProjectBanking\Views\Home\cal2.cshtml"
                                 Write(ViewBag.InterestRateb3);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        </tr>\r\n                        <tr>\r\n                            <th scope=\"row\">");
#nullable restore
#line 59 "C:\Users\win10\source\repos\ProjectBanking\ProjectBanking\Views\Home\cal2.cshtml"
                                       Write(Html.DisplayNameFor(model => model.FRate));

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                            <td><br />");
#nullable restore
#line 60 "C:\Users\win10\source\repos\ProjectBanking\ProjectBanking\Views\Home\cal2.cshtml"
                                 Write(ViewBag.Ratesfixsavingb2);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            <td><br />");
#nullable restore
#line 61 "C:\Users\win10\source\repos\ProjectBanking\ProjectBanking\Views\Home\cal2.cshtml"
                                 Write(ViewBag.Ratesfixsavingb1);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            <td><br />");
#nullable restore
#line 62 "C:\Users\win10\source\repos\ProjectBanking\ProjectBanking\Views\Home\cal2.cshtml"
                                 Write(ViewBag.Ratesfixsavingb3);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        </tr>\r\n                        <tr>\r\n                            <th scope=\"row\">");
#nullable restore
#line 65 "C:\Users\win10\source\repos\ProjectBanking\ProjectBanking\Views\Home\cal2.cshtml"
                                       Write(Html.DisplayNameFor(model => model.FTotal));

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                            <td><br />");
#nullable restore
#line 66 "C:\Users\win10\source\repos\ProjectBanking\ProjectBanking\Views\Home\cal2.cshtml"
                                 Write(ViewBag.Totalfixsavingb2);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            <td><br />");
#nullable restore
#line 67 "C:\Users\win10\source\repos\ProjectBanking\ProjectBanking\Views\Home\cal2.cshtml"
                                 Write(ViewBag.Totalfixsavingb1);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            <td><br />");
#nullable restore
#line 68 "C:\Users\win10\source\repos\ProjectBanking\ProjectBanking\Views\Home\cal2.cshtml"
                                 Write(ViewBag.Totalfixsavingb3);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</td>
                        </tr>

                    </tbody>
                </table>
            </div>

        </div>
    </section>
    <section class=""rank-cal"">
        <div class=""container"">
            <div class=""text-cal"">
                <h1 class=""textbanner"">
                    ผลการจัดอันดับ
                </h1>
            </div>
            <div class=""row justify-content-md-center"">
                <div class=""col-md-auto"">
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b4d52ed654d388cdc0edafcfb19e75a3e581662b20860", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                    <div class=""card"" style=""width: 10rem;"">
                        <div class=""card-body"">
                            <h1 class=""card-title"">2</h1>
                            <p>ธนาคารไทยพาณิชย์</p>
                            <center><p>");
#nullable restore
#line 91 "C:\Users\win10\source\repos\ProjectBanking\ProjectBanking\Views\Home\cal2.cshtml"
                                  Write(ViewBag.Totalfixsavingb1);

#line default
#line hidden
#nullable disable
                WriteLiteral(" บาท</p></center>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-md-auto\">\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b4d52ed654d388cdc0edafcfb19e75a3e581662b22834", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                    <div class=""card"" style=""width: 18rem;"">
                        <div class=""card-body"">
                            <h1 class=""card-title"">1</h1>
                            <p>ธนาคารกรุงศรีอยุธยา</p>
                            <center><p>");
#nullable restore
#line 101 "C:\Users\win10\source\repos\ProjectBanking\ProjectBanking\Views\Home\cal2.cshtml"
                                  Write(ViewBag.Totalfixsavingb3);

#line default
#line hidden
#nullable disable
                WriteLiteral(" บาท</p></center>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-md-auto\">\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b4d52ed654d388cdc0edafcfb19e75a3e581662b24812", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                    <div class=""card"" style=""width: 10rem;"">
                        <div class=""card-body"">
                            <h1 class=""card-title"">3</h1>
                            <p>ธนาคารกสิกรไทย</p>
                            <center><p>");
#nullable restore
#line 111 "C:\Users\win10\source\repos\ProjectBanking\ProjectBanking\Views\Home\cal2.cshtml"
                                  Write(ViewBag.Totalfixsavingb2);

#line default
#line hidden
#nullable disable
                WriteLiteral(@" บาท</p></center>
                        </div>
                    </div>
                </div>
            </div>
            <center><button style=""border:none;outline:none;"" class=""btn-cal1"" onclick=""goBack()"">กลับไปหน้าคำนวณ</button></center>
        </div>
    </section>
");
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
            WriteLiteral("\r\n");
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
