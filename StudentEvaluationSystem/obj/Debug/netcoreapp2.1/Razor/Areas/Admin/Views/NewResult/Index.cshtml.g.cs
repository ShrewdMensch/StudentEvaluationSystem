#pragma checksum "C:\Users\bolar\source\repos\StudentEvaluationSystem\StudentEvaluationSystem\Areas\Admin\Views\NewResult\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ba2682a997704cf88cc1139c6bac23329cd4363e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_NewResult_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/NewResult/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/NewResult/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_NewResult_Index))]
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
#line 1 "C:\Users\bolar\source\repos\StudentEvaluationSystem\StudentEvaluationSystem\Areas\Admin\Views\_ViewImports.cshtml"
using StudentEvaluationSystem;

#line default
#line hidden
#line 2 "C:\Users\bolar\source\repos\StudentEvaluationSystem\StudentEvaluationSystem\Areas\Admin\Views\_ViewImports.cshtml"
using StudentEvaluationSystem.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba2682a997704cf88cc1139c6bac23329cd4363e", @"/Areas/Admin/Views/NewResult/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01e7bcc8e6ed2284e20768f21d08d1ed407e441d", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_NewResult_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Subject>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Classes", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(29, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\bolar\source\repos\StudentEvaluationSystem\StudentEvaluationSystem\Areas\Admin\Views\NewResult\Index.cshtml"
  
    ViewData["Title"] = "Index";
    ViewData["Heading"] = "Subjects";

#line default
#line hidden
            BeginContext(111, 433, true);
            WriteLiteral(@"
<div class=""site-section ftco-subscribe-1 site-blocks-cover pb-4"" style=""background-image: url('/images/bg_1.jpg');"">
    <div class=""container"">
        <div class=""row align-items-end"">
            <div class=""col-lg-7"">
                <h2 class=""mb-0"">Subjects</h2>
                <p>Taught By Me</p>
            </div>
        </div>
    </div>
</div>



<div class=""site-section"">
    <div class=""container"">
");
            EndContext();
#line 23 "C:\Users\bolar\source\repos\StudentEvaluationSystem\StudentEvaluationSystem\Areas\Admin\Views\NewResult\Index.cshtml"
         if (Model.ToList().Count > 0)
        {

#line default
#line hidden
            BeginContext(595, 212, true);
            WriteLiteral("            <table class=\"table table-sm table-striped\" id=\"subjects\">\r\n                <thead class=\"table-primary\">\r\n                    <tr>\r\n                        <th>Name</th>\r\n                        <th>");
            EndContext();
            BeginContext(808, 54, false);
#line 29 "C:\Users\bolar\source\repos\StudentEvaluationSystem\StudentEvaluationSystem\Areas\Admin\Views\NewResult\Index.cshtml"
                       Write(Html.DisplayNameFor(m => m.FirstOrDefault().TeacherId));

#line default
#line hidden
            EndContext();
            BeginContext(862, 35, true);
            WriteLiteral("</th>\r\n                        <th>");
            EndContext();
            BeginContext(898, 58, false);
#line 30 "C:\Users\bolar\source\repos\StudentEvaluationSystem\StudentEvaluationSystem\Areas\Admin\Views\NewResult\Index.cshtml"
                       Write(Html.DisplayNameFor(m => m.FirstOrDefault().SubjectTypeId));

#line default
#line hidden
            EndContext();
            BeginContext(956, 120, true);
            WriteLiteral("</th>\r\n                        <th></th>\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
            EndContext();
#line 35 "C:\Users\bolar\source\repos\StudentEvaluationSystem\StudentEvaluationSystem\Areas\Admin\Views\NewResult\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
            BeginContext(1149, 62, true);
            WriteLiteral("                        <tr>\r\n                            <td>");
            EndContext();
            BeginContext(1212, 9, false);
#line 38 "C:\Users\bolar\source\repos\StudentEvaluationSystem\StudentEvaluationSystem\Areas\Admin\Views\NewResult\Index.cshtml"
                           Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1221, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1261, 21, false);
#line 39 "C:\Users\bolar\source\repos\StudentEvaluationSystem\StudentEvaluationSystem\Areas\Admin\Views\NewResult\Index.cshtml"
                           Write(item.Teacher.FullName);

#line default
#line hidden
            EndContext();
            BeginContext(1282, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1322, 21, false);
#line 40 "C:\Users\bolar\source\repos\StudentEvaluationSystem\StudentEvaluationSystem\Areas\Admin\Views\NewResult\Index.cshtml"
                           Write(item.SubjectType.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1343, 155, true);
            WriteLiteral("</td>\r\n                            <td>\r\n                                <div class=\"btn-group\" style=\"float:right;\">\r\n                                    ");
            EndContext();
            BeginContext(1498, 149, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3311698999ea4128bf9eb493150c305a", async() => {
                BeginContext(1594, 49, true);
                WriteLiteral("<i class=\"icon-more\" style=\"font-size:20px;\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 43 "C:\Users\bolar\source\repos\StudentEvaluationSystem\StudentEvaluationSystem\Areas\Admin\Views\NewResult\Index.cshtml"
                                                                                      WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1647, 108, true);
            WriteLiteral("\r\n                                </div>\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 47 "C:\Users\bolar\source\repos\StudentEvaluationSystem\StudentEvaluationSystem\Areas\Admin\Views\NewResult\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(1778, 48, true);
            WriteLiteral("                </tbody>\r\n            </table>\r\n");
            EndContext();
#line 50 "C:\Users\bolar\source\repos\StudentEvaluationSystem\StudentEvaluationSystem\Areas\Admin\Views\NewResult\Index.cshtml"
        }

        else
        {

#line default
#line hidden
            BeginContext(1864, 176, true);
            WriteLiteral("            <div style=\"border:2px dashed #555; padding:5%\"><p class=\"text-center\">You do not currently teach any subject or current  Session/Term has not been set.</p></div>\r\n");
            EndContext();
#line 55 "C:\Users\bolar\source\repos\StudentEvaluationSystem\StudentEvaluationSystem\Areas\Admin\Views\NewResult\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(2051, 22, true);
            WriteLiteral("    </div>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2090, 187, true);
                WriteLiteral("\r\n    <script>\r\n    $(document).ready(function () {\r\n    $(\'#subjects\').DataTable({\r\n            \"aLengthMenu\": [[5, 10, 15, -1], [5, 10, 15, \"All\"]]\r\n  });\r\n    } );\r\n\r\n    </script>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Subject>> Html { get; private set; }
    }
}
#pragma warning restore 1591
