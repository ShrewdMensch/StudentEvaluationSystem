#pragma checksum "C:\Users\HP\Desktop\StudentEvaluationSystem\StudentEvaluationSystem\Areas\Student\Views\ExistingResult\AllResults.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d37c76b631a314651dd86fed517363071195703"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Student_Views_ExistingResult_AllResults), @"mvc.1.0.view", @"/Areas/Student/Views/ExistingResult/AllResults.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Student/Views/ExistingResult/AllResults.cshtml", typeof(AspNetCore.Areas_Student_Views_ExistingResult_AllResults))]
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
#line 1 "C:\Users\HP\Desktop\StudentEvaluationSystem\StudentEvaluationSystem\Areas\Student\Views\_ViewImports.cshtml"
using StudentEvaluationSystem;

#line default
#line hidden
#line 2 "C:\Users\HP\Desktop\StudentEvaluationSystem\StudentEvaluationSystem\Areas\Student\Views\_ViewImports.cshtml"
using StudentEvaluationSystem.Models;

#line default
#line hidden
#line 1 "C:\Users\HP\Desktop\StudentEvaluationSystem\StudentEvaluationSystem\Areas\Student\Views\ExistingResult\AllResults.cshtml"
using StudentEvaluationSystem.Utility;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d37c76b631a314651dd86fed517363071195703", @"/Areas/Student/Views/ExistingResult/AllResults.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01e7bcc8e6ed2284e20768f21d08d1ed407e441d", @"/Areas/Student/Views/_ViewImports.cshtml")]
    public class Areas_Student_Views_ExistingResult_AllResults : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<IGrouping<int, Result>>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary d-print-none"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Result", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Sessional", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/school_logo.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:30%;height:30%;margin-left:35%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(84, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\HP\Desktop\StudentEvaluationSystem\StudentEvaluationSystem\Areas\Student\Views\ExistingResult\AllResults.cshtml"
  
    ViewData["Title"] = "Index";
    ViewData["Heading"] = "Classes";

#line default
#line hidden
            BeginContext(165, 242, true);
            WriteLiteral("\r\n<div class=\"site-section ftco-subscribe-1 site-blocks-cover pb-4 d-print-none\" style=\"background-image: url(\'/images/bg_1.jpg\');\">\r\n    <div class=\"container\">\r\n        <div class=\"row align-items-end\">\r\n            <div class=\"col-lg-7\">\r\n");
            EndContext();
#line 13 "C:\Users\HP\Desktop\StudentEvaluationSystem\StudentEvaluationSystem\Areas\Student\Views\ExistingResult\AllResults.cshtml"
                 if (Model.Count() > 0)
                {

#line default
#line hidden
            BeginContext(467, 48, true);
            WriteLiteral("                    <h2 class=\"mb-0\">Results of ");
            EndContext();
            BeginContext(516, 56, false);
#line 15 "C:\Users\HP\Desktop\StudentEvaluationSystem\StudentEvaluationSystem\Areas\Student\Views\ExistingResult\AllResults.cshtml"
                                           Write(Model.FirstOrDefault().FirstOrDefault().Student.FullName);

#line default
#line hidden
            EndContext();
            BeginContext(572, 35, true);
            WriteLiteral("</h2>\r\n                    <p> For ");
            EndContext();
            BeginContext(608, 64, false);
#line 16 "C:\Users\HP\Desktop\StudentEvaluationSystem\StudentEvaluationSystem\Areas\Student\Views\ExistingResult\AllResults.cshtml"
                       Write(Model.FirstOrDefault().FirstOrDefault().SessionTerm.Session.Name);

#line default
#line hidden
            EndContext();
            BeginContext(672, 18, true);
            WriteLiteral(" (All Terms)</p>\r\n");
            EndContext();
#line 17 "C:\Users\HP\Desktop\StudentEvaluationSystem\StudentEvaluationSystem\Areas\Student\Views\ExistingResult\AllResults.cshtml"
                }

#line default
#line hidden
            BeginContext(709, 111, true);
            WriteLiteral("                </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<div class=\"my-5\">\r\n    <div class=\"container\">\r\n");
            EndContext();
#line 25 "C:\Users\HP\Desktop\StudentEvaluationSystem\StudentEvaluationSystem\Areas\Student\Views\ExistingResult\AllResults.cshtml"
         if (Model.Count() > 0)
        {
            

#line default
#line hidden
#line 27 "C:\Users\HP\Desktop\StudentEvaluationSystem\StudentEvaluationSystem\Areas\Student\Views\ExistingResult\AllResults.cshtml"
             if (User.IsInRole(Constant.AdminUser) || User.IsInRole(Constant.RegularUser))
            {

#line default
#line hidden
            BeginContext(971, 71, true);
            WriteLiteral("                <div class=\"mt-5 col-6 text-right\" style=\"float:right\">");
            EndContext();
            BeginContext(1042, 131, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "73a1b4cdab294a2fb9055d7a6fae0d30", async() => {
                BeginContext(1129, 40, true);
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
            BeginContext(1173, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
#line 30 "C:\Users\HP\Desktop\StudentEvaluationSystem\StudentEvaluationSystem\Areas\Student\Views\ExistingResult\AllResults.cshtml"
            }

#line default
#line hidden
            BeginContext(1196, 232, true);
            WriteLiteral("            <div class=\"mt-5 d-print-none\" style=\"width:20%;margin-left:40%\"><button style=\"width:100%\" class=\"btn btn-primary\" onclick=\"Print()\"><i class=\"icon-print\"></i>&nbsp;Print</button></div>\r\n            <br />\r\n            ");
            EndContext();
            BeginContext(1428, 83, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "759e867e0c594c74903bbd8773a4b1fd", async() => {
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
            BeginContext(1511, 120, true);
            WriteLiteral("\r\n            <h4 class=\"text-center\">Offa Grammar School</h4>\r\n            <br />\r\n            <h6 class=\"text-center\">");
            EndContext();
            BeginContext(1632, 64, false);
#line 36 "C:\Users\HP\Desktop\StudentEvaluationSystem\StudentEvaluationSystem\Areas\Student\Views\ExistingResult\AllResults.cshtml"
                               Write(Model.FirstOrDefault().FirstOrDefault().SessionTerm.Session.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1696, 285, true);
            WriteLiteral(@" Academic Result</h6>
            <table class=""table table-sm table-bordered"" border='0' cellpadding='0' cellspacing='0' style=""width:60%; margin-left:20%;"">
                <tr>
                    <td style=""width:10%"">Reg Number:</td>
                    <td style=""width:20%"">");
            EndContext();
            BeginContext(1982, 66, false);
#line 40 "C:\Users\HP\Desktop\StudentEvaluationSystem\StudentEvaluationSystem\Areas\Student\Views\ExistingResult\AllResults.cshtml"
                                     Write(Model.FirstOrDefault().FirstOrDefault().Student.RegistrationNumber);

#line default
#line hidden
            EndContext();
            BeginContext(2048, 103, true);
            WriteLiteral("</td>\r\n                    <td rowspan=\'5\' style=\"width:20%;height:100%\">\r\n                        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 2151, "\"", 2211, 1);
#line 42 "C:\Users\HP\Desktop\StudentEvaluationSystem\StudentEvaluationSystem\Areas\Student\Views\ExistingResult\AllResults.cshtml"
WriteAttributeValue("", 2157, Model.FirstOrDefault().FirstOrDefault().Student.Photo, 2157, 54, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2212, 156, true);
            WriteLiteral(" style=\"width:100%\" />\r\n                    </td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Name:</td>\r\n                    <td>");
            EndContext();
            BeginContext(2369, 56, false);
#line 47 "C:\Users\HP\Desktop\StudentEvaluationSystem\StudentEvaluationSystem\Areas\Student\Views\ExistingResult\AllResults.cshtml"
                   Write(Model.FirstOrDefault().FirstOrDefault().Student.FullName);

#line default
#line hidden
            EndContext();
            BeginContext(2425, 113, true);
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Class:</td>\r\n                    <td>");
            EndContext();
            BeginContext(2539, 50, false);
#line 51 "C:\Users\HP\Desktop\StudentEvaluationSystem\StudentEvaluationSystem\Areas\Student\Views\ExistingResult\AllResults.cshtml"
                   Write(Model.FirstOrDefault().FirstOrDefault().Class.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2589, 111, true);
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Sex:</td>\r\n                    <td>");
            EndContext();
            BeginContext(2701, 51, false);
#line 55 "C:\Users\HP\Desktop\StudentEvaluationSystem\StudentEvaluationSystem\Areas\Student\Views\ExistingResult\AllResults.cshtml"
                   Write(Model.FirstOrDefault().FirstOrDefault().Student.Sex);

#line default
#line hidden
            EndContext();
            BeginContext(2752, 121, true);
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Year of Entry:</td>\r\n                    <td>");
            EndContext();
            BeginContext(2874, 59, false);
#line 59 "C:\Users\HP\Desktop\StudentEvaluationSystem\StudentEvaluationSystem\Areas\Student\Views\ExistingResult\AllResults.cshtml"
                   Write(Model.FirstOrDefault().FirstOrDefault().Student.YearOfEntry);

#line default
#line hidden
            EndContext();
            BeginContext(2933, 52, true);
            WriteLiteral("</td>\r\n                </tr>\r\n            </table>\r\n");
            EndContext();
#line 62 "C:\Users\HP\Desktop\StudentEvaluationSystem\StudentEvaluationSystem\Areas\Student\Views\ExistingResult\AllResults.cshtml"
            foreach (var resultGroup in Model)
            {
                var totalScore = 0.0; var count = 0;


#line default
#line hidden
            BeginContext(3104, 339, true);
            WriteLiteral(@"                <table class=""table table-sm table-bordered"" border='0' cellpadding='0' cellspacing='0' align='center' style=""width:90%; margin-left:5%;"">
                    <thead class=""text-center text-black bg-transparent"">
                        <tr>
                            <th colspan=""5"">
                                ");
            EndContext();
            BeginContext(3444, 53, false);
#line 70 "C:\Users\HP\Desktop\StudentEvaluationSystem\StudentEvaluationSystem\Areas\Student\Views\ExistingResult\AllResults.cshtml"
                           Write(resultGroup.FirstOrDefault().SessionTerm.Session.Name);

#line default
#line hidden
            EndContext();
            BeginContext(3497, 35, true);
            WriteLiteral("\r\n                                (");
            EndContext();
            BeginContext(3533, 50, false);
#line 71 "C:\Users\HP\Desktop\StudentEvaluationSystem\StudentEvaluationSystem\Areas\Student\Views\ExistingResult\AllResults.cshtml"
                            Write(resultGroup.FirstOrDefault().SessionTerm.Term.Name);

#line default
#line hidden
            EndContext();
            BeginContext(3583, 394, true);
            WriteLiteral(@")
                            </th>
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
#line 83 "C:\Users\HP\Desktop\StudentEvaluationSystem\StudentEvaluationSystem\Areas\Student\Views\ExistingResult\AllResults.cshtml"
                     foreach (var result in resultGroup)
                    {

#line default
#line hidden
            BeginContext(4058, 33, true);
            WriteLiteral("                        <tbody>\r\n");
            EndContext();
#line 86 "C:\Users\HP\Desktop\StudentEvaluationSystem\StudentEvaluationSystem\Areas\Student\Views\ExistingResult\AllResults.cshtml"
                              totalScore += result.Total; count++;

#line default
#line hidden
            BeginContext(4160, 70, true);
            WriteLiteral("                            <tr>\r\n                                <td>");
            EndContext();
            BeginContext(4231, 19, false);
#line 88 "C:\Users\HP\Desktop\StudentEvaluationSystem\StudentEvaluationSystem\Areas\Student\Views\ExistingResult\AllResults.cshtml"
                               Write(result.Subject.Name);

#line default
#line hidden
            EndContext();
            BeginContext(4250, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(4294, 16, false);
#line 89 "C:\Users\HP\Desktop\StudentEvaluationSystem\StudentEvaluationSystem\Areas\Student\Views\ExistingResult\AllResults.cshtml"
                               Write(result.TestScore);

#line default
#line hidden
            EndContext();
            BeginContext(4310, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(4354, 16, false);
#line 90 "C:\Users\HP\Desktop\StudentEvaluationSystem\StudentEvaluationSystem\Areas\Student\Views\ExistingResult\AllResults.cshtml"
                               Write(result.ExamScore);

#line default
#line hidden
            EndContext();
            BeginContext(4370, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(4414, 12, false);
#line 91 "C:\Users\HP\Desktop\StudentEvaluationSystem\StudentEvaluationSystem\Areas\Student\Views\ExistingResult\AllResults.cshtml"
                               Write(result.Total);

#line default
#line hidden
            EndContext();
            BeginContext(4426, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(4470, 12, false);
#line 92 "C:\Users\HP\Desktop\StudentEvaluationSystem\StudentEvaluationSystem\Areas\Student\Views\ExistingResult\AllResults.cshtml"
                               Write(result.Grade);

#line default
#line hidden
            EndContext();
            BeginContext(4482, 76, true);
            WriteLiteral("</td>\r\n                            </tr>\r\n                        </tbody>\r\n");
            EndContext();
#line 95 "C:\Users\HP\Desktop\StudentEvaluationSystem\StudentEvaluationSystem\Areas\Student\Views\ExistingResult\AllResults.cshtml"
                    }

#line default
#line hidden
            BeginContext(4581, 289, true);
            WriteLiteral(@"                    <tfoot>
                        <tr>
                            <td></td>
                            <td></td>
                            <td colspan=""2"" class=""font-weight-bold"">Total: </td>
                            <td colspan=""1"" class=""font-weight-bold"">");
            EndContext();
            BeginContext(4871, 10, false);
#line 101 "C:\Users\HP\Desktop\StudentEvaluationSystem\StudentEvaluationSystem\Areas\Student\Views\ExistingResult\AllResults.cshtml"
                                                                Write(totalScore);

#line default
#line hidden
            EndContext();
            BeginContext(4881, 107, true);
            WriteLiteral("</td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td></td>\r\n");
            EndContext();
#line 105 "C:\Users\HP\Desktop\StudentEvaluationSystem\StudentEvaluationSystem\Areas\Student\Views\ExistingResult\AllResults.cshtml"
                               var average = ((int)totalScore / count);

#line default
#line hidden
            BeginContext(5062, 193, true);
            WriteLiteral("                            <td></td>\r\n                            <td colspan=\"2\" class=\"font-weight-bold\">Average: </td>\r\n                            <td colspan=\"1\" class=\"font-weight-bold\">");
            EndContext();
            BeginContext(5256, 7, false);
#line 108 "C:\Users\HP\Desktop\StudentEvaluationSystem\StudentEvaluationSystem\Areas\Student\Views\ExistingResult\AllResults.cshtml"
                                                                Write(average);

#line default
#line hidden
            EndContext();
            BeginContext(5263, 119, true);
            WriteLiteral("%</td>\r\n                        </tr>\r\n                    </tfoot>\r\n                </table>\r\n                <br />\r\n");
            EndContext();
#line 113 "C:\Users\HP\Desktop\StudentEvaluationSystem\StudentEvaluationSystem\Areas\Student\Views\ExistingResult\AllResults.cshtml"
            }

#line default
#line hidden
            BeginContext(5397, 220, true);
            WriteLiteral("            <div class=\"mt-5 d-print-none\" style=\"width:20%;margin-left:40%\"><button style=\"width:100%\" class=\"btn btn-primary\" onclick=\"Print()\"><i class=\"icon-print\"></i>&nbsp;Print</button></div>\r\n            <br />\r\n");
            EndContext();
#line 116 "C:\Users\HP\Desktop\StudentEvaluationSystem\StudentEvaluationSystem\Areas\Student\Views\ExistingResult\AllResults.cshtml"
        }

        else
        {

#line default
#line hidden
            BeginContext(5655, 124, true);
            WriteLiteral("            <div style=\"border:2px dashed #555; padding:5%\"><p class=\"text-center\">No result Currently Available</p></div>\r\n");
            EndContext();
#line 121 "C:\Users\HP\Desktop\StudentEvaluationSystem\StudentEvaluationSystem\Areas\Student\Views\ExistingResult\AllResults.cshtml"
        }

#line default
#line hidden
            BeginContext(5790, 24, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(5831, 79, true);
                WriteLiteral("\r\n\r\n    <script>\r\n    $(document).ready(function () {\r\n\r\n\r\n        var info = \"");
                EndContext();
                BeginContext(5911, 34, false);
#line 132 "C:\Users\HP\Desktop\StudentEvaluationSystem\StudentEvaluationSystem\Areas\Student\Views\ExistingResult\AllResults.cshtml"
               Write(TempData["ClassSaved"]?.ToString());

#line default
#line hidden
                EndContext();
                BeginContext(5945, 27, true);
                WriteLiteral("\";\r\n\r\n        if (info == \"");
                EndContext();
                BeginContext(5973, 14, false);
#line 134 "C:\Users\HP\Desktop\StudentEvaluationSystem\StudentEvaluationSystem\Areas\Student\Views\ExistingResult\AllResults.cshtml"
                Write(Constant.Saved);

#line default
#line hidden
                EndContext();
                BeginContext(5987, 14, true);
                WriteLiteral("\" || info == \"");
                EndContext();
                BeginContext(6002, 16, false);
#line 134 "C:\Users\HP\Desktop\StudentEvaluationSystem\StudentEvaluationSystem\Areas\Student\Views\ExistingResult\AllResults.cshtml"
                                             Write(Constant.Updated);

#line default
#line hidden
                EndContext();
                BeginContext(6018, 165, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<IGrouping<int, Result>>> Html { get; private set; }
    }
}
#pragma warning restore 1591
