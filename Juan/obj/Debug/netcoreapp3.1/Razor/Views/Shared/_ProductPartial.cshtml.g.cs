#pragma checksum "C:\Users\ASUS\Desktop\juanupdate\Juan\Views\Shared\_ProductPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "49d5e725d247634b38ff43de0e3605072afdcd21"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ProductPartial), @"mvc.1.0.view", @"/Views/Shared/_ProductPartial.cshtml")]
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
#line 1 "C:\Users\ASUS\Desktop\juanupdate\Juan\Views\_ViewImports.cshtml"
using Juan.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ASUS\Desktop\juanupdate\Juan\Views\_ViewImports.cshtml"
using Juan.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49d5e725d247634b38ff43de0e3605072afdcd21", @"/Views/Shared/_ProductPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0239b73b6cf9f5e26a578ed5f6282563c1e147e4", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ProductPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ShopProduct>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\ASUS\Desktop\juanupdate\Juan\Views\Shared\_ProductPartial.cshtml"
 foreach (var product in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-lg-4 col-sm-6\">\r\n        <!-- product grid item start -->\r\n        <div class=\"product-item mb-53\">\r\n            <div class=\"product-thumb\">\r\n                <a href=\"product-details.html\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "49d5e725d247634b38ff43de0e3605072afdcd213881", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 303, "~/assets/img/product/", 303, 21, true);
#nullable restore
#line 9 "C:\Users\ASUS\Desktop\juanupdate\Juan\Views\Shared\_ProductPartial.cshtml"
AddHtmlAttributeValue("", 324, product.Image, 324, 14, false);

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
            WriteLiteral("\r\n                </a>\r\n            </div>\r\n            <div class=\"product-content\">\r\n                <h5 class=\"product-name\">\r\n                    <a href=\"product-details.html\">");
#nullable restore
#line 14 "C:\Users\ASUS\Desktop\juanupdate\Juan\Views\Shared\_ProductPartial.cshtml"
                                              Write(product.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                </h5>\r\n                <div class=\"price-box\">\r\n                    <span class=\"price-regular\">$");
#nullable restore
#line 17 "C:\Users\ASUS\Desktop\juanupdate\Juan\Views\Shared\_ProductPartial.cshtml"
                                            Write(product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(".00</span>\r\n                    <span class=\"price-old\"><del>$");
#nullable restore
#line 18 "C:\Users\ASUS\Desktop\juanupdate\Juan\Views\Shared\_ProductPartial.cshtml"
                                             Write(product.Discount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@".00</del></span>
                </div>
                <div class=""product-action-link"">
                    <a href=""#"" data-toggle=""tooltip"" title=""Wishlist""><i class=""ion-android-favorite-outline""></i></a>
                    <a href=""#"" data-toggle=""tooltip"" title=""Add To Cart""><i class=""ion-bag""></i></a>
                    <a href=""#"" data-toggle=""modal"" data-target=""#quick_view"">
                        <span data-toggle=""tooltip""
                              title=""Quick View""><i class=""ion-ios-eye-outline""></i></span>
                    </a>
                </div>
            </div>
        </div>
        <!-- product grid item end -->
        <!-- product list item start -->
        <div class=""product-list-item mb-30"">
            <div class=""product-thumb"">
                <a href=""product-details.html"">
                    <img src=""assets/img/product/product-1.jpg"" alt=""product thumb"">
                </a>
            </div>
            <div class=""product-content-list"">
");
            WriteLiteral(@"                <h5 class=""product-name"">
                    <a href=""product-details.html"">Leather Mens Slipper</a>
                </h5>
                <div class=""price-box"">
                    <span class=""price-regular"">$80.00</span>
                    <span class=""price-old""><del>$70.00</del></span>
                </div>
                <p>
                    Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce posuere
                    metus vitae arcu imperdiet, id aliquet ante scelerisque. Sed sit amet
                    sem vitae urna fringilla tempus.
                </p>
                <div class=""product-link-2 position-static"">
                    <a href=""#"" data-toggle=""tooltip"" title=""Wishlist""><i class=""ion-android-favorite-outline""></i></a>
                    <a href=""#"" data-toggle=""tooltip"" title=""Add To Cart""><i class=""ion-bag""></i></a>
                    <a href=""#"" data-toggle=""modal"" data-target=""#quick_view"">
                        <span data-to");
            WriteLiteral("ggle=\"tooltip\"\r\n                              title=\"Quick View\"><i class=\"ion-ios-eye-outline\"></i></span>\r\n                    </a>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <!-- product list item start -->\r\n    </div>\r\n");
#nullable restore
#line 63 "C:\Users\ASUS\Desktop\juanupdate\Juan\Views\Shared\_ProductPartial.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ShopProduct>> Html { get; private set; }
    }
}
#pragma warning restore 1591
