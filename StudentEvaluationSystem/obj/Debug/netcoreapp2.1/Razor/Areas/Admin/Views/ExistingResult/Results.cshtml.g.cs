#pragma checksum "C:\Users\bolar\source\repos\StudentEvaluationSystem\StudentEvaluationSystem\Areas\Admin\Views\ExistingResult\Results.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4b168afa91d2003e76e0b204dc5f270093729efd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_ExistingResult_Results), @"mvc.1.0.view", @"/Areas/Admin/Views/ExistingResult/Results.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/ExistingResult/Results.cshtml", typeof(AspNetCore.Areas_Admin_Views_ExistingResult_Results))]
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
#line 1 "C:\Users\bolar\source\repos\StudentEvaluationSystem\StudentEvaluationSystem\Areas\Admin\Views\ExistingResult\Results.cshtml"
using StudentEvaluationSystem.Utility;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b168afa91d2003e76e0b204dc5f270093729efd", @"/Areas/Admin/Views/ExistingResult/Results.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01e7bcc8e6ed2284e20768f21d08d1ed407e441d", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_ExistingResult_Results : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Result>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary d-print-none"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Result", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/school_logo.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:15%;height:15%;margin-left:40%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(61, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\bolar\source\repos\StudentEvaluationSystem\StudentEvaluationSystem\Areas\Admin\Views\ExistingResult\Results.cshtml"
  
    ViewData["Title"] = "Index";
    ViewData["Heading"] = "Classes";

#line default
#line hidden
            BeginContext(142, 440, true);
            WriteLiteral(@"
<div class=""site-section ftco-subscribe-1 site-blocks-cover pb-4 d-print-none"" style=""background-image: url('/images/bg_1.jpg');"">
    <div class=""container"">
        <div class=""row align-items-end"">
            <div class=""col-lg-7"">
                <h2 class=""mb-0"">Student Result</h2>
                <p></p>
            </div>
        </div>
    </div>
</div>



<div class=""site-section"">
    <div class=""container"">
");
            EndContext();
#line 24 "C:\Users\bolar\source\repos\StudentEvaluationSystem\StudentEvaluationSystem\Areas\Admin\Views\ExistingResult\Results.cshtml"
         if (Model.Count() > 0)
        {

#line default
#line hidden
            BeginContext(626, 66, true);
            WriteLiteral("        <div class=\"row\">\r\n            <div class=\"col-6\"></div>\r\n");
            EndContext();
#line 28 "C:\Users\bolar\source\repos\StudentEvaluationSystem\StudentEvaluationSystem\Areas\Admin\Views\ExistingResult\Results.cshtml"
             if (User.IsInRole(Constant.AdminUser) || User.IsInRole(Constant.RegularUser))
            {

#line default
#line hidden
            BeginContext(799, 46, true);
            WriteLiteral("                <div class=\"col-3 text-right\">");
            EndContext();
            BeginContext(845, 127, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "72361e25ffb44f1ea2366813455f0534", async() => {
                BeginContext(928, 40, true);
                WriteLiteral("<i class=\"icon-edit\"></i>&nbsp;Edit Mode");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(972, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
#line 31 "C:\Users\bolar\source\repos\StudentEvaluationSystem\StudentEvaluationSystem\Areas\Admin\Views\ExistingResult\Results.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(1028, 54, true);
            WriteLiteral("                <div class=\"col-3 text-right\"></div>\r\n");
            EndContext();
#line 35 "C:\Users\bolar\source\repos\StudentEvaluationSystem\StudentEvaluationSystem\Areas\Admin\Views\ExistingResult\Results.cshtml"
            }

#line default
#line hidden
            BeginContext(1097, 185, true);
            WriteLiteral("\r\n            <div class=\"col-3 text-right\"><button class=\"btn btn-primary d-print-none\" onclick=\"Print()\"><i class=\"icon-print\"></i>&nbsp;Print</button></div>\r\n        </div>\r\n        ");
            EndContext();
            BeginContext(1282, 83, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "189d876708214f22bc103caf5b199e00", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1365, 112, true);
            WriteLiteral("\r\n        <h4 class=\"text-center\">Offa Grammar School</h4>\r\n        <br />\r\n            <h6 class=\"text-center\">");
            EndContext();
            BeginContext(1478, 47, false);
#line 42 "C:\Users\bolar\source\repos\StudentEvaluationSystem\StudentEvaluationSystem\Areas\Admin\Views\ExistingResult\Results.cshtml"
                               Write(Model.FirstOrDefault().SessionTerm.Session.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1525, 264, true);
            WriteLiteral(@" Academic Result</h6>
            <table class=""table table-sm table-bordered"" border='0' cellpadding='0' cellspacing='0' align='center' style=""width:50%; margin-left:25%;"">
                <tr>
                    <td>Reg Number:</td>
                    <td>");
            EndContext();
            BeginContext(1790, 49, false);
#line 46 "C:\Users\bolar\source\repos\StudentEvaluationSystem\StudentEvaluationSystem\Areas\Admin\Views\ExistingResult\Results.cshtml"
                   Write(Model.FirstOrDefault().Student.RegistrationNumber);

#line default
#line hidden
            EndContext();
            BeginContext(1839, 91, true);
            WriteLiteral("</td>\r\n                    <td rowspan=\'5\' style=\"width:25%\">\r\n                        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1930, "\"", 1973, 1);
#line 48 "C:\Users\bolar\source\repos\StudentEvaluationSystem\StudentEvaluationSystem\Areas\Admin\Views\ExistingResult\Results.cshtml"
WriteAttributeValue("", 1936, Model.FirstOrDefault().Student.Photo, 1936, 37, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1974, 167, true);
            WriteLiteral(" style=\"height:30%;width:100%\" />\r\n                    </td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Name:</td>\r\n                    <td>");
            EndContext();
            BeginContext(2142, 39, false);
#line 53 "C:\Users\bolar\source\repos\StudentEvaluationSystem\StudentEvaluationSystem\Areas\Admin\Views\ExistingResult\Results.cshtml"
                   Write(Model.FirstOrDefault().Student.FullName);

#line default
#line hidden
            EndContext();
            BeginContext(2181, 113, true);
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Class:</td>\r\n                    <td>");
            EndContext();
            BeginContext(2295, 33, false);
#line 57 "C:\Users\bolar\source\repos\StudentEvaluationSystem\StudentEvaluationSystem\Areas\Admin\Views\ExistingResult\Results.cshtml"
                   Write(Model.FirstOrDefault().Class.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2328, 111, true);
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Sex:</td>\r\n                    <td>");
            EndContext();
            BeginContext(2440, 34, false);
#line 61 "C:\Users\bolar\source\repos\StudentEvaluationSystem\StudentEvaluationSystem\Areas\Admin\Views\ExistingResult\Results.cshtml"
                   Write(Model.FirstOrDefault().Student.Sex);

#line default
#line hidden
            EndContext();
            BeginContext(2474, 121, true);
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Year of Entry:</td>\r\n                    <td>");
            EndContext();
            BeginContext(2596, 42, false);
#line 65 "C:\Users\bolar\source\repos\StudentEvaluationSystem\StudentEvaluationSystem\Areas\Admin\Views\ExistingResult\Results.cshtml"
                   Write(Model.FirstOrDefault().Student.YearOfEntry);

#line default
#line hidden
            EndContext();
            BeginContext(2638, 341, true);
            WriteLiteral(@"</td>
                </tr>
            </table>
            <table class=""table table-sm table-bordered"" border='0' cellpadding='0' cellspacing='0' align='center' style=""width:90%; margin-left:5%;"">
                <thead class=""text-center text-black bg-transparent"">
                    <tr>
                        <th colspan=""5"">");
            EndContext();
            BeginContext(2980, 47, false);
#line 71 "C:\Users\bolar\source\repos\StudentEvaluationSystem\StudentEvaluationSystem\Areas\Admin\Views\ExistingResult\Results.cshtml"
                                   Write(Model.FirstOrDefault().SessionTerm.Session.Name);

#line default
#line hidden
            EndContext();
            BeginContext(3027, 2, true);
            WriteLiteral(" (");
            EndContext();
            BeginContext(3030, 44, false);
#line 71 "C:\Users\bolar\source\repos\StudentEvaluationSystem\StudentEvaluationSystem\Areas\Admin\Views\ExistingResult\Results.cshtml"
                                                                                     Write(Model.FirstOrDefault().SessionTerm.Term.Name);

#line default
#line hidden
            EndContext();
            BeginContext(3074, 326, true);
            WriteLiteral(@")</th>
                    </tr>
                    <tr>
                        <th>Subject</th>
                        <th>Test Score</th>
                        <th>Exam Score</th>
                        <th>Total</th>
                        <th>Grade</th>
                    </tr>
                </thead>
");
            EndContext();
#line 81 "C:\Users\bolar\source\repos\StudentEvaluationSystem\StudentEvaluationSystem\Areas\Admin\Views\ExistingResult\Results.cshtml"
                   var totalScore = 0.0; var count = 0;

#line default
#line hidden
            BeginContext(3458, 25, true);
            WriteLiteral("                <tbody>\r\n");
            EndContext();
#line 83 "C:\Users\bolar\source\repos\StudentEvaluationSystem\StudentEvaluationSystem\Areas\Admin\Views\ExistingResult\Results.cshtml"
                     foreach (var item in Model)
                    {
                        totalScore += item.Total;
                        count++;

#line default
#line hidden
            BeginContext(3641, 62, true);
            WriteLiteral("                        <tr>\r\n                            <td>");
            EndContext();
            BeginContext(3704, 17, false);
#line 88 "C:\Users\bolar\source\repos\StudentEvaluationSystem\StudentEvaluationSystem\Areas\Admin\Views\ExistingResult\Results.cshtml"
                           Write(item.Subject.Name);

#line default
#line hidden
            EndContext();
            BeginContext(3721, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(3761, 14, false);
#line 89 "C:\Users\bolar\source\repos\StudentEvaluationSystem\StudentEvaluationSystem\Areas\Admin\Views\ExistingResult\Results.cshtml"
                           Write(item.TestScore);

#line default
#line hidden
            EndContext();
            BeginContext(3775, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(3815, 14, false);
#line 90 "C:\Users\bolar\source\repos\StudentEvaluationSystem\StudentEvaluationSystem\Areas\Admin\Views\ExistingResult\Results.cshtml"
                           Write(item.ExamScore);

#line default
#line hidden
            EndContext();
            BeginContext(3829, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(3869, 10, false);
#line 91 "C:\Users\bolar\source\repos\StudentEvaluationSystem\StudentEvaluationSystem\Areas\Admin\Views\ExistingResult\Results.cshtml"
                           Write(item.Total);

#line default
#line hidden
            EndContext();
            BeginContext(3879, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(3919, 10, false);
#line 92 "C:\Users\bolar\source\repos\StudentEvaluationSystem\StudentEvaluationSystem\Areas\Admin\Views\ExistingResult\Results.cshtml"
                           Write(item.Grade);

#line default
#line hidden
            EndContext();
            BeginContext(3929, 38, true);
            WriteLiteral("</td>\r\n                        </tr>\r\n");
            EndContext();
#line 94 "C:\Users\bolar\source\repos\StudentEvaluationSystem\StudentEvaluationSystem\Areas\Admin\Views\ExistingResult\Results.cshtml"
                    }

#line default
#line hidden
            BeginContext(3990, 291, true);
            WriteLiteral(@"                </tbody>
                <tfoot>
                    <tr>
                        <td></td>
                        <td></td>
                        <td colspan=""2"" class=""font-weight-bold"">Total: </td>
                        <td colspan=""1"" class=""font-weight-bold"">");
            EndContext();
            BeginContext(4282, 10, false);
#line 101 "C:\Users\bolar\source\repos\StudentEvaluationSystem\StudentEvaluationSystem\Areas\Admin\Views\ExistingResult\Results.cshtml"
                                                            Write(totalScore);

#line default
#line hidden
            EndContext();
            BeginContext(4292, 95, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td></td>\r\n");
            EndContext();
#line 105 "C:\Users\bolar\source\repos\StudentEvaluationSystem\StudentEvaluationSystem\Areas\Admin\Views\ExistingResult\Results.cshtml"
                           var average = ((int)totalScore / count);

#line default
#line hidden
            BeginContext(4457, 181, true);
            WriteLiteral("                        <td></td>\r\n                        <td colspan=\"2\" class=\"font-weight-bold\">Average: </td>\r\n                        <td colspan=\"1\" class=\"font-weight-bold\">");
            EndContext();
            BeginContext(4639, 7, false);
#line 108 "C:\Users\bolar\source\repos\StudentEvaluationSystem\StudentEvaluationSystem\Areas\Admin\Views\ExistingResult\Results.cshtml"
                                                            Write(average);

#line default
#line hidden
            EndContext();
            BeginContext(4646, 83, true);
            WriteLiteral("%</td>\r\n                    </tr>\r\n                </tfoot>\r\n            </table>\r\n");
            EndContext();
#line 112 "C:\Users\bolar\source\repos\StudentEvaluationSystem\StudentEvaluationSystem\Areas\Admin\Views\ExistingResult\Results.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(4765, 125, true);
            WriteLiteral("            <div style=\"border:2px dashed #555; padding:5%\"><p class=\"text-center\">No Student Currently Available</p></div>\r\n");
            EndContext();
#line 116 "C:\Users\bolar\source\repos\StudentEvaluationSystem\StudentEvaluationSystem\Areas\Admin\Views\ExistingResult\Results.cshtml"
        }

#line default
#line hidden
            BeginContext(4901, 22, true);
            WriteLiteral("    </div>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(4940, 79, true);
                WriteLiteral("\r\n\r\n    <script>\r\n    $(document).ready(function () {\r\n\r\n\r\n        var info = \"");
                EndContext();
                BeginContext(5020, 34, false);
#line 126 "C:\Users\bolar\source\repos\StudentEvaluationSystem\StudentEvaluationSystem\Areas\Admin\Views\ExistingResult\Results.cshtml"
               Write(TempData["ClassSaved"]?.ToString());

#line default
#line hidden
                EndContext();
                BeginContext(5054, 27, true);
                WriteLiteral("\";\r\n\r\n        if (info == \"");
                EndContext();
                BeginContext(5082, 14, false);
#line 128 "C:\Users\bolar\source\repos\StudentEvaluationSystem\StudentEvaluationSystem\Areas\Admin\Views\ExistingResult\Results.cshtml"
                Write(Constant.Saved);

#line default
#line hidden
                EndContext();
                BeginContext(5096, 14, true);
                WriteLiteral("\" || info == \"");
                EndContext();
                BeginContext(5111, 16, false);
#line 128 "C:\Users\bolar\source\repos\StudentEvaluationSystem\StudentEvaluationSystem\Areas\Admin\Views\ExistingResult\Results.cshtml"
                                             Write(Constant.Updated);

#line default
#line hidden
                EndContext();
                BeginContext(5127, 165, true);
                WriteLiteral("\") {\r\n            toastr.success(\"Class \" + info + \" Successfully\");\r\n        }\r\n\r\n    });\r\n\r\n    function Print() {\r\n        window.print();\r\n    }\r\n    </script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Result>> Html { get; private set; }
    }
}
#pragma warning restore 1591
