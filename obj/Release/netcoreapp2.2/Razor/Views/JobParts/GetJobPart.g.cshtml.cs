#pragma checksum "C:\Users\goce.lazovski\Desktop\CarServiceManagementSystem\CarServiceManagementSystem\CarServiceManagementSystem\Views\JobParts\GetJobPart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0fd3df70ec55b7bc98c211cb0691200cf56c0081"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_JobParts_GetJobPart), @"mvc.1.0.view", @"/Views/JobParts/GetJobPart.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/JobParts/GetJobPart.cshtml", typeof(AspNetCore.Views_JobParts_GetJobPart))]
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
#line 1 "C:\Users\goce.lazovski\Desktop\CarServiceManagementSystem\CarServiceManagementSystem\CarServiceManagementSystem\Views\_ViewImports.cshtml"
using CarServiceManagementSystem;

#line default
#line hidden
#line 2 "C:\Users\goce.lazovski\Desktop\CarServiceManagementSystem\CarServiceManagementSystem\CarServiceManagementSystem\Views\_ViewImports.cshtml"
using CarServiceManagementSystem.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0fd3df70ec55b7bc98c211cb0691200cf56c0081", @"/Views/JobParts/GetJobPart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dda7b77a06c2e089d4fa1d83f6237acc3def9d1f", @"/Views/_ViewImports.cshtml")]
    public class Views_JobParts_GetJobPart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Services.ViewModels.JobPartsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "JobParts", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UpdateJobPart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "JobCard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetJobCard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(46, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\goce.lazovski\Desktop\CarServiceManagementSystem\CarServiceManagementSystem\CarServiceManagementSystem\Views\JobParts\GetJobPart.cshtml"
  
    ViewData["Title"] = "GetJobPart";

#line default
#line hidden
            BeginContext(94, 107, true);
            WriteLiteral("\r\n<h1>Job Part</h1>\r\n\r\n<div>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(202, 43, false);
#line 13 "C:\Users\goce.lazovski\Desktop\CarServiceManagementSystem\CarServiceManagementSystem\CarServiceManagementSystem\Views\JobParts\GetJobPart.cshtml"
       Write(Html.DisplayNameFor(model => model.JobCard));

#line default
#line hidden
            EndContext();
            BeginContext(245, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(307, 54, false);
#line 16 "C:\Users\goce.lazovski\Desktop\CarServiceManagementSystem\CarServiceManagementSystem\CarServiceManagementSystem\Views\JobParts\GetJobPart.cshtml"
       Write(Html.DisplayFor(model => model.JobCard.JobDescription));

#line default
#line hidden
            EndContext();
            BeginContext(361, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(422, 45, false);
#line 19 "C:\Users\goce.lazovski\Desktop\CarServiceManagementSystem\CarServiceManagementSystem\CarServiceManagementSystem\Views\JobParts\GetJobPart.cshtml"
       Write(Html.DisplayNameFor(model => model.SparePart));

#line default
#line hidden
            EndContext();
            BeginContext(467, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(529, 46, false);
#line 22 "C:\Users\goce.lazovski\Desktop\CarServiceManagementSystem\CarServiceManagementSystem\CarServiceManagementSystem\Views\JobParts\GetJobPart.cshtml"
       Write(Html.DisplayFor(model => model.SparePart.Name));

#line default
#line hidden
            EndContext();
            BeginContext(575, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(636, 53, false);
#line 25 "C:\Users\goce.lazovski\Desktop\CarServiceManagementSystem\CarServiceManagementSystem\CarServiceManagementSystem\Views\JobParts\GetJobPart.cshtml"
       Write(Html.DisplayNameFor(model => model.QuantityInstalled));

#line default
#line hidden
            EndContext();
            BeginContext(689, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(751, 49, false);
#line 28 "C:\Users\goce.lazovski\Desktop\CarServiceManagementSystem\CarServiceManagementSystem\CarServiceManagementSystem\Views\JobParts\GetJobPart.cshtml"
       Write(Html.DisplayFor(model => model.QuantityInstalled));

#line default
#line hidden
            EndContext();
            BeginContext(800, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(847, 197, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0fd3df70ec55b7bc98c211cb0691200cf56c00818088", async() => {
                BeginContext(978, 62, true);
                WriteLiteral("<input type=\"submit\" value=\"Edit Job\" class=\"btn btn-light\" />");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-jobId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 33 "C:\Users\goce.lazovski\Desktop\CarServiceManagementSystem\CarServiceManagementSystem\CarServiceManagementSystem\Views\JobParts\GetJobPart.cshtml"
                                                                 WriteLiteral(Model.JobCardId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["jobId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-jobId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["jobId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute(",", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            BeginWriteTagHelperAttribute();
#line 33 "C:\Users\goce.lazovski\Desktop\CarServiceManagementSystem\CarServiceManagementSystem\CarServiceManagementSystem\Views\JobParts\GetJobPart.cshtml"
                                                                                                       WriteLiteral(Model.SparePartId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["partId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-partId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["partId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1044, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(1050, 153, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0fd3df70ec55b7bc98c211cb0691200cf56c008111914", async() => {
                BeginContext(1134, 65, true);
                WriteLiteral("<input type=\"submit\" value=\"Back to Job\" class=\"btn btn-light\" />");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 34 "C:\Users\goce.lazovski\Desktop\CarServiceManagementSystem\CarServiceManagementSystem\CarServiceManagementSystem\Views\JobParts\GetJobPart.cshtml"
                                                          WriteLiteral(Model.JobCardId);

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
            BeginContext(1203, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Services.ViewModels.JobPartsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591