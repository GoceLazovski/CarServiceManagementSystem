#pragma checksum "C:\Users\goce.lazovski\Desktop\CarServiceManagementSystem\CarServiceManagementSystem\CarServiceManagementSystem\Views\SpareParts\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0965e924fc28c1eddd7f4476749bd95b20085ec6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SpareParts_Index), @"mvc.1.0.view", @"/Views/SpareParts/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/SpareParts/Index.cshtml", typeof(AspNetCore.Views_SpareParts_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0965e924fc28c1eddd7f4476749bd95b20085ec6", @"/Views/SpareParts/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dda7b77a06c2e089d4fa1d83f6237acc3def9d1f", @"/Views/_ViewImports.cshtml")]
    public class Views_SpareParts_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Services.ViewModels.SparePartsViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "SpareParts", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "InsertPart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UpdatePart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetParts", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeletePart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(61, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\goce.lazovski\Desktop\CarServiceManagementSystem\CarServiceManagementSystem\CarServiceManagementSystem\Views\SpareParts\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(104, 20, true);
            WriteLiteral("\r\n<h1>Parts</h1>\r\n\r\n");
            EndContext();
            BeginContext(124, 226, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0965e924fc28c1eddd7f4476749bd95b20085ec66212", async() => {
                BeginContext(190, 153, true);
                WriteLiteral("\r\n    <p>\r\n        Description: <input type=\"text\" name=\"SearchString\">\r\n        <input type=\"submit\" value=\"Search\" class=\"btn btn-light\" />\r\n    </p>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(350, 13, true);
            WriteLiteral("\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(363, 123, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0965e924fc28c1eddd7f4476749bd95b20085ec68449", async() => {
                BeginContext(418, 64, true);
                WriteLiteral("<input type=\"submit\" value=\"Create New\" class=\"btn btn-light\" />");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
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
            BeginContext(486, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(579, 38, false);
#line 23 "C:\Users\goce.lazovski\Desktop\CarServiceManagementSystem\CarServiceManagementSystem\CarServiceManagementSystem\Views\SpareParts\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(617, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(673, 44, false);
#line 26 "C:\Users\goce.lazovski\Desktop\CarServiceManagementSystem\CarServiceManagementSystem\CarServiceManagementSystem\Views\SpareParts\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ItemCode));

#line default
#line hidden
            EndContext();
            BeginContext(717, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(773, 40, false);
#line 29 "C:\Users\goce.lazovski\Desktop\CarServiceManagementSystem\CarServiceManagementSystem\CarServiceManagementSystem\Views\SpareParts\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(813, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(869, 53, false);
#line 32 "C:\Users\goce.lazovski\Desktop\CarServiceManagementSystem\CarServiceManagementSystem\CarServiceManagementSystem\Views\SpareParts\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ManufacturersCode));

#line default
#line hidden
            EndContext();
            BeginContext(922, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(978, 53, false);
#line 35 "C:\Users\goce.lazovski\Desktop\CarServiceManagementSystem\CarServiceManagementSystem\CarServiceManagementSystem\Views\SpareParts\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ManufacturersName));

#line default
#line hidden
            EndContext();
            BeginContext(1031, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1087, 47, false);
#line 38 "C:\Users\goce.lazovski\Desktop\CarServiceManagementSystem\CarServiceManagementSystem\CarServiceManagementSystem\Views\SpareParts\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1134, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1190, 52, false);
#line 41 "C:\Users\goce.lazovski\Desktop\CarServiceManagementSystem\CarServiceManagementSystem\CarServiceManagementSystem\Views\SpareParts\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.LeadTimeDelivery));

#line default
#line hidden
            EndContext();
            BeginContext(1242, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1298, 51, false);
#line 44 "C:\Users\goce.lazovski\Desktop\CarServiceManagementSystem\CarServiceManagementSystem\CarServiceManagementSystem\Views\SpareParts\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.QuantityInStock));

#line default
#line hidden
            EndContext();
            BeginContext(1349, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1405, 50, false);
#line 47 "C:\Users\goce.lazovski\Desktop\CarServiceManagementSystem\CarServiceManagementSystem\CarServiceManagementSystem\Views\SpareParts\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.UnitPriceSales));

#line default
#line hidden
            EndContext();
            BeginContext(1455, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1511, 53, false);
#line 50 "C:\Users\goce.lazovski\Desktop\CarServiceManagementSystem\CarServiceManagementSystem\CarServiceManagementSystem\Views\SpareParts\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.UnitPricePurchase));

#line default
#line hidden
            EndContext();
            BeginContext(1564, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1620, 44, false);
#line 53 "C:\Users\goce.lazovski\Desktop\CarServiceManagementSystem\CarServiceManagementSystem\CarServiceManagementSystem\Views\SpareParts\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Discount));

#line default
#line hidden
            EndContext();
            BeginContext(1664, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1720, 43, false);
#line 56 "C:\Users\goce.lazovski\Desktop\CarServiceManagementSystem\CarServiceManagementSystem\CarServiceManagementSystem\Views\SpareParts\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.VatRate));

#line default
#line hidden
            EndContext();
            BeginContext(1763, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 62 "C:\Users\goce.lazovski\Desktop\CarServiceManagementSystem\CarServiceManagementSystem\CarServiceManagementSystem\Views\SpareParts\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(1898, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1959, 37, false);
#line 66 "C:\Users\goce.lazovski\Desktop\CarServiceManagementSystem\CarServiceManagementSystem\CarServiceManagementSystem\Views\SpareParts\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1996, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2064, 43, false);
#line 69 "C:\Users\goce.lazovski\Desktop\CarServiceManagementSystem\CarServiceManagementSystem\CarServiceManagementSystem\Views\SpareParts\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.ItemCode));

#line default
#line hidden
            EndContext();
            BeginContext(2107, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2175, 39, false);
#line 72 "C:\Users\goce.lazovski\Desktop\CarServiceManagementSystem\CarServiceManagementSystem\CarServiceManagementSystem\Views\SpareParts\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2214, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2282, 52, false);
#line 75 "C:\Users\goce.lazovski\Desktop\CarServiceManagementSystem\CarServiceManagementSystem\CarServiceManagementSystem\Views\SpareParts\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.ManufacturersCode));

#line default
#line hidden
            EndContext();
            BeginContext(2334, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2402, 52, false);
#line 78 "C:\Users\goce.lazovski\Desktop\CarServiceManagementSystem\CarServiceManagementSystem\CarServiceManagementSystem\Views\SpareParts\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.ManufacturersName));

#line default
#line hidden
            EndContext();
            BeginContext(2454, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2522, 46, false);
#line 81 "C:\Users\goce.lazovski\Desktop\CarServiceManagementSystem\CarServiceManagementSystem\CarServiceManagementSystem\Views\SpareParts\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
            EndContext();
            BeginContext(2568, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2636, 51, false);
#line 84 "C:\Users\goce.lazovski\Desktop\CarServiceManagementSystem\CarServiceManagementSystem\CarServiceManagementSystem\Views\SpareParts\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.LeadTimeDelivery));

#line default
#line hidden
            EndContext();
            BeginContext(2687, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2755, 50, false);
#line 87 "C:\Users\goce.lazovski\Desktop\CarServiceManagementSystem\CarServiceManagementSystem\CarServiceManagementSystem\Views\SpareParts\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.QuantityInStock));

#line default
#line hidden
            EndContext();
            BeginContext(2805, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2873, 49, false);
#line 90 "C:\Users\goce.lazovski\Desktop\CarServiceManagementSystem\CarServiceManagementSystem\CarServiceManagementSystem\Views\SpareParts\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.UnitPriceSales));

#line default
#line hidden
            EndContext();
            BeginContext(2922, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2990, 52, false);
#line 93 "C:\Users\goce.lazovski\Desktop\CarServiceManagementSystem\CarServiceManagementSystem\CarServiceManagementSystem\Views\SpareParts\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.UnitPricePurchase));

#line default
#line hidden
            EndContext();
            BeginContext(3042, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(3110, 43, false);
#line 96 "C:\Users\goce.lazovski\Desktop\CarServiceManagementSystem\CarServiceManagementSystem\CarServiceManagementSystem\Views\SpareParts\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Discount));

#line default
#line hidden
            EndContext();
            BeginContext(3153, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(3221, 42, false);
#line 99 "C:\Users\goce.lazovski\Desktop\CarServiceManagementSystem\CarServiceManagementSystem\CarServiceManagementSystem\Views\SpareParts\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.VatRate));

#line default
#line hidden
            EndContext();
            BeginContext(3263, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(3330, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0965e924fc28c1eddd7f4476749bd95b20085ec622472", async() => {
                BeginContext(3381, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 102 "C:\Users\goce.lazovski\Desktop\CarServiceManagementSystem\CarServiceManagementSystem\CarServiceManagementSystem\Views\SpareParts\Index.cshtml"
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
            BeginContext(3389, 68, true);
            WriteLiteral(" \r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(3457, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0965e924fc28c1eddd7f4476749bd95b20085ec624943", async() => {
                BeginContext(3506, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 105 "C:\Users\goce.lazovski\Desktop\CarServiceManagementSystem\CarServiceManagementSystem\CarServiceManagementSystem\Views\SpareParts\Index.cshtml"
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
            BeginContext(3517, 68, true);
            WriteLiteral(" \r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(3585, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0965e924fc28c1eddd7f4476749bd95b20085ec627415", async() => {
                BeginContext(3636, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 108 "C:\Users\goce.lazovski\Desktop\CarServiceManagementSystem\CarServiceManagementSystem\CarServiceManagementSystem\Views\SpareParts\Index.cshtml"
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
            BeginContext(3646, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 111 "C:\Users\goce.lazovski\Desktop\CarServiceManagementSystem\CarServiceManagementSystem\CarServiceManagementSystem\Views\SpareParts\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(3701, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Services.ViewModels.SparePartsViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
