#pragma checksum "C:\Users\bolar\source\repos\StudentEvaluationSystem_Repo\StudentEvaluationSystem\Areas\Admin\Views\Sessions\Terms.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7e412b502074406c03152815d6fa67d96257bd4d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Sessions_Terms), @"mvc.1.0.view", @"/Areas/Admin/Views/Sessions/Terms.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Sessions/Terms.cshtml", typeof(AspNetCore.Areas_Admin_Views_Sessions_Terms))]
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
#line 1 "C:\Users\bolar\source\repos\StudentEvaluationSystem_Repo\StudentEvaluationSystem\Areas\Admin\Views\_ViewImports.cshtml"
using StudentEvaluationSystem;

#line default
#line hidden
#line 2 "C:\Users\bolar\source\repos\StudentEvaluationSystem_Repo\StudentEvaluationSystem\Areas\Admin\Views\_ViewImports.cshtml"
using StudentEvaluationSystem.Models;

#line default
#line hidden
#line 1 "C:\Users\bolar\source\repos\StudentEvaluationSystem_Repo\StudentEvaluationSystem\Areas\Admin\Views\Sessions\Terms.cshtml"
using StudentEvaluationSystem.Utility;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e412b502074406c03152815d6fa67d96257bd4d", @"/Areas/Admin/Views/Sessions/Terms.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01e7bcc8e6ed2284e20768f21d08d1ed407e441d", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Sessions_Terms : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SessionTerm>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SetCurrentSessionTerm", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditTerm", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("font-size:20px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(66, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\bolar\source\repos\StudentEvaluationSystem_Repo\StudentEvaluationSystem\Areas\Admin\Views\Sessions\Terms.cshtml"
  
    ViewData["Title"] = "Index";
    ViewData["Heading"] = "Terms";

#line default
#line hidden
            BeginContext(145, 540, true);
            WriteLiteral(@"
<div class=""site-section ftco-subscribe-1 site-blocks-cover pb-4"" style=""background-image: url('/images/bg_1.jpg');"">
    <div class=""container"">
        <div class=""row align-items-end"">
            <div class=""col-lg-7"">
                <h2 class=""mb-0"">Terms</h2>
                <p>Per Academic Sessions.</p>
            </div>
        </div>
    </div>
</div>



<div class=""my-5"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-6""></div>
            <div class=""col-6 text-right"">");
            EndContext();
            BeginContext(685, 116, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "701f4941baf34b87ad3b15b116519498", async() => {
                BeginContext(747, 50, true);
                WriteLiteral("<i class=\"icon-add_box\"></i>&nbsp;New Session/Term");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(801, 215, true);
            WriteLiteral("</div>\r\n        </div>\r\n        <br />\r\n        <table class=\"table table-sm table-striped\">\r\n            <thead class=\"\" style=\"background-color:#28a745;color:#fff;\">\r\n                <tr>\r\n                    <th>");
            EndContext();
            BeginContext(1017, 51, false);
#line 32 "C:\Users\bolar\source\repos\StudentEvaluationSystem_Repo\StudentEvaluationSystem\Areas\Admin\Views\Sessions\Terms.cshtml"
                   Write(Html.DisplayNameFor(m => m.FirstOrDefault().TermId));

#line default
#line hidden
            EndContext();
            BeginContext(1068, 31, true);
            WriteLiteral("</th>\r\n                    <th>");
            EndContext();
            BeginContext(1100, 54, false);
#line 33 "C:\Users\bolar\source\repos\StudentEvaluationSystem_Repo\StudentEvaluationSystem\Areas\Admin\Views\Sessions\Terms.cshtml"
                   Write(Html.DisplayNameFor(m => m.FirstOrDefault().SessionId));

#line default
#line hidden
            EndContext();
            BeginContext(1154, 31, true);
            WriteLiteral("</th>\r\n                    <th>");
            EndContext();
            BeginContext(1186, 54, false);
#line 34 "C:\Users\bolar\source\repos\StudentEvaluationSystem_Repo\StudentEvaluationSystem\Areas\Admin\Views\Sessions\Terms.cshtml"
                   Write(Html.DisplayNameFor(m => m.FirstOrDefault().IsCurrent));

#line default
#line hidden
            EndContext();
            BeginContext(1240, 104, true);
            WriteLiteral("</th>\r\n                    <th></th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
            EndContext();
#line 39 "C:\Users\bolar\source\repos\StudentEvaluationSystem_Repo\StudentEvaluationSystem\Areas\Admin\Views\Sessions\Terms.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(1409, 54, true);
            WriteLiteral("                    <tr>\r\n                        <td>");
            EndContext();
            BeginContext(1464, 14, false);
#line 42 "C:\Users\bolar\source\repos\StudentEvaluationSystem_Repo\StudentEvaluationSystem\Areas\Admin\Views\Sessions\Terms.cshtml"
                       Write(item.Term.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1478, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1514, 17, false);
#line 43 "C:\Users\bolar\source\repos\StudentEvaluationSystem_Repo\StudentEvaluationSystem\Areas\Admin\Views\Sessions\Terms.cshtml"
                       Write(item.Session.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1531, 37, true);
            WriteLiteral("</td>\r\n                        <td>\r\n");
            EndContext();
#line 45 "C:\Users\bolar\source\repos\StudentEvaluationSystem_Repo\StudentEvaluationSystem\Areas\Admin\Views\Sessions\Terms.cshtml"
                              if (item.IsCurrent)
                                {

#line default
#line hidden
            BeginContext(1654, 76, true);
            WriteLiteral("                                    <i class=\"icon-check btn-success\"></i>\r\n");
            EndContext();
#line 48 "C:\Users\bolar\source\repos\StudentEvaluationSystem_Repo\StudentEvaluationSystem\Areas\Admin\Views\Sessions\Terms.cshtml"
                                }
                            

#line default
#line hidden
            BeginContext(1796, 167, true);
            WriteLiteral("                        </td>\r\n                        <td>\r\n                            <div class=\"btn-group\" style=\"float:right;\">\r\n                                ");
            EndContext();
            BeginContext(1963, 150, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "20e725fe96484eb9993b1445bd1e44a4", async() => {
                BeginContext(2060, 49, true);
                WriteLiteral("<i class=\"icon-more\" style=\"font-size:20px;\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 53 "C:\Users\bolar\source\repos\StudentEvaluationSystem_Repo\StudentEvaluationSystem\Areas\Admin\Views\Sessions\Terms.cshtml"
                                                                                   WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2113, 96, true);
            WriteLiteral("\r\n                            </div>\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 57 "C:\Users\bolar\source\repos\StudentEvaluationSystem_Repo\StudentEvaluationSystem\Areas\Admin\Views\Sessions\Terms.cshtml"
                }

#line default
#line hidden
            BeginContext(2228, 62, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2307, 111, true);
                WriteLiteral("\r\n\r\n    <script>\r\n    $(document).ready(function () {\r\n        $(\".table\").DataTable();\r\n\r\n        var info = \"");
                EndContext();
                BeginContext(2419, 40, false);
#line 69 "C:\Users\bolar\source\repos\StudentEvaluationSystem_Repo\StudentEvaluationSystem\Areas\Admin\Views\Sessions\Terms.cshtml"
               Write(TempData["SessionTermSaved"]?.ToString());

#line default
#line hidden
                EndContext();
                BeginContext(2459, 27, true);
                WriteLiteral("\";\r\n\r\n        if (info == \"");
                EndContext();
                BeginContext(2487, 14, false);
#line 71 "C:\Users\bolar\source\repos\StudentEvaluationSystem_Repo\StudentEvaluationSystem\Areas\Admin\Views\Sessions\Terms.cshtml"
                Write(Constant.Saved);

#line default
#line hidden
                EndContext();
                BeginContext(2501, 14, true);
                WriteLiteral("\" || info == \"");
                EndContext();
                BeginContext(2516, 16, false);
#line 71 "C:\Users\bolar\source\repos\StudentEvaluationSystem_Repo\StudentEvaluationSystem\Areas\Admin\Views\Sessions\Terms.cshtml"
                                             Write(Constant.Updated);

#line default
#line hidden
                EndContext();
                BeginContext(2532, 106, true);
                WriteLiteral("\") {\r\n            toastr.success(\"Term \" + info + \" Successfully\");\r\n        }\r\n\r\n    });\r\n    </script>\r\n");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<SessionTerm>> Html { get; private set; }
    }
}
#pragma warning restore 1591
