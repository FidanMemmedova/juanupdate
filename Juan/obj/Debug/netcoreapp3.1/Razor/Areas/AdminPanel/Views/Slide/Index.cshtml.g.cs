#pragma checksum "C:\Users\ASUS\Desktop\juanupdate\Juan\Areas\AdminPanel\Views\Slide\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ce7adddf606b14c2db6bf8c7f60f147d11478aa1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdminPanel_Views_Slide_Index), @"mvc.1.0.view", @"/Areas/AdminPanel/Views/Slide/Index.cshtml")]
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
#line 1 "C:\Users\ASUS\Desktop\juanupdate\Juan\Areas\AdminPanel\Views\_ViewImports.cshtml"
using Juan.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ASUS\Desktop\juanupdate\Juan\Areas\AdminPanel\Views\_ViewImports.cshtml"
using Juan.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce7adddf606b14c2db6bf8c7f60f147d11478aa1", @"/Areas/AdminPanel/Views/Slide/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"73038b0597ab6104ea4efc8d60ed3968d508060b", @"/Areas/AdminPanel/Views/_ViewImports.cshtml")]
    public class Areas_AdminPanel_Views_Slide_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Slide>>
    {
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
#line 2 "C:\Users\ASUS\Desktop\juanupdate\Juan\Areas\AdminPanel\Views\Slide\Index.cshtml"
  
    ViewData["Title"] = "Index";
    int count = 1;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-lg-12 grid-margin stretch-card"">
        <div class=""card"">
            <div class=""card-body"">
                <h4 class=""card-title"">Sliders</h4>
                <a class=""btn btn-success"" asp-action=""Create"">Create Slidery</a>
                <div class=""table-responsive pt-3"">
                    <table class=""table table-dark"">
                        <thead>
                            <tr>
                                <th>
                                    #
                                </th>
                                <th>
                                    Image
                                </th>
                                <th>
                                    Settings
                                </th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 29 "C:\Users\ASUS\Desktop\juanupdate\Juan\Areas\AdminPanel\Views\Slide\Index.cshtml"
                             foreach (var image in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 33 "C:\Users\ASUS\Desktop\juanupdate\Juan\Areas\AdminPanel\Views\Slide\Index.cshtml"
                                   Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ce7adddf606b14c2db6bf8c7f60f147d11478aa15115", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1352, "~/img/", 1352, 6, true);
#nullable restore
#line 36 "C:\Users\ASUS\Desktop\juanupdate\Juan\Areas\AdminPanel\Views\Slide\Index.cshtml"
AddHtmlAttributeValue("", 1358, image.Image, 1358, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        <a class=\"btn btn-sm btn-danger\" asp-action=\"Delete\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1552, "\"", 1576, 1);
#nullable restore
#line 39 "C:\Users\ASUS\Desktop\juanupdate\Juan\Areas\AdminPanel\Views\Slide\Index.cshtml"
WriteAttributeValue("", 1567, image.Id, 1567, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            <i class=\"mdi mdi-delete-forever\"></i>\r\n                                        </a>\r\n                                        <a class=\"btn btn-sm btn-warning\" asp-action=\"Update\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1803, "\"", 1827, 1);
#nullable restore
#line 42 "C:\Users\ASUS\Desktop\juanupdate\Juan\Areas\AdminPanel\Views\Slide\Index.cshtml"
WriteAttributeValue("", 1818, image.Id, 1818, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            <i class=\"mdi mdi-border-color\"></i>\r\n                                        </a>\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 47 "C:\Users\ASUS\Desktop\juanupdate\Juan\Areas\AdminPanel\Views\Slide\Index.cshtml"
                                count++;
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Slide>> Html { get; private set; }
    }
}
#pragma warning restore 1591
