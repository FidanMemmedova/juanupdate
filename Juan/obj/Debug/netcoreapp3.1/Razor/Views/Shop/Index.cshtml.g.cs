#pragma checksum "C:\Users\ASUS\Desktop\juanupdate\Juan\Views\Shop\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "52af07d84ecaa35395333bd750129189bb4409a2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shop_Index), @"mvc.1.0.view", @"/Views/Shop/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52af07d84ecaa35395333bd750129189bb4409a2", @"/Views/Shop/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0239b73b6cf9f5e26a578ed5f6282563c1e147e4", @"/Views/_ViewImports.cshtml")]
    public class Views_Shop_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShopViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "trending", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "sales", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "rating", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "date", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "price-asc", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ASUS\Desktop\juanupdate\Juan\Views\Shop\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- main wrapper start -->
<main>
    <!-- breadcrumb area start -->
    <div class=""breadcrumb-area bg-img"" data-bg=""assets/img/banner/breadcrumb-banner.jpg"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-12"">
                    <div class=""breadcrumb-wrap text-center"">
                        <nav aria-label=""breadcrumb"">
                            <h1 class=""breadcrumb-title"">shop</h1>
                            <ul class=""breadcrumb"">
                                <li class=""breadcrumb-item""><a href=""index.html"">Home</a></li>
                                <li class=""breadcrumb-item active"" aria-current=""page"">shop</li>
                            </ul>
                        </nav>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- breadcrumb area end -->
    <!-- page main wrapper start -->
    <div class=""shop-main-wrapper section-padding"">
        <div class=""container""");
            WriteLiteral(@">
            <div class=""row"">
                <!-- sidebar area start -->
                <div class=""col-lg-3 order-2 order-lg-1"">
                    <div class=""sidebar-wrapper"">
                        <!-- single sidebar start -->
                        <div class=""sidebar-single"">
                            <div class=""sidebar-title"">
                                <h3>Categories</h3>
                            </div>
                            <div class=""sidebar-body"">
                                <ul class=""color-list"">
                                    <li><a href=""#"">Mens <span>(10)</span></a></li>
                                    <li><a href=""#"">Womens <span>(05)</span></a></li>
                                    <li><a href=""#"">Sports <span>(15)</span></a></li>
                                    <li><a href=""#"">Fabric <span>(12)</span></a></li>
                                    <li><a href=""#"">Leather <span>(20)</span></a></li>
                                <");
            WriteLiteral(@"/ul>
                            </div>
                        </div>
                        <!-- single sidebar end -->
                        <!-- single sidebar start -->
                        <div class=""sidebar-single"">
                            <div class=""sidebar-title"">
                                <h3>filter by price</h3>
                            </div>
                            <div class=""sidebar-body"">
                                <div class=""price-range-wrap"">
                                    <div class=""price-range"" data-min=""20"" data-max=""400""></div>
                                    <div class=""range-slider"">
                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "52af07d84ecaa35395333bd750129189bb4409a28688", async() => {
                WriteLiteral(@"
                                            <div class=""price-input"">
                                                <label for=""amount"">Price: </label>
                                                <input type=""text"" id=""amount"">
                                            </div>
                                            <button class=""filter-btn"">filter</button>
                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                    </div>
                                </div>
                            </div>
                        </div>
                        <!-- single sidebar end -->
                        <!-- single sidebar start -->
                        <div class=""sidebar-single"">
                            <div class=""sidebar-title"">
                                <h3>color</h3>
                            </div>
                            <div class=""sidebar-body"">
                                <ul class=""color-list"">
                                    <li><a href=""#"">gold <span>(05)</span></a></li>
                                    <li><a href=""#"">green <span>(12)</span></a></li>
                                    <li><a href=""#"">blue <span>(14)</span></a></li>
                                    <li><a href=""#"">white <span>(20)</span></a></li>
                                    <li><a href=""#"">red <span>(08)</span></a></li>
                            ");
            WriteLiteral(@"    </ul>
                            </div>
                        </div>
                        <!-- single sidebar end -->
                        <!-- single sidebar start -->
                        <div class=""sidebar-single"">
                            <div class=""sidebar-title"">
                                <h3>size</h3>
                            </div>
                            <div class=""sidebar-body"">
                                <ul class=""size-list"">
                                    <li><a href=""#"">L <span>(05)</span></a></li>
                                    <li><a href=""#"">M <span>(06)</span></a></li>
                                    <li><a href=""#"">S <span>(02)</span></a></li>
                                    <li><a href=""#"">XL <span>(01)</span></a></li>
                                </ul>
                            </div>
                        </div>
                        <!-- single sidebar end -->
                        <!-- single sideba");
            WriteLiteral("r start -->\r\n                        <div class=\"sidebar-single\">\r\n                            <div class=\"sidebar-banner\">\r\n                                <a href=\"#\">\r\n                                    <img src=\"assets/img/banner/banner_left.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 5562, "\"", 5568, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </a>
                            </div>
                        </div>
                        <!-- single sidebar end -->
                    </div>
                </div>
                <!-- sidebar area end -->
                <!-- shop main wrapper start -->
                <div class=""col-lg-9 order-1 order-lg-2"">
                    <div class=""shop-product-wrapper"">
                        <!-- shop product top wrap start -->
                        <div class=""shop-top-bar"">
                            <div class=""row"">
                                <div class=""col-xl-5 col-lg-4 col-md-3 order-2 order-md-1"">
                                    <div class=""top-bar-left"">
                                        <div class=""product-view-mode"">
                                            <a class=""active"" href=""#"" data-target=""grid-view""><i class=""fa fa-th""></i></a>
                                            <a href=""#"" data-target=""list-view""><i cla");
            WriteLiteral(@"ss=""fa fa-list""></i></a>
                                        </div>
                                    </div>
                                </div>
                                <div class=""col-xl-7 col-lg-8 col-md-9 order-1 order-md-2"">
                                    <div class=""top-bar-right"">
                                        <div class=""product-short"">
                                            <p>Sort By : </p>
                                            <select class=""nice-select"" name=""sortby"">
                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "52af07d84ecaa35395333bd750129189bb4409a214654", async() => {
                WriteLiteral("Relevance");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "52af07d84ecaa35395333bd750129189bb4409a215865", async() => {
                WriteLiteral("Name (A - Z)");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "52af07d84ecaa35395333bd750129189bb4409a217079", async() => {
                WriteLiteral("Name (Z - A)");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "52af07d84ecaa35395333bd750129189bb4409a218293", async() => {
                WriteLiteral("Price (Low &gt; High)");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "52af07d84ecaa35395333bd750129189bb4409a219516", async() => {
                WriteLiteral("Rating (Lowest)");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "52af07d84ecaa35395333bd750129189bb4409a220733", async() => {
                WriteLiteral("Model (A - Z)");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "52af07d84ecaa35395333bd750129189bb4409a221948", async() => {
                WriteLiteral("Model (Z - A)");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                            </select>
                                        </div>
                                        <div class=""product-amount"">
                                            <p>Showing 1–16 of 21 results</p>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <!-- shop product top wrap start -->
                        <!-- product item list start -->
                        <div class=""shop-product-wrap grid-view row mbn-50"">
");
#nullable restore
#line 152 "C:\Users\ASUS\Desktop\juanupdate\Juan\Views\Shop\Index.cshtml"
                             foreach (var product in Model.ShopProducts)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <div class=""col-lg-4 col-sm-6"">
                                    <!-- product grid item start -->
                                    <div class=""product-item mb-53"">
                                        <div class=""product-thumb"">
                                            <a href=""product-details.html"">
                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "52af07d84ecaa35395333bd750129189bb4409a224456", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 8966, "~/assets/img/product/", 8966, 21, true);
#nullable restore
#line 159 "C:\Users\ASUS\Desktop\juanupdate\Juan\Views\Shop\Index.cshtml"
AddHtmlAttributeValue("", 8987, product.Image, 8987, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                            </a>
                                        </div>
                                        <div class=""product-content"">
                                            <h5 class=""product-name"">
                                                <a href=""product-details.html"">");
#nullable restore
#line 164 "C:\Users\ASUS\Desktop\juanupdate\Juan\Views\Shop\Index.cshtml"
                                                                          Write(product.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                            </h5>\r\n                                            <div class=\"price-box\">\r\n                                                <span class=\"price-regular\">$");
#nullable restore
#line 167 "C:\Users\ASUS\Desktop\juanupdate\Juan\Views\Shop\Index.cshtml"
                                                                        Write(product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(".00</span>\r\n                                                <span class=\"price-old\"><del>$");
#nullable restore
#line 168 "C:\Users\ASUS\Desktop\juanupdate\Juan\Views\Shop\Index.cshtml"
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
                   ");
            WriteLiteral(@"                 <!-- product list item start -->
                                    <div class=""product-list-item mb-30"">
                                        <div class=""product-thumb"">
                                            <a href=""product-details.html"">
                                                <img src=""assets/img/product/product-1.jpg"" alt=""product thumb"">
                                            </a>
                                        </div>
                                        <div class=""product-content-list"">
                                            <h5 class=""product-name"">
                                                <a href=""product-details.html"">Leather Mens Slipper</a>
                                            </h5>
                                            <div class=""price-box"">
                                                <span class=""price-regular"">$80.00</span>
                                                <span class=""price-old""><del>");
            WriteLiteral(@"$70.00</del></span>
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
                                                    <");
            WriteLiteral(@"span data-toggle=""tooltip""
                                                          title=""Quick View""><i class=""ion-ios-eye-outline""></i></span>
                                                </a>
                                            </div>
                                        </div>
                                    </div>
                                    <!-- product list item start -->
                                </div>
");
#nullable restore
#line 213 "C:\Users\ASUS\Desktop\juanupdate\Juan\Views\Shop\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </div>
                        <!-- product item list end -->
                        <!-- start pagination area -->
                        <div class=""paginatoin-area text-center mt-45"">
                            <ul class=""pagination-box"">
                                <li><a class=""Previous"" href=""#""><i class=""ion-ios-arrow-left""></i></a></li>
                                <li class=""active""><a href=""#"">1</a></li>
                                <li><a href=""#"">2</a></li>
                                <li><a href=""#"">3</a></li>
                                <li><a class=""Next"" href=""#""><i class=""ion-ios-arrow-right""></i></a></li>
                            </ul>
                        </div>
                        <!-- end pagination area -->
                    </div>
                </div>
                <!-- shop main wrapper end -->
            </div>
        </div>
    </div>
    <!-- page main wrapper end -->
</main>
<!-- main wrapper end --");
            WriteLiteral(@">
<!-- Quick view modal start -->
<div class=""modal"" id=""quick_view"">
    <div class=""modal-dialog modal-lg modal-dialog-centered"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
            </div>
            <div class=""modal-body"">
                <!-- product details inner end -->
                <div class=""product-details-inner"">
                    <div class=""row"">
                        <div class=""col-lg-5"">
                            <div class=""product-large-slider mb-20"">
                                <div class=""pro-large-img img-zoom"">
                                    <img src=""assets/img/product/product-details-img1.jpg"" alt=""product thumb"" />
                                </div>
                                <div class=""pro-large-img img-zoom"">
                                    <img src=""assets/img/product/product-details-img2.jpg"" alt=""product t");
            WriteLiteral(@"humb"" />
                                </div>
                                <div class=""pro-large-img img-zoom"">
                                    <img src=""assets/img/product/product-details-img3.jpg"" alt=""product thumb"" />
                                </div>
                                <div class=""pro-large-img img-zoom"">
                                    <img src=""assets/img/product/product-details-img4.jpg"" alt=""product thumb"" />
                                </div>
                            </div>
                            <div class=""pro-nav slick-row-5"">
                                <div class=""pro-nav-thumb""><img src=""assets/img/product/product-details-img1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 15995, "\"", 16001, 0);
            EndWriteAttribute();
            WriteLiteral(" /></div>\r\n                                <div class=\"pro-nav-thumb\"><img src=\"assets/img/product/product-details-img2.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 16126, "\"", 16132, 0);
            EndWriteAttribute();
            WriteLiteral(" /></div>\r\n                                <div class=\"pro-nav-thumb\"><img src=\"assets/img/product/product-details-img3.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 16257, "\"", 16263, 0);
            EndWriteAttribute();
            WriteLiteral(" /></div>\r\n                                <div class=\"pro-nav-thumb\"><img src=\"assets/img/product/product-details-img4.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 16388, "\"", 16394, 0);
            EndWriteAttribute();
            WriteLiteral(@" /></div>
                            </div>
                        </div>
                        <div class=""col-lg-7"">
                            <div class=""product-details-des"">
                                <h3 class=""pro-det-title"">Primitive Mens Premium Shoes</h3>
                                <div class=""pro-review"">
                                    <span><a href=""#"">1 Review(s)</a></span>
                                </div>
                                <div class=""price-box"">
                                    <span class=""regular-price"">$70.00</span>
                                    <span class=""old-price""><del>$80.00</del></span>
                                </div>
                                <p>Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua.</p>
                                <div class=""quantity-cart-box d-flex align-items-center mb-20"">
          ");
            WriteLiteral(@"                          <div class=""quantity"">
                                        <div class=""pro-qty""><input type=""text"" value=""1""></div>
                                    </div>
                                    <a href=""cart.html"" class=""btn btn-default"">Add To Cart</a>
                                </div>
                                <div class=""availability mb-20"">
                                    <h5 class=""cat-title"">Availability:</h5>
                                    <span>In Stock</span>
                                </div>
                                <div class=""share-icon"">
                                    <h5 class=""cat-title"">Share:</h5>
                                    <a href=""#""><i class=""fa fa-facebook""></i></a>
                                    <a href=""#""><i class=""fa fa-twitter""></i></a>
                                    <a href=""#""><i class=""fa fa-pinterest""></i></a>
                                    <a href=""#""><i class=""fa fa-google-");
            WriteLiteral(@"plus""></i></a>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <!-- product details inner end -->
            </div>
        </div>
    </div>
</div>
<!-- Quick view modal end -->
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShopViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
