#pragma checksum "C:\Users\onur.bilgin\Desktop\Yazılım\Projects\mizgindogan2.1\mizgindogancom\Views\Home\Team.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a8f9e02cb7e374f13b6522b2dbcb74de440e6874"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Team), @"mvc.1.0.view", @"/Views/Home/Team.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Team.cshtml", typeof(AspNetCore.Views_Home_Team))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a8f9e02cb7e374f13b6522b2dbcb74de440e6874", @"/Views/Home/Team.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"654b27a368c08f73bde7e0fd72303ba619d019ef", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Team : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<mizgindogancom.ViewModels.HomeViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_PartialViewBannerForHome", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\onur.bilgin\Desktop\Yazılım\Projects\mizgindogan2.1\mizgindogancom\Views\Home\Team.cshtml"
  
    ViewData["Title"] = "Ekibimiz | Mizgin Doğan Hukuk";

#line default
#line hidden
            BeginContext(114, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(116, 58, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "cf69df011c9248b4914d6c8fb6b77c32", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 6 "C:\Users\onur.bilgin\Desktop\Yazılım\Projects\mizgindogan2.1\mizgindogancom\Views\Home\Team.cshtml"
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
            BeginContext(174, 342, true);
            WriteLiteral(@"

<!-- Team Inner Section Start -->
<div id=""rs-team"" class=""rs-team-slider2 rs-team-slider pt-100 pb-70"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-3 col-md-6 col-sm-6 mb-30"">
                <div class=""team-item"">
                    <div class=""team-image"">
                        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 516, "\"", 556, 1);
#line 15 "C:\Users\onur.bilgin\Desktop\Yazılım\Projects\mizgindogan2.1\mizgindogancom\Views\Home\Team.cshtml"
WriteAttributeValue("", 522, Model.AllImages.ElementAt(16).Url, 522, 34, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 557, "\"", 598, 1);
#line 15 "C:\Users\onur.bilgin\Desktop\Yazılım\Projects\mizgindogan2.1\mizgindogancom\Views\Home\Team.cshtml"
WriteAttributeValue("", 563, Model.AllImages.ElementAt(16).Name, 563, 35, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(599, 161, true);
            WriteLiteral(">\r\n                        <div class=\"team-content\">\r\n                            <div class=\"text-box\">\r\n                                <a class=\"image-popup\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 760, "\"", 801, 1);
#line 18 "C:\Users\onur.bilgin\Desktop\Yazılım\Projects\mizgindogan2.1\mizgindogancom\Views\Home\Team.cshtml"
WriteAttributeValue("", 767, Model.AllImages.ElementAt(16).Url, 767, 34, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(802, 813, true);
            WriteLiteral(@"><i class=""glyph-icon flaticon-eye""></i></a>
                                <div class=""team-social"">
                                    <ul>
                                        <li><a href=""#""><i class=""fa fa-facebook""></i></a></li>
                                        <li><a href=""#""><i class=""fa fa-google-plus""></i></a></li>
                                        <li><a href=""#""><i class=""fa fa-twitter""></i></a></li>
                                        <li><a href=""#""><i class=""fa fa-pinterest-p""></i></a></li>
                                    </ul>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""dark-bg"">
                        <h4 class=""person-name""><a>");
            EndContext();
            BeginContext(1616, 34, false);
#line 31 "C:\Users\onur.bilgin\Desktop\Yazılım\Projects\mizgindogan2.1\mizgindogancom\Views\Home\Team.cshtml"
                                              Write(Model.AllImages.ElementAt(16).Name);

#line default
#line hidden
            EndContext();
            BeginContext(1650, 334, true);
            WriteLiteral(@"</a></h4>
                        <span class=""designation"">Bankruptcy Lawyer</span>
                    </div>
                </div>
            </div>
            <div class=""col-lg-3 col-md-6 col-sm-6 mb-30"">
                <div class=""team-item"">
                    <div class=""team-image"">
                        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1984, "\"", 2024, 1);
#line 39 "C:\Users\onur.bilgin\Desktop\Yazılım\Projects\mizgindogan2.1\mizgindogancom\Views\Home\Team.cshtml"
WriteAttributeValue("", 1990, Model.AllImages.ElementAt(17).Url, 1990, 34, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2025, "\"", 2066, 1);
#line 39 "C:\Users\onur.bilgin\Desktop\Yazılım\Projects\mizgindogan2.1\mizgindogancom\Views\Home\Team.cshtml"
WriteAttributeValue("", 2031, Model.AllImages.ElementAt(17).Name, 2031, 35, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2067, 161, true);
            WriteLiteral(">\r\n                        <div class=\"team-content\">\r\n                            <div class=\"text-box\">\r\n                                <a class=\"image-popup\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2228, "\"", 2269, 1);
#line 42 "C:\Users\onur.bilgin\Desktop\Yazılım\Projects\mizgindogan2.1\mizgindogancom\Views\Home\Team.cshtml"
WriteAttributeValue("", 2235, Model.AllImages.ElementAt(17).Url, 2235, 34, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2270, 813, true);
            WriteLiteral(@"><i class=""glyph-icon flaticon-eye""></i></a>
                                <div class=""team-social"">
                                    <ul>
                                        <li><a href=""#""><i class=""fa fa-facebook""></i></a></li>
                                        <li><a href=""#""><i class=""fa fa-google-plus""></i></a></li>
                                        <li><a href=""#""><i class=""fa fa-twitter""></i></a></li>
                                        <li><a href=""#""><i class=""fa fa-pinterest-p""></i></a></li>
                                    </ul>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""dark-bg"">
                        <h4 class=""person-name""><a>");
            EndContext();
            BeginContext(3084, 34, false);
#line 55 "C:\Users\onur.bilgin\Desktop\Yazılım\Projects\mizgindogan2.1\mizgindogancom\Views\Home\Team.cshtml"
                                              Write(Model.AllImages.ElementAt(17).Name);

#line default
#line hidden
            EndContext();
            BeginContext(3118, 329, true);
            WriteLiteral(@"</a></h4>
                        <span class=""designation"">Trial Lawyer</span>
                    </div>
                </div>
            </div>
            <div class=""col-lg-3 col-md-6 col-sm-6 mb-30"">
                <div class=""team-item"">
                    <div class=""team-image"">
                        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 3447, "\"", 3487, 1);
#line 63 "C:\Users\onur.bilgin\Desktop\Yazılım\Projects\mizgindogan2.1\mizgindogancom\Views\Home\Team.cshtml"
WriteAttributeValue("", 3453, Model.AllImages.ElementAt(18).Url, 3453, 34, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 3488, "\"", 3529, 1);
#line 63 "C:\Users\onur.bilgin\Desktop\Yazılım\Projects\mizgindogan2.1\mizgindogancom\Views\Home\Team.cshtml"
WriteAttributeValue("", 3494, Model.AllImages.ElementAt(18).Name, 3494, 35, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3530, 161, true);
            WriteLiteral(">\r\n                        <div class=\"team-content\">\r\n                            <div class=\"text-box\">\r\n                                <a class=\"image-popup\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3691, "\"", 3732, 1);
#line 66 "C:\Users\onur.bilgin\Desktop\Yazılım\Projects\mizgindogan2.1\mizgindogancom\Views\Home\Team.cshtml"
WriteAttributeValue("", 3698, Model.AllImages.ElementAt(18).Url, 3698, 34, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3733, 813, true);
            WriteLiteral(@"><i class=""glyph-icon flaticon-eye""></i></a>
                                <div class=""team-social"">
                                    <ul>
                                        <li><a href=""#""><i class=""fa fa-facebook""></i></a></li>
                                        <li><a href=""#""><i class=""fa fa-google-plus""></i></a></li>
                                        <li><a href=""#""><i class=""fa fa-twitter""></i></a></li>
                                        <li><a href=""#""><i class=""fa fa-pinterest-p""></i></a></li>
                                    </ul>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""dark-bg"">
                        <h4 class=""person-name""><a>");
            EndContext();
            BeginContext(4547, 34, false);
#line 79 "C:\Users\onur.bilgin\Desktop\Yazılım\Projects\mizgindogan2.1\mizgindogancom\Views\Home\Team.cshtml"
                                              Write(Model.AllImages.ElementAt(18).Name);

#line default
#line hidden
            EndContext();
            BeginContext(4581, 334, true);
            WriteLiteral(@"</a></h4>
                        <span class=""designation"">Government Lawyer</span>
                    </div>
                </div>
            </div>
            <div class=""col-lg-3 col-md-6 col-sm-6 mb-30"">
                <div class=""team-item"">
                    <div class=""team-image"">
                        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 4915, "\"", 4955, 1);
#line 87 "C:\Users\onur.bilgin\Desktop\Yazılım\Projects\mizgindogan2.1\mizgindogancom\Views\Home\Team.cshtml"
WriteAttributeValue("", 4921, Model.AllImages.ElementAt(19).Url, 4921, 34, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 4956, "\"", 4997, 1);
#line 87 "C:\Users\onur.bilgin\Desktop\Yazılım\Projects\mizgindogan2.1\mizgindogancom\Views\Home\Team.cshtml"
WriteAttributeValue("", 4962, Model.AllImages.ElementAt(19).Name, 4962, 35, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4998, 161, true);
            WriteLiteral(">\r\n                        <div class=\"team-content\">\r\n                            <div class=\"text-box\">\r\n                                <a class=\"image-popup\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 5159, "\"", 5200, 1);
#line 90 "C:\Users\onur.bilgin\Desktop\Yazılım\Projects\mizgindogan2.1\mizgindogancom\Views\Home\Team.cshtml"
WriteAttributeValue("", 5166, Model.AllImages.ElementAt(19).Url, 5166, 34, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5201, 813, true);
            WriteLiteral(@"><i class=""glyph-icon flaticon-eye""></i></a>
                                <div class=""team-social"">
                                    <ul>
                                        <li><a href=""#""><i class=""fa fa-facebook""></i></a></li>
                                        <li><a href=""#""><i class=""fa fa-google-plus""></i></a></li>
                                        <li><a href=""#""><i class=""fa fa-twitter""></i></a></li>
                                        <li><a href=""#""><i class=""fa fa-pinterest-p""></i></a></li>
                                    </ul>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""dark-bg"">
                        <h4 class=""person-name""><a>");
            EndContext();
            BeginContext(6015, 34, false);
#line 103 "C:\Users\onur.bilgin\Desktop\Yazılım\Projects\mizgindogan2.1\mizgindogancom\Views\Home\Team.cshtml"
                                              Write(Model.AllImages.ElementAt(19).Name);

#line default
#line hidden
            EndContext();
            BeginContext(6049, 238, true);
            WriteLiteral("</a></h4>\r\n                        <span class=\"designation\">Toxic Tort Lawyer</span>\r\n                    </div>\r\n                </div>\r\n            </div>        \r\n        </div>\r\n    </div>\r\n</div>\r\n<!-- Team Inner Section End -->    ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<mizgindogancom.ViewModels.HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
