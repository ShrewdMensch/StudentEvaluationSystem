#pragma checksum "C:\Users\bolar\source\repos\StudentEvaluationSystem\StudentEvaluationSystem\Areas\Admin\Views\Subjects\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "55e2636ed051231956da61124b249b633ff540fe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Subjects_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Subjects/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Subjects/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Subjects_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55e2636ed051231956da61124b249b633ff540fe", @"/Areas/Admin/Views/Subjects/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01e7bcc8e6ed2284e20768f21d08d1ed407e441d", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Subjects_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Subject>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Subjects", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "~/Views/Partial/_TableButtonPartial.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(29, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\bolar\source\repos\StudentEvaluationSystem\StudentEvaluationSystem\Areas\Admin\Views\Subjects\Index.cshtml"
  
    ViewData["Title"] = "Index";
    ViewData["Heading"] = "Subjects";

#line default
#line hidden
            BeginContext(111, 589, true);
            WriteLiteral(@"
<div class=""site-section ftco-subscribe-1 site-blocks-cover pb-4"" style=""background-image: url('/images/bg_1.jpg');"">
    <div class=""container"">
        <div class=""row align-items-end"">
            <div class=""col-lg-7"">
                <h2 class=""mb-0"">Students</h2>
                <p>Available Subjects in Offa Grammar School.</p>
            </div>
        </div>
    </div>
</div>



<div class=""site-section"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-6""></div>
            <div class=""col-6 text-right"">
                ");
            EndContext();
            BeginContext(700, 181, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "55e2636ed051231956da61124b249b633ff540fe6095", async() => {
                BeginContext(790, 87, true);
                WriteLiteral("\r\n                    <i class=\"icon-user-plus\"></i>&nbsp;New Subject\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(881, 54, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <br />\r\n");
            EndContext();
#line 32 "C:\Users\bolar\source\repos\StudentEvaluationSystem\StudentEvaluationSystem\Areas\Admin\Views\Subjects\Index.cshtml"
         if (Model.ToList().Count > 0)
        {

#line default
#line hidden
            BeginContext(986, 212, true);
            WriteLiteral("            <table class=\"table table-sm table-striped\" id=\"subjects\">\r\n                <thead class=\"table-primary\">\r\n                    <tr>\r\n                        <th>Name</th>\r\n                        <th>");
            EndContext();
            BeginContext(1199, 54, false);
#line 38 "C:\Users\bolar\source\repos\StudentEvaluationSystem\StudentEvaluationSystem\Areas\Admin\Views\Subjects\Index.cshtml"
                       Write(Html.DisplayNameFor(m => m.FirstOrDefault().TeacherId));

#line default
#line hidden
            EndContext();
            BeginContext(1253, 35, true);
            WriteLiteral("</th>\r\n                        <th>");
            EndContext();
            BeginContext(1289, 58, false);
#line 39 "C:\Users\bolar\source\repos\StudentEvaluationSystem\StudentEvaluationSystem\Areas\Admin\Views\Subjects\Index.cshtml"
                       Write(Html.DisplayNameFor(m => m.FirstOrDefault().SubjectTypeId));

#line default
#line hidden
            EndContext();
            BeginContext(1347, 120, true);
            WriteLiteral("</th>\r\n                        <th></th>\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
            EndContext();
#line 44 "C:\Users\bolar\source\repos\StudentEvaluationSystem\StudentEvaluationSystem\Areas\Admin\Views\Subjects\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
            BeginContext(1540, 62, true);
            WriteLiteral("                        <tr>\r\n                            <td>");
            EndContext();
            BeginContext(1603, 9, false);
#line 47 "C:\Users\bolar\source\repos\StudentEvaluationSystem\StudentEvaluationSystem\Areas\Admin\Views\Subjects\Index.cshtml"
                           Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1612, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1652, 21, false);
#line 48 "C:\Users\bolar\source\repos\StudentEvaluationSystem\StudentEvaluationSystem\Areas\Admin\Views\Subjects\Index.cshtml"
                           Write(item.Teacher.FullName);

#line default
#line hidden
            EndContext();
            BeginContext(1673, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1713, 21, false);
#line 49 "C:\Users\bolar\source\repos\StudentEvaluationSystem\StudentEvaluationSystem\Areas\Admin\Views\Subjects\Index.cshtml"
                           Write(item.SubjectType.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1734, 35, true);
            WriteLiteral("</td>\r\n                            ");
            EndContext();
            BeginContext(1769, 78, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "55e2636ed051231956da61124b249b633ff540fe11316", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
#line 50 "C:\Users\bolar\source\repos\StudentEvaluationSystem\StudentEvaluationSystem\Areas\Admin\Views\Subjects\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = item.Id;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1847, 33, true);
            WriteLiteral("\r\n                        </tr>\r\n");
            EndContext();
#line 52 "C:\Users\bolar\source\repos\StudentEvaluationSystem\StudentEvaluationSystem\Areas\Admin\Views\Subjects\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(1903, 48, true);
            WriteLiteral("                </tbody>\r\n            </table>\r\n");
            EndContext();
#line 55 "C:\Users\bolar\source\repos\StudentEvaluationSystem\StudentEvaluationSystem\Areas\Admin\Views\Subjects\Index.cshtml"
        }

        else
        {

#line default
#line hidden
            BeginContext(1989, 125, true);
            WriteLiteral("            <div style=\"border:2px dashed #555; padding:5%\"><p class=\"text-center\">No Subject Currently Available</p></div>\r\n");
            EndContext();
#line 60 "C:\Users\bolar\source\repos\StudentEvaluationSystem\StudentEvaluationSystem\Areas\Admin\Views\Subjects\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(2125, 22, true);
            WriteLiteral("    </div>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2164, 111, true);
                WriteLiteral("\r\n<script>\r\n    $(document).ready(function () {\r\n    $(\'#subjects\').DataTable();\r\n    } );\r\n\r\n</script>\r\n    \r\n");
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
