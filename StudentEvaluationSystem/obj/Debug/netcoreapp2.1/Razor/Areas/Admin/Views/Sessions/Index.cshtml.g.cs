#pragma checksum "C:\Users\bolar\source\repos\StudentEvaluationSystem_Repo\StudentEvaluationSystem\Areas\Admin\Views\Sessions\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "078f9235a6ad0c2d38b66a9353d6d301a1dd9f79"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Sessions_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Sessions/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Sessions/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Sessions_Index))]
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
#line 1 "C:\Users\bolar\source\repos\StudentEvaluationSystem_Repo\StudentEvaluationSystem\Areas\Admin\Views\Sessions\Index.cshtml"
using StudentEvaluationSystem.Utility;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"078f9235a6ad0c2d38b66a9353d6d301a1dd9f79", @"/Areas/Admin/Views/Sessions/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01e7bcc8e6ed2284e20768f21d08d1ed407e441d", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Sessions_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Session>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "~/Views/Partial/_TableButtonPartial.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(62, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\bolar\source\repos\StudentEvaluationSystem_Repo\StudentEvaluationSystem\Areas\Admin\Views\Sessions\Index.cshtml"
  
    ViewData["Title"] = "Index";
    ViewData["Heading"] = "Sessions";

#line default
#line hidden
            BeginContext(144, 539, true);
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



<div class=""my-5"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-6""></div>
            <div class=""col-6 text-right"">");
            EndContext();
            BeginContext(683, 99, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "271d04cc39e2440ba5209bf9fd30a55a", async() => {
                BeginContext(730, 48, true);
                WriteLiteral("<i class=\"icon-add_circle\"></i>&nbsp;New Session");
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
            BeginContext(782, 40, true);
            WriteLiteral("</div>\r\n        </div>\r\n        <br />\r\n");
            EndContext();
#line 29 "C:\Users\bolar\source\repos\StudentEvaluationSystem_Repo\StudentEvaluationSystem\Areas\Admin\Views\Sessions\Index.cshtml"
         if (Model.Count() > 0)
        {

#line default
#line hidden
            BeginContext(866, 191, true);
            WriteLiteral("            <table class=\"table table-sm table-striped\">\r\n                <thead class=\"\" style=\"background-color:#28a745;color:#fff;\">\r\n                    <tr>\r\n                        <th>");
            EndContext();
            BeginContext(1058, 49, false);
#line 34 "C:\Users\bolar\source\repos\StudentEvaluationSystem_Repo\StudentEvaluationSystem\Areas\Admin\Views\Sessions\Index.cshtml"
                       Write(Html.DisplayNameFor(m => m.FirstOrDefault().Name));

#line default
#line hidden
            EndContext();
            BeginContext(1107, 35, true);
            WriteLiteral("</th>\r\n                        <th>");
            EndContext();
            BeginContext(1143, 54, false);
#line 35 "C:\Users\bolar\source\repos\StudentEvaluationSystem_Repo\StudentEvaluationSystem\Areas\Admin\Views\Sessions\Index.cshtml"
                       Write(Html.DisplayNameFor(m => m.FirstOrDefault().IsCurrent));

#line default
#line hidden
            EndContext();
            BeginContext(1197, 120, true);
            WriteLiteral("</th>\r\n                        <th></th>\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
            EndContext();
#line 40 "C:\Users\bolar\source\repos\StudentEvaluationSystem_Repo\StudentEvaluationSystem\Areas\Admin\Views\Sessions\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
            BeginContext(1390, 62, true);
            WriteLiteral("                        <tr>\r\n                            <td>");
            EndContext();
            BeginContext(1453, 9, false);
#line 43 "C:\Users\bolar\source\repos\StudentEvaluationSystem_Repo\StudentEvaluationSystem\Areas\Admin\Views\Sessions\Index.cshtml"
                           Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1462, 41, true);
            WriteLiteral("</td>\r\n                            <td>\r\n");
            EndContext();
#line 45 "C:\Users\bolar\source\repos\StudentEvaluationSystem_Repo\StudentEvaluationSystem\Areas\Admin\Views\Sessions\Index.cshtml"
                                  if (item.IsCurrent)
                                    {

#line default
#line hidden
            BeginContext(1597, 80, true);
            WriteLiteral("                                        <i class=\"icon-check btn-success\"></i>\r\n");
            EndContext();
#line 48 "C:\Users\bolar\source\repos\StudentEvaluationSystem_Repo\StudentEvaluationSystem\Areas\Admin\Views\Sessions\Index.cshtml"
                                    }
                                

#line default
#line hidden
            BeginContext(1751, 63, true);
            WriteLiteral("                            </td>\r\n                            ");
            EndContext();
            BeginContext(1814, 78, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f27eeb09e9d643219142fbdfa8aafdb5", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
#line 51 "C:\Users\bolar\source\repos\StudentEvaluationSystem_Repo\StudentEvaluationSystem\Areas\Admin\Views\Sessions\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = item.Id;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1892, 33, true);
            WriteLiteral("\r\n                        </tr>\r\n");
            EndContext();
#line 53 "C:\Users\bolar\source\repos\StudentEvaluationSystem_Repo\StudentEvaluationSystem\Areas\Admin\Views\Sessions\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(1948, 48, true);
            WriteLiteral("                </tbody>\r\n            </table>\r\n");
            EndContext();
#line 56 "C:\Users\bolar\source\repos\StudentEvaluationSystem_Repo\StudentEvaluationSystem\Areas\Admin\Views\Sessions\Index.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(2032, 125, true);
            WriteLiteral("            <div style=\"border:2px dashed #555; padding:5%\"><p class=\"text-center\">No Subject Currently Available</p></div>\r\n");
            EndContext();
#line 60 "C:\Users\bolar\source\repos\StudentEvaluationSystem_Repo\StudentEvaluationSystem\Areas\Admin\Views\Sessions\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(2168, 24, true);
            WriteLiteral("    </div>\r\n</div>\r\n\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2209, 183, true);
                WriteLiteral("\r\n\r\n    <script>\r\n    $(document).ready(function () {\r\n        $(\".table\").DataTable({\r\n            \"aLengthMenu\": [[5, 10, 15, -1], [5, 10, 15, \"All\"]]\r\n  });\r\n\r\n        var info = \"");
                EndContext();
                BeginContext(2393, 36, false);
#line 73 "C:\Users\bolar\source\repos\StudentEvaluationSystem_Repo\StudentEvaluationSystem\Areas\Admin\Views\Sessions\Index.cshtml"
               Write(TempData["SessionSaved"]?.ToString());

#line default
#line hidden
                EndContext();
                BeginContext(2429, 27, true);
                WriteLiteral("\";\r\n\r\n        if (info == \"");
                EndContext();
                BeginContext(2457, 14, false);
#line 75 "C:\Users\bolar\source\repos\StudentEvaluationSystem_Repo\StudentEvaluationSystem\Areas\Admin\Views\Sessions\Index.cshtml"
                Write(Constant.Saved);

#line default
#line hidden
                EndContext();
                BeginContext(2471, 14, true);
                WriteLiteral("\" || info == \"");
                EndContext();
                BeginContext(2486, 16, false);
#line 75 "C:\Users\bolar\source\repos\StudentEvaluationSystem_Repo\StudentEvaluationSystem\Areas\Admin\Views\Sessions\Index.cshtml"
                                             Write(Constant.Updated);

#line default
#line hidden
                EndContext();
                BeginContext(2502, 109, true);
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
