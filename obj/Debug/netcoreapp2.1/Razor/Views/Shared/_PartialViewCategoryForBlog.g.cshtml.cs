#pragma checksum "C:\Users\onur.bilgin\Desktop\Yazılım\Projects\mizgindogan2.1\mizgindogancom\Views\Shared\_PartialViewCategoryForBlog.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b2a8ffbe21037ec718243db438145dff2765d2d7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__PartialViewCategoryForBlog), @"mvc.1.0.view", @"/Views/Shared/_PartialViewCategoryForBlog.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_PartialViewCategoryForBlog.cshtml", typeof(AspNetCore.Views_Shared__PartialViewCategoryForBlog))]
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
#line 3 "C:\Users\onur.bilgin\Desktop\Yazılım\Projects\mizgindogan2.1\mizgindogancom\Views\Shared\_PartialViewCategoryForBlog.cshtml"
using System.Globalization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b2a8ffbe21037ec718243db438145dff2765d2d7", @"/Views/Shared/_PartialViewCategoryForBlog.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"654b27a368c08f73bde7e0fd72303ba619d019ef", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__PartialViewCategoryForBlog : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<mizgindogancom.ViewModels.BlogViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CategoryFilter", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(81, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "C:\Users\onur.bilgin\Desktop\Yazılım\Projects\mizgindogan2.1\mizgindogancom\Views\Shared\_PartialViewCategoryForBlog.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(110, 74, true);
            WriteLiteral("<div class=\"cate-box\">\r\n    <h4 class=\"title\">Kategoriler</h4>\r\n    <ul>\r\n");
            EndContext();
#line 11 "C:\Users\onur.bilgin\Desktop\Yazılım\Projects\mizgindogan2.1\mizgindogancom\Views\Shared\_PartialViewCategoryForBlog.cshtml"
         foreach (var item in Model.EntriesAll.Select(x => x.Category).Distinct())
        {

#line default
#line hidden
            BeginContext(279, 104, true);
            WriteLiteral("            <li>\r\n                <i class=\"fa fa-angle-right\" aria-hidden=\"true\"></i>\r\n                ");
            EndContext();
            BeginContext(383, 200, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b08182289cd44e18a137ff972cc2b357", async() => {
                BeginContext(441, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(464, 4, false);
#line 16 "C:\Users\onur.bilgin\Desktop\Yazılım\Projects\mizgindogan2.1\mizgindogancom\Views\Shared\_PartialViewCategoryForBlog.cshtml"
               Write(item);

#line default
#line hidden
                EndContext();
                BeginContext(468, 29, true);
                WriteLiteral("\r\n                    <span>(");
                EndContext();
                BeginContext(498, 55, false);
#line 17 "C:\Users\onur.bilgin\Desktop\Yazılım\Projects\mizgindogan2.1\mizgindogancom\Views\Shared\_PartialViewCategoryForBlog.cshtml"
                      Write(Model.EntriesAll.Where(x => x.Category == item).Count());

#line default
#line hidden
                EndContext();
                BeginContext(553, 26, true);
                WriteLiteral(")</span>\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-category", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 15 "C:\Users\onur.bilgin\Desktop\Yazılım\Projects\mizgindogan2.1\mizgindogancom\Views\Shared\_PartialViewCategoryForBlog.cshtml"
                                                       WriteLiteral(item);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["category"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-category", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["category"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(583, 21, true);
            WriteLiteral("\r\n            </li>\r\n");
            EndContext();
#line 20 "C:\Users\onur.bilgin\Desktop\Yazılım\Projects\mizgindogan2.1\mizgindogancom\Views\Shared\_PartialViewCategoryForBlog.cshtml"
        }

#line default
#line hidden
            BeginContext(615, 39, true);
            WriteLiteral("    </ul>\r\n</div><!-- .cate-box end -->");
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