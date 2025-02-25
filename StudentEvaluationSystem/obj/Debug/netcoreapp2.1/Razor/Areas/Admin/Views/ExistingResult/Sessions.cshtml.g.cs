#pragma checksum "C:\Users\bolar\source\repos\StudentEvaluationSystem_Repo\StudentEvaluationSystem\Areas\Admin\Views\ExistingResult\Sessions.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9f8725490ae8d5615b2b3326a921267f22db6fc5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_ExistingResult_Sessions), @"mvc.1.0.view", @"/Areas/Admin/Views/ExistingResult/Sessions.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/ExistingResult/Sessions.cshtml", typeof(AspNetCore.Areas_Admin_Views_ExistingResult_Sessions))]
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
#line 1 "C:\Users\bolar\source\repos\StudentEvaluationSystem_Repo\StudentEvaluationSystem\Areas\Admin\Views\ExistingResult\Sessions.cshtml"
using StudentEvaluationSystem.Utility;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f8725490ae8d5615b2b3326a921267f22db6fc5", @"/Areas/Admin/Views/ExistingResult/Sessions.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01e7bcc8e6ed2284e20768f21d08d1ed407e441d", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_ExistingResult_Sessions : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Session>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Session_Classes", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("font-size:20px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(62, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\bolar\source\repos\StudentEvaluationSystem_Repo\StudentEvaluationSystem\Areas\Admin\Views\ExistingResult\Sessions.cshtml"
  
    ViewData["Title"] = "Index";
    ViewData["Heading"] = "Sessions";

#line default
#line hidden
            BeginContext(144, 630, true);
            WriteLiteral(@"
<div class=""site-section ftco-subscribe-1 site-blocks-cover pb-4"" style=""background-image: url('/images/bg_1.jpg');"">
    <div class=""container"">
        <div class=""row align-items-end"">
            <div class=""col-lg-7"">
                <h2 class=""mb-0"">Sessions</h2>
                <p>Academic sessions.</p>
            </div>
        </div>
    </div>
</div>



<div class=""site-section"">
    <div class=""container"">
        <br />
        <table class=""table table-sm table-striped"">
            <thead class="""" style=""background-color:#28a745;color:#fff;"">
                <tr>
                    <th>");
            EndContext();
            BeginContext(775, 49, false);
#line 28 "C:\Users\bolar\source\repos\StudentEvaluationSystem_Repo\StudentEvaluationSystem\Areas\Admin\Views\ExistingResult\Sessions.cshtml"
                   Write(Html.DisplayNameFor(m => m.FirstOrDefault().Name));

#line default
#line hidden
            EndContext();
            BeginContext(824, 146, true);
            WriteLiteral("</th>\r\n                    <th>Is Current?</th>\r\n                    <th></th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
            EndContext();
#line 34 "C:\Users\bolar\source\repos\StudentEvaluationSystem_Repo\StudentEvaluationSystem\Areas\Admin\Views\ExistingResult\Sessions.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(1035, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(1082, 9, false);
#line 37 "C:\Users\bolar\source\repos\StudentEvaluationSystem_Repo\StudentEvaluationSystem\Areas\Admin\Views\ExistingResult\Sessions.cshtml"
                   Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1091, 33, true);
            WriteLiteral("</td>\r\n                    <td>\r\n");
            EndContext();
#line 39 "C:\Users\bolar\source\repos\StudentEvaluationSystem_Repo\StudentEvaluationSystem\Areas\Admin\Views\ExistingResult\Sessions.cshtml"
                          if (item.IsCurrent)
                                {

#line default
#line hidden
            BeginContext(1206, 68, true);
            WriteLiteral("                            <i class=\"icon-check btn-success\"></i>\r\n");
            EndContext();
#line 42 "C:\Users\bolar\source\repos\StudentEvaluationSystem_Repo\StudentEvaluationSystem\Areas\Admin\Views\ExistingResult\Sessions.cshtml"
                                }
                        

#line default
#line hidden
            BeginContext(1336, 151, true);
            WriteLiteral("                    </td>\r\n                    <td>\r\n                        <div class=\"btn-group\" style=\"float:right;\">\r\n                            ");
            EndContext();
            BeginContext(1487, 157, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5762887fb52e411f923388f028f8003c", async() => {
                BeginContext(1591, 49, true);
                WriteLiteral("<i class=\"icon-more\" style=\"font-size:20px;\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 47 "C:\Users\bolar\source\repos\StudentEvaluationSystem_Repo\StudentEvaluationSystem\Areas\Admin\Views\ExistingResult\Sessions.cshtml"
                                                                                                              WriteLiteral(item.Id);

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
            BeginContext(1644, 84, true);
            WriteLiteral("\r\n                        </div>\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 51 "C:\Users\bolar\source\repos\StudentEvaluationSystem_Repo\StudentEvaluationSystem\Areas\Admin\Views\ExistingResult\Sessions.cshtml"
                }

#line default
#line hidden
            BeginContext(1747, 64, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1828, 183, true);
                WriteLiteral("\r\n\r\n    <script>\r\n    $(document).ready(function () {\r\n        $(\".table\").DataTable({\r\n            \"aLengthMenu\": [[5, 10, 15, -1], [5, 10, 15, \"All\"]]\r\n  });\r\n\r\n        var info = \"");
                EndContext();
                BeginContext(2012, 36, false);
#line 66 "C:\Users\bolar\source\repos\StudentEvaluationSystem_Repo\StudentEvaluationSystem\Areas\Admin\Views\ExistingResult\Sessions.cshtml"
               Write(TempData["SessionSaved"]?.ToString());

#line default
#line hidden
                EndContext();
                BeginContext(2048, 27, true);
                WriteLiteral("\";\r\n\r\n        if (info == \"");
                EndContext();
                BeginContext(2076, 14, false);
#line 68 "C:\Users\bolar\source\repos\StudentEvaluationSystem_Repo\StudentEvaluationSystem\Areas\Admin\Views\ExistingResult\Sessions.cshtml"
                Write(Constant.Saved);

#line default
#line hidden
                EndContext();
                BeginContext(2090, 14, true);
                WriteLiteral("\" || info == \"");
                EndContext();
                BeginContext(2105, 16, false);
#line 68 "C:\Users\bolar\source\repos\StudentEvaluationSystem_Repo\StudentEvaluationSystem\Areas\Admin\Views\ExistingResult\Sessions.cshtml"
                                             Write(Constant.Updated);

#line default
#line hidden
                EndContext();
                BeginContext(2121, 109, true);
                WriteLiteral("\") {\r\n            toastr.success(\"Session \" + info + \" Successfully\");\r\n        }\r\n\r\n    });\r\n    </script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Session>> Html { get; private set; }
    }
}
#pragma warning restore 1591
