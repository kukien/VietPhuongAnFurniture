#pragma checksum "D:\Project\VietPhuongAnFurniture\VietPhuongAnFurniture\Views\Detail\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "80065aa390e98261397e985d9982a04952c5610a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Detail_Delete), @"mvc.1.0.view", @"/Views/Detail/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Detail/Delete.cshtml", typeof(AspNetCore.Views_Detail_Delete))]
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
#line 1 "D:\Project\VietPhuongAnFurniture\VietPhuongAnFurniture\Views\_ViewImports.cshtml"
using VietPhuongAnFurniture;

#line default
#line hidden
#line 2 "D:\Project\VietPhuongAnFurniture\VietPhuongAnFurniture\Views\_ViewImports.cshtml"
using VietPhuongAnFurniture.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80065aa390e98261397e985d9982a04952c5610a", @"/Views/Detail/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"283ad1f1b0caa5581e4d2f338d73f59529f78500", @"/Views/_ViewImports.cshtml")]
    public class Views_Detail_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VietPhuongAnFurniture.Models.Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(45, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Project\VietPhuongAnFurniture\VietPhuongAnFurniture\Views\Detail\Delete.cshtml"
  
    ViewData["Title"] = "Delete";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(136, 177, true);
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Product</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(314, 40, false);
#line 16 "D:\Project\VietPhuongAnFurniture\VietPhuongAnFurniture\Views\Detail\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(354, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(418, 36, false);
#line 19 "D:\Project\VietPhuongAnFurniture\VietPhuongAnFurniture\Views\Detail\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(454, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(517, 40, false);
#line 22 "D:\Project\VietPhuongAnFurniture\VietPhuongAnFurniture\Views\Detail\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Code));

#line default
#line hidden
            EndContext();
            BeginContext(557, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(621, 36, false);
#line 25 "D:\Project\VietPhuongAnFurniture\VietPhuongAnFurniture\Views\Detail\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Code));

#line default
#line hidden
            EndContext();
            BeginContext(657, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(720, 42, false);
#line 28 "D:\Project\VietPhuongAnFurniture\VietPhuongAnFurniture\Views\Detail\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Origin));

#line default
#line hidden
            EndContext();
            BeginContext(762, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(826, 38, false);
#line 31 "D:\Project\VietPhuongAnFurniture\VietPhuongAnFurniture\Views\Detail\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Origin));

#line default
#line hidden
            EndContext();
            BeginContext(864, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(927, 41, false);
#line 34 "D:\Project\VietPhuongAnFurniture\VietPhuongAnFurniture\Views\Detail\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Color));

#line default
#line hidden
            EndContext();
            BeginContext(968, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1032, 37, false);
#line 37 "D:\Project\VietPhuongAnFurniture\VietPhuongAnFurniture\Views\Detail\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Color));

#line default
#line hidden
            EndContext();
            BeginContext(1069, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1132, 41, false);
#line 40 "D:\Project\VietPhuongAnFurniture\VietPhuongAnFurniture\Views\Detail\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Stuff));

#line default
#line hidden
            EndContext();
            BeginContext(1173, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1237, 37, false);
#line 43 "D:\Project\VietPhuongAnFurniture\VietPhuongAnFurniture\Views\Detail\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Stuff));

#line default
#line hidden
            EndContext();
            BeginContext(1274, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1337, 40, false);
#line 46 "D:\Project\VietPhuongAnFurniture\VietPhuongAnFurniture\Views\Detail\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Size));

#line default
#line hidden
            EndContext();
            BeginContext(1377, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1441, 36, false);
#line 49 "D:\Project\VietPhuongAnFurniture\VietPhuongAnFurniture\Views\Detail\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Size));

#line default
#line hidden
            EndContext();
            BeginContext(1477, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1540, 41, false);
#line 52 "D:\Project\VietPhuongAnFurniture\VietPhuongAnFurniture\Views\Detail\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1581, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1645, 37, false);
#line 55 "D:\Project\VietPhuongAnFurniture\VietPhuongAnFurniture\Views\Detail\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1682, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1745, 42, false);
#line 58 "D:\Project\VietPhuongAnFurniture\VietPhuongAnFurniture\Views\Detail\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
            EndContext();
            BeginContext(1787, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1851, 38, false);
#line 61 "D:\Project\VietPhuongAnFurniture\VietPhuongAnFurniture\Views\Detail\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Status));

#line default
#line hidden
            EndContext();
            BeginContext(1889, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1952, 49, false);
#line 64 "D:\Project\VietPhuongAnFurniture\VietPhuongAnFurniture\Views\Detail\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.IsBestSelling));

#line default
#line hidden
            EndContext();
            BeginContext(2001, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2065, 45, false);
#line 67 "D:\Project\VietPhuongAnFurniture\VietPhuongAnFurniture\Views\Detail\Delete.cshtml"
       Write(Html.DisplayFor(model => model.IsBestSelling));

#line default
#line hidden
            EndContext();
            BeginContext(2110, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2173, 40, false);
#line 70 "D:\Project\VietPhuongAnFurniture\VietPhuongAnFurniture\Views\Detail\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.View));

#line default
#line hidden
            EndContext();
            BeginContext(2213, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2277, 36, false);
#line 73 "D:\Project\VietPhuongAnFurniture\VietPhuongAnFurniture\Views\Detail\Delete.cshtml"
       Write(Html.DisplayFor(model => model.View));

#line default
#line hidden
            EndContext();
            BeginContext(2313, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2376, 47, false);
#line 76 "D:\Project\VietPhuongAnFurniture\VietPhuongAnFurniture\Views\Detail\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(2423, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2487, 43, false);
#line 79 "D:\Project\VietPhuongAnFurniture\VietPhuongAnFurniture\Views\Detail\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(2530, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2593, 44, false);
#line 82 "D:\Project\VietPhuongAnFurniture\VietPhuongAnFurniture\Views\Detail\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CRUDDate));

#line default
#line hidden
            EndContext();
            BeginContext(2637, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2701, 40, false);
#line 85 "D:\Project\VietPhuongAnFurniture\VietPhuongAnFurniture\Views\Detail\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CRUDDate));

#line default
#line hidden
            EndContext();
            BeginContext(2741, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(2779, 206, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "80065aa390e98261397e985d9982a04952c5610a15218", async() => {
                BeginContext(2805, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(2815, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "80065aa390e98261397e985d9982a04952c5610a15611", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 90 "D:\Project\VietPhuongAnFurniture\VietPhuongAnFurniture\Views\Detail\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2851, 83, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        ");
                EndContext();
                BeginContext(2934, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "80065aa390e98261397e985d9982a04952c5610a17519", async() => {
                    BeginContext(2956, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
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
                BeginContext(2972, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2985, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VietPhuongAnFurniture.Models.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591