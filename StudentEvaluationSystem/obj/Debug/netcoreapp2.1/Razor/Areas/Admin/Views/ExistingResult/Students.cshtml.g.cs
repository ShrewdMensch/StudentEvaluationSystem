#pragma checksum "C:\Users\HP\Desktop\StudentEvaluationSystem\StudentEvaluationSystem\Areas\Admin\Views\ExistingResult\Students.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f6d42f71b1d3aa26c68beb42c32e8b2c99928efe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_ExistingResult_Students), @"mvc.1.0.view", @"/Areas/Admin/Views/ExistingResult/Students.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/ExistingResult/Students.cshtml", typeof(AspNetCore.Areas_Admin_Views_ExistingResult_Students))]
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
#line 1 "C:\Users\HP\Desktop\StudentEvaluationSystem\StudentEvaluationSystem\Areas\Admin\Views\_ViewImports.cshtml"
using StudentEvaluationSystem;

#line default
#line hidden
#line 2 "C:\Users\HP\Desktop\StudentEvaluationSystem\StudentEvaluationSystem\Areas\Admin\Views\_ViewImports.cshtml"
using StudentEvaluationSystem.Models;

#line default
#line hidden
#line 1 "C:\Users\HP\Desktop\StudentEvaluationSystem\StudentEvaluationSystem\Areas\Admin\Views\ExistingResult\Students.cshtml"
using StudentEvaluationSystem.Utility;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f6d42f71b1d3aa26c68beb42c32e8b2c99928efe", @"/Areas/Admin/Views/ExistingResult/Students.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01e7bcc8e6ed2284e20768f21d08d1ed407e441d", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_ExistingResult_Students : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Student>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Results", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "C:\Users\HP\Desktop\StudentEvaluationSystem\StudentEvaluationSystem\Areas\Admin\Views\ExistingResult\Students.cshtml"
  
    ViewData["Title"] = "Index";
    ViewData["Heading"] = "Classes";

#line default
#line hidden
            BeginContext(143, 300, true);
            WriteLiteral(@"
<div class=""site-section ftco-subscribe-1 site-blocks-cover pb-4"" style=""background-image: url('/images/bg_1.jpg');"">
    <div class=""container"">
        <div class=""row align-items-end"">
            <div class=""col-lg-7"">
                <h2 class=""mb-0"">Students</h2>
                <p>For ");
            EndContext();
            BeginContext(444, 20, false);
#line 14 "C:\Users\HP\Desktop\StudentEvaluationSystem\StudentEvaluationSystem\Areas\Admin\Views\ExistingResult\Students.cshtml"
                  Write(ViewData["TermName"]);

#line default
#line hidden
            EndContext();
            BeginContext(464, 4, true);
            WriteLiteral(" -  ");
            EndContext();
            BeginContext(469, 23, false);
#line 14 "C:\Users\HP\Desktop\StudentEvaluationSystem\StudentEvaluationSystem\Areas\Admin\Views\ExistingResult\Students.cshtml"
                                           Write(ViewData["SessionName"]);

#line default
#line hidden
            EndContext();
            BeginContext(492, 142, true);
            WriteLiteral(" Academic Session</p>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n<div class=\"site-section\">\r\n    <div class=\"container\">\r\n");
            EndContext();
#line 24 "C:\Users\HP\Desktop\StudentEvaluationSystem\StudentEvaluationSystem\Areas\Admin\Views\ExistingResult\Students.cshtml"
         if (Model.Count > 0)
        {

#line default
#line hidden
            BeginContext(676, 198, true);
            WriteLiteral("            <table class=\"table table-sm table-striped\">\r\n                <thead class=\"table-primary\">\r\n                    <tr>\r\n                        <th>Name</th>\r\n                        <th>");
            EndContext();
            BeginContext(875, 59, false);
#line 30 "C:\Users\HP\Desktop\StudentEvaluationSystem\StudentEvaluationSystem\Areas\Admin\Views\ExistingResult\Students.cshtml"
                       Write(Html.DisplayNameFor(m => m.FirstOrDefault().CurrentClassId));

#line default
#line hidden
            EndContext();
            BeginContext(934, 35, true);
            WriteLiteral("</th>\r\n                        <th>");
            EndContext();
            BeginContext(970, 59, false);
#line 31 "C:\Users\HP\Desktop\StudentEvaluationSystem\StudentEvaluationSystem\Areas\Admin\Views\ExistingResult\Students.cshtml"
                       Write(Html.DisplayNameFor(m => m.FirstOrDefault().ClassOfEntryId));

#line default
#line hidden
            EndContext();
            BeginContext(1029, 35, true);
            WriteLiteral("</th>\r\n                        <th>");
            EndContext();
            BeginContext(1065, 56, false);
#line 32 "C:\Users\HP\Desktop\StudentEvaluationSystem\StudentEvaluationSystem\Areas\Admin\Views\ExistingResult\Students.cshtml"
                       Write(Html.DisplayNameFor(m => m.FirstOrDefault().YearOfEntry));

#line default
#line hidden
            EndContext();
            BeginContext(1121, 120, true);
            WriteLiteral("</th>\r\n                        <th></th>\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
            EndContext();
#line 37 "C:\Users\HP\Desktop\StudentEvaluationSystem\StudentEvaluationSystem\Areas\Admin\Views\ExistingResult\Students.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
            BeginContext(1314, 54, true);
            WriteLiteral("                    <tr>\r\n                        <td>");
            EndContext();
            BeginContext(1369, 13, false);
#line 40 "C:\Users\HP\Desktop\StudentEvaluationSystem\StudentEvaluationSystem\Areas\Admin\Views\ExistingResult\Students.cshtml"
                       Write(item.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(1382, 2, true);
            WriteLiteral(", ");
            EndContext();
            BeginContext(1385, 14, false);
#line 40 "C:\Users\HP\Desktop\StudentEvaluationSystem\StudentEvaluationSystem\Areas\Admin\Views\ExistingResult\Students.cshtml"
                                       Write(item.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(1399, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1435, 22, false);
#line 41 "C:\Users\HP\Desktop\StudentEvaluationSystem\StudentEvaluationSystem\Areas\Admin\Views\ExistingResult\Students.cshtml"
                       Write(item.CurrentClass.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1457, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1493, 22, false);
#line 42 "C:\Users\HP\Desktop\StudentEvaluationSystem\StudentEvaluationSystem\Areas\Admin\Views\ExistingResult\Students.cshtml"
                       Write(item.ClassOfEntry.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1515, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1551, 16, false);
#line 43 "C:\Users\HP\Desktop\StudentEvaluationSystem\StudentEvaluationSystem\Areas\Admin\Views\ExistingResult\Students.cshtml"
                       Write(item.YearOfEntry);

#line default
#line hidden
            EndContext();
            BeginContext(1567, 143, true);
            WriteLiteral("</td>\r\n                        <td>\r\n                            <div class=\"btn-group\" style=\"float:right;\">\r\n                                ");
            EndContext();
            BeginContext(1710, 149, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a9697ec2e20543999e34911b4101d3d7", async() => {
                BeginContext(1806, 49, true);
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
#line 46 "C:\Users\HP\Desktop\StudentEvaluationSystem\StudentEvaluationSystem\Areas\Admin\Views\ExistingResult\Students.cshtml"
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
            BeginContext(1859, 96, true);
            WriteLiteral("\r\n                            </div>\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 50 "C:\Users\HP\Desktop\StudentEvaluationSystem\StudentEvaluationSystem\Areas\Admin\Views\ExistingResult\Students.cshtml"
                    }

#line default
#line hidden
            BeginContext(1978, 48, true);
            WriteLiteral("                </tbody>\r\n            </table>\r\n");
            EndContext();
#line 53 "C:\Users\HP\Desktop\StudentEvaluationSystem\StudentEvaluationSystem\Areas\Admin\Views\ExistingResult\Students.cshtml"
        }

        else
        {

#line default
#line hidden
            BeginContext(2064, 125, true);
            WriteLiteral("            <div style=\"border:2px dashed #555; padding:5%\"><p class=\"text-center\">No Student Currently Available</p></div>\r\n");
            EndContext();
#line 58 "C:\Users\HP\Desktop\StudentEvaluationSystem\StudentEvaluationSystem\Areas\Admin\Views\ExistingResult\Students.cshtml"
        }

#line default
#line hidden
            BeginContext(2200, 22, true);
            WriteLiteral("    </div>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2239, 187, true);
                WriteLiteral("\r\n\r\n    <script>\r\n    $(document).ready(function () {\r\n        $(\".table\").DataTable({\r\n            \"aLengthMenu\": [[5, 10, 15, -1], [5, 10, 15, \"All\"]]\r\n  });\r\n\r\n    });\r\n    </script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Student>> Html { get; private set; }
    }
}
#pragma warning restore 1591
