#pragma checksum "C:\Users\davidw4\Documents\Visual Studio 2017\Projects\BasicMVCWebsite\BasicMVCWebsite\Views\Forecast\detailedForecast.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e4e11bfef09afb0580fd04bce2dac369632dba35"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Forecast_detailedForecast), @"mvc.1.0.view", @"/Views/Forecast/detailedForecast.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Forecast/detailedForecast.cshtml", typeof(AspNetCore.Views_Forecast_detailedForecast))]
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
#line 1 "C:\Users\davidw4\Documents\Visual Studio 2017\Projects\BasicMVCWebsite\BasicMVCWebsite\Views\_ViewImports.cshtml"
using BasicMVCWebsite;

#line default
#line hidden
#line 2 "C:\Users\davidw4\Documents\Visual Studio 2017\Projects\BasicMVCWebsite\BasicMVCWebsite\Views\_ViewImports.cshtml"
using BasicMVCWebsite.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4e11bfef09afb0580fd04bce2dac369632dba35", @"/Views/Forecast/detailedForecast.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc3a66d87a037e03046cc9d9454aaa959c72796a", @"/Views/_ViewImports.cshtml")]
    public class Views_Forecast_detailedForecast : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<weather>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("body-content"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\davidw4\Documents\Visual Studio 2017\Projects\BasicMVCWebsite\BasicMVCWebsite\Views\Forecast\detailedForecast.cshtml"
  
    ViewData["Title"] = "detailedForecast";

#line default
#line hidden
            BeginContext(68, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(70, 127, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e4e11bfef09afb0580fd04bce2dac369632dba354957", async() => {
                BeginContext(76, 65, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    ");
                EndContext();
                BeginContext(141, 47, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e4e11bfef09afb0580fd04bce2dac369632dba355407", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(188, 2, true);
                WriteLiteral("\r\n");
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
            BeginContext(197, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(201, 630, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e4e11bfef09afb0580fd04bce2dac369632dba357539", async() => {
                BeginContext(228, 32, true);
                WriteLiteral("\r\n    <h2>Detailed Forecast for ");
                EndContext();
                BeginContext(261, 17, false);
#line 12 "C:\Users\davidw4\Documents\Visual Studio 2017\Projects\BasicMVCWebsite\BasicMVCWebsite\Views\Forecast\detailedForecast.cshtml"
                         Write(Model.currentTime);

#line default
#line hidden
                EndContext();
                BeginContext(278, 32, true);
                WriteLiteral("</h2>\r\n    <h3>The high will be ");
                EndContext();
                BeginContext(311, 21, false);
#line 13 "C:\Users\davidw4\Documents\Visual Studio 2017\Projects\BasicMVCWebsite\BasicMVCWebsite\Views\Forecast\detailedForecast.cshtml"
                    Write(Model.TemperatureHigh);

#line default
#line hidden
                EndContext();
                BeginContext(332, 4, true);
                WriteLiteral(" at ");
                EndContext();
                BeginContext(337, 25, false);
#line 13 "C:\Users\davidw4\Documents\Visual Studio 2017\Projects\BasicMVCWebsite\BasicMVCWebsite\Views\Forecast\detailedForecast.cshtml"
                                              Write(Model.TemperatureHighTime);

#line default
#line hidden
                EndContext();
                BeginContext(362, 15, true);
                WriteLiteral(" with a low of ");
                EndContext();
                BeginContext(378, 20, false);
#line 13 "C:\Users\davidw4\Documents\Visual Studio 2017\Projects\BasicMVCWebsite\BasicMVCWebsite\Views\Forecast\detailedForecast.cshtml"
                                                                                       Write(Model.TemperatureLow);

#line default
#line hidden
                EndContext();
                BeginContext(398, 13, true);
                WriteLiteral(" occuring at ");
                EndContext();
                BeginContext(412, 24, false);
#line 13 "C:\Users\davidw4\Documents\Visual Studio 2017\Projects\BasicMVCWebsite\BasicMVCWebsite\Views\Forecast\detailedForecast.cshtml"
                                                                                                                         Write(Model.TemperatureMinTime);

#line default
#line hidden
                EndContext();
                BeginContext(436, 31, true);
                WriteLiteral("</h3>\r\n    <h3>The chances for ");
                EndContext();
                BeginContext(468, 16, false);
#line 14 "C:\Users\davidw4\Documents\Visual Studio 2017\Projects\BasicMVCWebsite\BasicMVCWebsite\Views\Forecast\detailedForecast.cshtml"
                   Write(Model.PrecipType);

#line default
#line hidden
                EndContext();
                BeginContext(484, 5, true);
                WriteLiteral(" are ");
                EndContext();
                BeginContext(490, 23, false);
#line 14 "C:\Users\davidw4\Documents\Visual Studio 2017\Projects\BasicMVCWebsite\BasicMVCWebsite\Views\Forecast\detailedForecast.cshtml"
                                         Write(Model.PrecipProbability);

#line default
#line hidden
                EndContext();
                BeginContext(513, 44, true);
                WriteLiteral(" %</h3>\r\n    <h3>The max wind speed with be ");
                EndContext();
                BeginContext(558, 15, false);
#line 15 "C:\Users\davidw4\Documents\Visual Studio 2017\Projects\BasicMVCWebsite\BasicMVCWebsite\Views\Forecast\detailedForecast.cshtml"
                              Write(Model.WindSpeed);

#line default
#line hidden
                EndContext();
                BeginContext(573, 27, true);
                WriteLiteral(" blowing in a direction of ");
                EndContext();
                BeginContext(601, 17, false);
#line 15 "C:\Users\davidw4\Documents\Visual Studio 2017\Projects\BasicMVCWebsite\BasicMVCWebsite\Views\Forecast\detailedForecast.cshtml"
                                                                         Write(Model.WindBearing);

#line default
#line hidden
                EndContext();
                BeginContext(618, 8, true);
                WriteLiteral(" around ");
                EndContext();
                BeginContext(627, 18, false);
#line 15 "C:\Users\davidw4\Documents\Visual Studio 2017\Projects\BasicMVCWebsite\BasicMVCWebsite\Views\Forecast\detailedForecast.cshtml"
                                                                                                   Write(Model.WindGustTime);

#line default
#line hidden
                EndContext();
                BeginContext(645, 43, true);
                WriteLiteral("</h3>\r\n    <h3>The overall weather will be ");
                EndContext();
                BeginContext(689, 13, false);
#line 16 "C:\Users\davidw4\Documents\Visual Studio 2017\Projects\BasicMVCWebsite\BasicMVCWebsite\Views\Forecast\detailedForecast.cshtml"
                               Write(Model.Summary);

#line default
#line hidden
                EndContext();
                BeginContext(702, 15, true);
                WriteLiteral("</h3>\r\n    <h3>");
                EndContext();
                BeginContext(718, 10, false);
#line 17 "C:\Users\davidw4\Documents\Visual Studio 2017\Projects\BasicMVCWebsite\BasicMVCWebsite\Views\Forecast\detailedForecast.cshtml"
   Write(Model.Icon);

#line default
#line hidden
                EndContext();
                BeginContext(728, 15, true);
                WriteLiteral("</h3>\r\n    <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 743, "\"", 760, 1);
#line 18 "C:\Users\davidw4\Documents\Visual Studio 2017\Projects\BasicMVCWebsite\BasicMVCWebsite\Views\Forecast\detailedForecast.cshtml"
WriteAttributeValue("", 749, Model.Icon, 749, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(761, 10, true);
                WriteLiteral("/>\r\n\r\n    ");
                EndContext();
                BeginContext(772, 48, false);
#line 20 "C:\Users\davidw4\Documents\Visual Studio 2017\Projects\BasicMVCWebsite\BasicMVCWebsite\Views\Forecast\detailedForecast.cshtml"
Write(Html.Raw("~/wwwroot/images/"+@Model.Icon+".svg"));

#line default
#line hidden
                EndContext();
                BeginContext(820, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(831, 4, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<weather> Html { get; private set; }
    }
}
#pragma warning restore 1591
