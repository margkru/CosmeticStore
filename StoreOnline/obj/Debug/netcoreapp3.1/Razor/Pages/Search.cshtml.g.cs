#pragma checksum "C:\Users\krule\OneDrive\Рабочий стол\KrulevaMM\StoreOnline\Pages\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c56858c5836ffecffc932c112dcef8cd7c0e67ec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Search), @"mvc.1.0.razor-page", @"/Pages/Search.cshtml")]
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
#line 2 "C:\Users\krule\OneDrive\Рабочий стол\KrulevaMM\StoreOnline\Pages\Search.cshtml"
using StoreOnline.Services;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c56858c5836ffecffc932c112dcef8cd7c0e67ec", @"/Pages/Search.cshtml")]
    public class Pages_Search : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
#line 4 "C:\Users\krule\OneDrive\Рабочий стол\KrulevaMM\StoreOnline\Pages\Search.cshtml"
  
    Layout = "~/Pages/_MasterPage.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Результаты поиска</h1>\r\n\r\n");
#nullable restore
#line 10 "C:\Users\krule\OneDrive\Рабочий стол\KrulevaMM\StoreOnline\Pages\Search.cshtml"
 if(Model.Articles.Count == 0) {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <p class=\"notfound\">Ничего не найдено</p>");
#nullable restore
#line 10 "C:\Users\krule\OneDrive\Рабочий стол\KrulevaMM\StoreOnline\Pages\Search.cshtml"
                                                                          }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"catalog\">\r\n");
#nullable restore
#line 13 "C:\Users\krule\OneDrive\Рабочий стол\KrulevaMM\StoreOnline\Pages\Search.cshtml"
     foreach (ProductInfo product in Model.Articles)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"products\">\r\n\r\n            <p >");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c56858c5836ffecffc932c112dcef8cd7c0e67ec4532", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 380, "~/img/", 380, 6, true);
#nullable restore
#line 17 "C:\Users\krule\OneDrive\Рабочий стол\KrulevaMM\StoreOnline\Pages\Search.cshtml"
AddHtmlAttributeValue("", 386, product.Id, 386, 13, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 399, ".jpg", 399, 4, true);
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
            WriteLiteral("</p>\r\n            <div class=\"product-list\">\r\n                <div class=\"inner\">\r\n                    <header>\r\n                        <h2><a");
            BeginWriteAttribute("href", " href=\"", 575, "\"", 605, 2);
            WriteAttributeValue("", 582, "/Article?id=", 582, 12, true);
#nullable restore
#line 21 "C:\Users\krule\OneDrive\Рабочий стол\KrulevaMM\StoreOnline\Pages\Search.cshtml"
WriteAttributeValue("", 594, product.Id, 594, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 21 "C:\Users\krule\OneDrive\Рабочий стол\KrulevaMM\StoreOnline\Pages\Search.cshtml"
                                                         Write(product.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h2>\r\n                    </header>\r\n                    <p>");
#nullable restore
#line 23 "C:\Users\krule\OneDrive\Рабочий стол\KrulevaMM\StoreOnline\Pages\Search.cshtml"
                  Write(product.Announce);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <div class=\"price\">");
#nullable restore
#line 24 "C:\Users\krule\OneDrive\Рабочий стол\KrulevaMM\StoreOnline\Pages\Search.cshtml"
                                  Write(product.Cost);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ₽</div>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 793, "\"", 800, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"button\">В корзину</a>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 29 "C:\Users\krule\OneDrive\Рабочий стол\KrulevaMM\StoreOnline\Pages\Search.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StoreOnline.Pages.SearchModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<StoreOnline.Pages.SearchModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<StoreOnline.Pages.SearchModel>)PageContext?.ViewData;
        public StoreOnline.Pages.SearchModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
