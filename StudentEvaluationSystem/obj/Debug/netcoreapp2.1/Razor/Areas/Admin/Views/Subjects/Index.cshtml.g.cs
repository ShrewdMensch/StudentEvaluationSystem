#pragma checksum "C:\Users\bolar\source\repos\StudentEvaluationSystem_Repo\StudentEvaluationSystem\Areas\Admin\Views\Subjects\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9f177fded8b7590c0730fadfb63d951b3e0f023d"
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
#line 1 "C:\Users\bolar\source\repos\StudentEvaluationSystem_Repo\StudentEvaluationSystem\Areas\Admin\Views\_ViewImports.cshtml"
using StudentEvaluationSystem;

#line default
#line hidden
#line 2 "C:\Users\bolar\source\repos\StudentEvaluationSystem_Repo\StudentEvaluationSystem\Areas\Admin\Views\_ViewImports.cshtml"
using StudentEvaluationSystem.Models;

#line default
#line hidden
#line 1 "C:\Users\bolar\source\repos\StudentEvaluationSystem_Repo\StudentEvaluationSystem\Areas\Admin\Views\Subjects\Index.cshtml"
using StudentEvaluationSystem.Utility;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f177fded8b7590c0730fadfb63d951b3e0f023d", @"/Areas/Admin/Views/Subjects/Index.cshtml")]
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
            BeginContext(69, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\bolar\source\repos\StudentEvaluationSystem_Repo\StudentEvaluationSystem\Areas\Admin\Views\Subjects\Index.cshtml"
  
    ViewData["Title"] = "Index";
    ViewData["Heading"] = "Subjects";

#line default
#line hidden
            BeginContext(151, 581, true);
            WriteLiteral(@"
<div class=""site-section ftco-subscribe-1 site-blocks-cover pb-4"" style=""background-image: url('/images/bg_1.jpg');"">
    <div class=""container"">
        <div class=""row align-items-end"">
            <div class=""col-lg-7"">
                <h2 class=""mb-0"">Subjects</h2>
                <p>Available Subjects in Offa Grammar School.</p>
            </div>
        </div>
    </div>
</div>



<div class=""my-5"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-6""></div>
            <div class=""col-6 text-right"">
                ");
            EndContext();
            BeginContext(732, 181, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d546df30e074472181124d83ff2e4f37", async() => {
                BeginContext(822, 87, true);
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
            BeginContext(913, 54, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <br />\r\n");
            EndContext();
#line 33 "C:\Users\bolar\source\repos\StudentEvaluationSystem_Repo\StudentEvaluationSystem\Areas\Admin\Views\Subjects\Index.cshtml"
         if (Model.ToList().Count > 0)
        {

#line default
#line hidden
            BeginContext(1018, 212, true);
            WriteLiteral("            <table class=\"table table-sm table-striped\" id=\"subjects\">\r\n                <thead class=\"table-primary\">\r\n                    <tr>\r\n                        <th>Name</th>\r\n                        <th>");
            EndContext();
            BeginContext(1231, 54, false);
#line 39 "C:\Users\bolar\source\repos\StudentEvaluationSystem_Repo\StudentEvaluationSystem\Areas\Admin\Views\Subjects\Index.cshtml"
                       Write(Html.DisplayNameFor(m => m.FirstOrDefault().TeacherId));

#line default
#line hidden
            EndContext();
            BeginContext(1285, 35, true);
            WriteLiteral("</th>\r\n                        <th>");
            EndContext();
            BeginContext(1321, 58, false);
#line 40 "C:\Users\bolar\source\repos\StudentEvaluationSystem_Repo\StudentEvaluationSystem\Areas\Admin\Views\Subjects\Index.cshtml"
                       Write(Html.DisplayNameFor(m => m.FirstOrDefault().SubjectTypeId));

#line default
#line hidden
            EndContext();
            BeginContext(1379, 120, true);
            WriteLiteral("</th>\r\n                        <th></th>\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
            EndContext();
#line 45 "C:\Users\bolar\source\repos\StudentEvaluationSystem_Repo\StudentEvaluationSystem\Areas\Admin\Views\Subjects\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
            BeginContext(1572, 62, true);
            WriteLiteral("                        <tr>\r\n                            <td>");
            EndContext();
            BeginContext(1635, 9, false);
#line 48 "C:\Users\bolar\source\repos\StudentEvaluationSystem_Repo\StudentEvaluationSystem\Areas\Admin\Views\Subjects\Index.cshtml"
                           Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1644, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1684, 21, false);
#line 49 "C:\Users\bolar\source\repos\StudentEvaluationSystem_Repo\StudentEvaluationSystem\Areas\Admin\Views\Subjects\Index.cshtml"
                           Write(item.Teacher.FullName);

#line default
#line hidden
            EndContext();
            BeginContext(1705, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1745, 21, false);
#line 50 "C:\Users\bolar\source\repos\StudentEvaluationSystem_Repo\StudentEvaluationSystem\Areas\Admin\Views\Subjects\Index.cshtml"
                           Write(item.SubjectType.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1766, 35, true);
            WriteLiteral("</td>\r\n                            ");
            EndContext();
            BeginContext(1801, 78, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b465327c816745b3bef60aad1ef23369", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
#line 51 "C:\Users\bolar\source\repos\StudentEvaluationSystem_Repo\StudentEvaluationSystem\Areas\Admin\Views\Subjects\Index.cshtml"
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
            BeginContext(1879, 33, true);
            WriteLiteral("\r\n                        </tr>\r\n");
            EndContext();
#line 53 "C:\Users\bolar\source\repos\StudentEvaluationSystem_Repo\StudentEvaluationSystem\Areas\Admin\Views\Subjects\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(1935, 48, true);
            WriteLiteral("                </tbody>\r\n            </table>\r\n");
            EndContext();
#line 56 "C:\Users\bolar\source\repos\StudentEvaluationSystem_Repo\StudentEvaluationSystem\Areas\Admin\Views\Subjects\Index.cshtml"
        }

        else
        {

#line default
#line hidden
            BeginContext(2021, 125, true);
            WriteLiteral("            <div style=\"border:2px dashed #555; padding:5%\"><p class=\"text-center\">No Subject Currently Available</p></div>\r\n");
            EndContext();
#line 61 "C:\Users\bolar\source\repos\StudentEvaluationSystem_Repo\StudentEvaluationSystem\Areas\Admin\Views\Subjects\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(2157, 22, true);
            WriteLiteral("    </div>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2196, 183, true);
                WriteLiteral("\r\n\r\n    <script>\r\n    $(document).ready(function () {\r\n        $(\".table\").DataTable({\r\n            \"aLengthMenu\": [[5, 10, 15, -1], [5, 10, 15, \"All\"]]\r\n  });\r\n\r\n        var info = \"");
                EndContext();
                BeginContext(2380, 36, false);
#line 73 "C:\Users\bolar\source\repos\StudentEvaluationSystem_Repo\StudentEvaluationSystem\Areas\Admin\Views\Subjects\Index.cshtml"
               Write(TempData["SubjectSaved"]?.ToString());

#line default
#line hidden
                EndContext();
                BeginContext(2416, 27, true);
                WriteLiteral("\";\r\n\r\n        if (info == \"");
                EndContext();
                BeginContext(2444, 14, false);
#line 75 "C:\Users\bolar\source\repos\StudentEvaluationSystem_Repo\StudentEvaluationSystem\Areas\Admin\Views\Subjects\Index.cshtml"
                Write(Constant.Saved);

#line default
#line hidden
                EndContext();
                BeginContext(2458, 14, true);
                WriteLiteral("\" || info == \"");
                EndContext();
                BeginContext(2473, 16, false);
#line 75 "C:\Users\bolar\source\repos\StudentEvaluationSystem_Repo\StudentEvaluationSystem\Areas\Admin\Views\Subjects\Index.cshtml"
                                             Write(Constant.Updated);

#line default
#line hidden
                EndContext();
                BeginContext(2489, 109, true);
                WriteLiteral("\") {\r\n            toastr.success(\"Subject \" + info + \" Successfully\");\r\n        }\r\n\r\n    });\r\n    </script>\r\n");
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
