#pragma checksum "C:\Users\krule\OneDrive\Рабочий стол\KrulevaMM\StoreOnline\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e60411f141b6d0229aad49eb115148ee389321f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
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
#line 2 "C:\Users\krule\OneDrive\Рабочий стол\KrulevaMM\StoreOnline\Pages\Index.cshtml"
using StoreOnline.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\krule\OneDrive\Рабочий стол\KrulevaMM\StoreOnline\Pages\Index.cshtml"
using StoreOnline.Services;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e60411f141b6d0229aad49eb115148ee389321f", @"/Pages/Index.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("240"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("160"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "C:\Users\krule\OneDrive\Рабочий стол\KrulevaMM\StoreOnline\Pages\Index.cshtml"
  
    Layout = "~/Pages/_MasterPage.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    \r\n    <h1>Новинки недели</h1>\r\n\r\n    <div id=\"features-wrapper\">\r\n        <div class=\"container\">\r\n            <div class=\"row\">\r\n");
#nullable restore
#line 15 "C:\Users\krule\OneDrive\Рабочий стол\KrulevaMM\StoreOnline\Pages\Index.cshtml"
                 foreach (ProductInfo product in Model.Products.Take(3))
                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-4 col-12-medium products\">\r\n\r\n                        <!-- Box -->\r\n                        <section class=\"box feature\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 552, "\"", 582, 2);
            WriteAttributeValue("", 559, "/Article?id=", 559, 12, true);
#nullable restore
#line 22 "C:\Users\krule\OneDrive\Рабочий стол\KrulevaMM\StoreOnline\Pages\Index.cshtml"
WriteAttributeValue("", 571, product.Id, 571, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5e60411f141b6d0229aad49eb115148ee389321f4868", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 594, "~/img/", 594, 6, true);
#nullable restore
#line 22 "C:\Users\krule\OneDrive\Рабочий стол\KrulevaMM\StoreOnline\Pages\Index.cshtml"
AddHtmlAttributeValue("", 600, product.Id, 600, 13, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 613, ".jpg", 613, 4, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</a>\r\n                            <div class=\"inner\">\r\n                                <header>\r\n                                    <h2><a");
            BeginWriteAttribute("href", " href=\"", 785, "\"", 815, 2);
            WriteAttributeValue("", 792, "/Article?id=", 792, 12, true);
#nullable restore
#line 25 "C:\Users\krule\OneDrive\Рабочий стол\KrulevaMM\StoreOnline\Pages\Index.cshtml"
WriteAttributeValue("", 804, product.Id, 804, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 25 "C:\Users\krule\OneDrive\Рабочий стол\KrulevaMM\StoreOnline\Pages\Index.cshtml"
                                                                     Write(product.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h2>\r\n                                </header>\r\n                                <p>");
#nullable restore
#line 27 "C:\Users\krule\OneDrive\Рабочий стол\KrulevaMM\StoreOnline\Pages\Index.cshtml"
                              Write(product.Announce);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <div class=\"price\">");
#nullable restore
#line 28 "C:\Users\krule\OneDrive\Рабочий стол\KrulevaMM\StoreOnline\Pages\Index.cshtml"
                                              Write(product.Cost);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ₽</div>\r\n                            </div>\r\n                        </section>\r\n\r\n                    </div>\r\n");
#nullable restore
#line 33 "C:\Users\krule\OneDrive\Рабочий стол\KrulevaMM\StoreOnline\Pages\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
