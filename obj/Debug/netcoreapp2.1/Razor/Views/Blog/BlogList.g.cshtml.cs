#pragma checksum "C:\Users\onur.bilgin\Desktop\Yazılım\Projects\mizgindogan2.1\mizgindogancom\Views\Blog\BlogList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7a9dc1255312218297d13985b049f69f6d2f4fdf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_BlogList), @"mvc.1.0.view", @"/Views/Blog/BlogList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Blog/BlogList.cshtml", typeof(AspNetCore.Views_Blog_BlogList))]
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
#line 1 "C:\Users\onur.bilgin\Desktop\Yazılım\Projects\mizgindogan2.1\mizgindogancom\Views\_ViewImports.cshtml"
using mizgindogancom;

#line default
#line hidden
#line 2 "C:\Users\onur.bilgin\Desktop\Yazılım\Projects\mizgindogan2.1\mizgindogancom\Views\_ViewImports.cshtml"
using mizgindogancom.Models;

#line default
#line hidden
#line 2 "C:\Users\onur.bilgin\Desktop\Yazılım\Projects\mizgindogan2.1\mizgindogancom\Views\Blog\BlogList.cshtml"
using System.Globalization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a9dc1255312218297d13985b049f69f6d2f4fdf", @"/Views/Blog/BlogList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"654b27a368c08f73bde7e0fd72303ba619d019ef", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_BlogList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<mizgindogancom.ViewModels.BlogViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_PartialViewBannerForBlog", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("blog-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("blog-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_PartialViewSearchInBlog", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_PartialViewCategoryForBlog", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_PartialViewRecentForBlog", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_PartialViewTagsForBlog", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Sakura.AspNetCore.Mvc.TagHelpers.PagerTagHelper __Sakura_AspNetCore_Mvc_TagHelpers_PagerTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(79, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\onur.bilgin\Desktop\Yazılım\Projects\mizgindogan2.1\mizgindogancom\Views\Blog\BlogList.cshtml"
  
    ViewData["Title"] = "Yazılarımız | Mizgin Doğan Hukuk";

#line default
#line hidden
            BeginContext(149, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(151, 58, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ac03372f8d2b4d1aa37a3e6d60bf3753", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 8 "C:\Users\onur.bilgin\Desktop\Yazılım\Projects\mizgindogan2.1\mizgindogancom\Views\Blog\BlogList.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(209, 223, true);
            WriteLiteral("\r\n<!-- Blog Section Start -->\r\n<div id=\"rs-blog\" class=\"rs-blog pt-100 pb-100\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-lg-8 pr-25 mb-md-50\">\r\n                <div class=\"row\">\r\n");
            EndContext();
#line 15 "C:\Users\onur.bilgin\Desktop\Yazılım\Projects\mizgindogan2.1\mizgindogancom\Views\Blog\BlogList.cshtml"
                     if (Model.EntriesPaging.Count != 0)
                    {
                        

#line default
#line hidden
#line 17 "C:\Users\onur.bilgin\Desktop\Yazılım\Projects\mizgindogan2.1\mizgindogancom\Views\Blog\BlogList.cshtml"
                         foreach (var blogItem in Model.EntriesPaging)
                        {
                            DateTime dateRecent = Convert.ToDateTime(blogItem.Date);

#line default
#line hidden
            BeginContext(698, 251, true);
            WriteLiteral("                            <div class=\"col-sm-6 mb-50\">\r\n                                <div class=\"blog-item\">\r\n                                  \r\n                                    <div class=\"blog-img\">\r\n                                        ");
            EndContext();
            BeginContext(949, 297, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c46b4a217593400982dd48665e2f4c0d", async() => {
                BeginContext(1044, 104, true);
                WriteLiteral("\r\n                                                \r\n                                                <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 1148, "\"", 1175, 1);
#line 26 "C:\Users\onur.bilgin\Desktop\Yazılım\Projects\mizgindogan2.1\mizgindogancom\Views\Blog\BlogList.cshtml"
WriteAttributeValue("", 1154, blogItem.ImageUrlMed, 1154, 21, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 1176, "\"", 1198, 1);
#line 26 "C:\Users\onur.bilgin\Desktop\Yazılım\Projects\mizgindogan2.1\mizgindogancom\Views\Blog\BlogList.cshtml"
WriteAttributeValue("", 1182, blogItem.Header, 1182, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1199, 43, true);
                WriteLiteral(">\r\n                                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 24 "C:\Users\onur.bilgin\Desktop\Yazılım\Projects\mizgindogan2.1\mizgindogancom\Views\Blog\BlogList.cshtml"
                                                                                    WriteLiteral(blogItem.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "title", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 24 "C:\Users\onur.bilgin\Desktop\Yazılım\Projects\mizgindogan2.1\mizgindogancom\Views\Blog\BlogList.cshtml"
AddHtmlAttributeValue("", 1026, blogItem.Header, 1026, 16, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1246, 106, true);
            WriteLiteral("\r\n                                        <div class=\"date\">\r\n                                            ");
            EndContext();
            BeginContext(1353, 129, false);
#line 29 "C:\Users\onur.bilgin\Desktop\Yazılım\Projects\mizgindogan2.1\mizgindogancom\Views\Blog\BlogList.cshtml"
                                       Write(dateRecent.ToString("dd MMMMM yyyy",
                                                CultureInfo.CreateSpecificCulture("tr-TR")));

#line default
#line hidden
            EndContext();
            BeginContext(1482, 287, true);
            WriteLiteral(@"
                                        </div>
                                    </div>
                                    <div class=""content-wrapper"">
                                        <div class=""blog-meta border-style"">
                                            <h4>");
            EndContext();
            BeginContext(1769, 72, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "54ad56ec4f49480b9b709a405047e065", async() => {
                BeginContext(1822, 15, false);
#line 35 "C:\Users\onur.bilgin\Desktop\Yazılım\Projects\mizgindogan2.1\mizgindogancom\Views\Blog\BlogList.cshtml"
                                                                                               Write(blogItem.Header);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 35 "C:\Users\onur.bilgin\Desktop\Yazılım\Projects\mizgindogan2.1\mizgindogancom\Views\Blog\BlogList.cshtml"
                                                                          WriteLiteral(blogItem.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1841, 187, true);
            WriteLiteral("</h4>\r\n                                            <h6>\r\n                                                <i class=\"fa fa-book\"></i>\r\n                                                <span>");
            EndContext();
            BeginContext(2029, 17, false);
#line 38 "C:\Users\onur.bilgin\Desktop\Yazılım\Projects\mizgindogan2.1\mizgindogancom\Views\Blog\BlogList.cshtml"
                                                 Write(blogItem.ReadTime);

#line default
#line hidden
            EndContext();
            BeginContext(2046, 180, true);
            WriteLiteral("&nbsp;dakika</span>\r\n                                            </h6>\r\n                                            <ul>\r\n                                                <li><span>");
            EndContext();
            BeginContext(2227, 17, false);
#line 41 "C:\Users\onur.bilgin\Desktop\Yazılım\Projects\mizgindogan2.1\mizgindogancom\Views\Blog\BlogList.cshtml"
                                                     Write(blogItem.PostedBy);

#line default
#line hidden
            EndContext();
            BeginContext(2244, 72, true);
            WriteLiteral("</span></li>\r\n                                                <li><span>");
            EndContext();
            BeginContext(2317, 17, false);
#line 42 "C:\Users\onur.bilgin\Desktop\Yazılım\Projects\mizgindogan2.1\mizgindogancom\Views\Blog\BlogList.cshtml"
                                                     Write(blogItem.Category);

#line default
#line hidden
            EndContext();
            BeginContext(2334, 226, true);
            WriteLiteral(" </span></li>\r\n                                            </ul>\r\n                                        </div>\r\n                                        <div class=\"blog-desc\">\r\n                                            <p>");
            EndContext();
            BeginContext(2561, 39, false);
#line 46 "C:\Users\onur.bilgin\Desktop\Yazılım\Projects\mizgindogan2.1\mizgindogancom\Views\Blog\BlogList.cshtml"
                                          Write(blogItem.EntrySummary.Substring(0, 200));

#line default
#line hidden
            EndContext();
            BeginContext(2600, 97, true);
            WriteLiteral("...</p>\r\n                                        </div>\r\n                                        ");
            EndContext();
            BeginContext(2697, 95, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7f8b82e8d1704e2490dae19aa9a4b251", async() => {
                BeginContext(2766, 22, true);
                WriteLiteral("Devamı için tıklayınız");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 48 "C:\Users\onur.bilgin\Desktop\Yazılım\Projects\mizgindogan2.1\mizgindogancom\Views\Blog\BlogList.cshtml"
                                                                  WriteLiteral(blogItem.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2792, 122, true);
            WriteLiteral("\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
            EndContext();
#line 52 "C:\Users\onur.bilgin\Desktop\Yazılım\Projects\mizgindogan2.1\mizgindogancom\Views\Blog\BlogList.cshtml"
                        }

#line default
#line hidden
#line 52 "C:\Users\onur.bilgin\Desktop\Yazılım\Projects\mizgindogan2.1\mizgindogancom\Views\Blog\BlogList.cshtml"
                         
                    } else
                    {

#line default
#line hidden
            BeginContext(2992, 168, true);
            WriteLiteral("                        <div class=\"col-sm-12 mb-50 text-center\">\r\n                            <h3>Aradığınız Sonuç Bulunamadı...</h3>\r\n                        </div>\r\n");
            EndContext();
#line 58 "C:\Users\onur.bilgin\Desktop\Yazılım\Projects\mizgindogan2.1\mizgindogancom\Views\Blog\BlogList.cshtml"
                    }

#line default
#line hidden
            BeginContext(3183, 50, true);
            WriteLiteral("\r\n\r\n                </div>\r\n    \r\n                ");
            EndContext();
            BeginContext(3233, 39, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("pager", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "86a90f6f15a34a44b9d62daf4ae5e97a", async() => {
            }
            );
            __Sakura_AspNetCore_Mvc_TagHelpers_PagerTagHelper = CreateTagHelper<global::Sakura.AspNetCore.Mvc.TagHelpers.PagerTagHelper>();
            __tagHelperExecutionContext.Add(__Sakura_AspNetCore_Mvc_TagHelpers_PagerTagHelper);
#line 63 "C:\Users\onur.bilgin\Desktop\Yazılım\Projects\mizgindogan2.1\mizgindogancom\Views\Blog\BlogList.cshtml"
__Sakura_AspNetCore_Mvc_TagHelpers_PagerTagHelper.Source = Model.EntriesPaging;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("source", __Sakura_AspNetCore_Mvc_TagHelpers_PagerTagHelper.Source, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3272, 130, true);
            WriteLiteral("\r\n\r\n            </div>\r\n            <div class=\"col-lg-4 pl-25\">\r\n                <div class=\"sidebar-area\">\r\n                    ");
            EndContext();
            BeginContext(3402, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "565ba4e2faf54061908e9d3b0f1f8a2b", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
#line 68 "C:\Users\onur.bilgin\Desktop\Yazılım\Projects\mizgindogan2.1\mizgindogancom\Views\Blog\BlogList.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3459, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(3481, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c11818a691394d89a520c9cf196f99a0", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
#line 69 "C:\Users\onur.bilgin\Desktop\Yazılım\Projects\mizgindogan2.1\mizgindogancom\Views\Blog\BlogList.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3541, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(3563, 58, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3dfa0158fc6548e48cd32d02cf8e7a2f", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
#line 70 "C:\Users\onur.bilgin\Desktop\Yazılım\Projects\mizgindogan2.1\mizgindogancom\Views\Blog\BlogList.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3621, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(3643, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d2484741547a422fb72acd445f6179cc", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
#line 71 "C:\Users\onur.bilgin\Desktop\Yazılım\Projects\mizgindogan2.1\mizgindogancom\Views\Blog\BlogList.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3699, 111, true);
            WriteLiteral("  \r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<!-- Blog Section End -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<mizgindogancom.ViewModels.BlogViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591