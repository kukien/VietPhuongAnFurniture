#pragma checksum "D:\Project\VietPhuongAnFurniture\VietPhuongAnFurniture\Views\Home\Categories.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ec952b863eca9b347822b810dd218e4ac9242846"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Categories), @"mvc.1.0.view", @"/Views/Home/Categories.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Categories.cshtml", typeof(AspNetCore.Views_Home_Categories))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec952b863eca9b347822b810dd218e4ac9242846", @"/Views/Home/Categories.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"283ad1f1b0caa5581e4d2f338d73f59529f78500", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Categories : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(124, 366, true);
            WriteLiteral(@"    <aside class=""widget menu"">
        <header>
            <h3 class=""title"">Danh sách sản phẩm</h3>
        </header>
        <nav>
            <ul>
                <li><a href=""#"">Mẫu nhà ở</a></li>
                <li class=""parent active"">
                    <a href=""#""><span class=""open-sub""></span>Sofa</a>
                    <ul class=""sub"">

");
            EndContext();
#line 16 "D:\Project\VietPhuongAnFurniture\VietPhuongAnFurniture\Views\Home\Categories.cshtml"
                         for (int i = 0; i < Model.allProductTypes.Count; i++)
                        {

#line default
#line hidden
            BeginContext(597, 44, true);
            WriteLiteral("                            <li><a href=\"#\">");
            EndContext();
            BeginContext(642, 29, false);
#line 18 "D:\Project\VietPhuongAnFurniture\VietPhuongAnFurniture\Views\Home\Categories.cshtml"
                                       Write(Model.allProductTypes[i].Name);

#line default
#line hidden
            EndContext();
            BeginContext(671, 11, true);
            WriteLiteral("</a></li>\r\n");
            EndContext();
#line 19 "D:\Project\VietPhuongAnFurniture\VietPhuongAnFurniture\Views\Home\Categories.cshtml"
                        }

#line default
#line hidden
            BeginContext(709, 52, true);
            WriteLiteral("\r\n                    </ul>\r\n                </li>\r\n");
            EndContext();
            BeginContext(1817, 1470, true);
            WriteLiteral(@"            </ul>
        </nav>
    </aside><!-- .menu-->
    <aside class=""widget shop-by"">
        <header>
            <h3 class=""title"">Shop By</h3>
        </header>
        <div class=""section"">
            <h4 class=""subtitle"">Currently Shopping by:</h4>
            <ul class=""selected"">
                <li>
                    <span><i class=""fa fa-angle-right""></i> Price: <span>$0.00 - $999.99</span></span>
                    <a href=""#"" class=""close"">×</a>
                </li>
                <li>
                    <span><i class=""fa fa-angle-right""></i> Manufacturer: <span>Apple</span></span>
                    <a href=""#"" class=""close"">×</a>
                </li>
            </ul>
        </div>
        <div class=""section"">
            <h4 class=""subtitle"">Display Size</h4>
            <ul>
                <li><i class=""fa fa-angle-right""></i> <a href=""#"">11-inch</a></li>
                <li><i class=""fa fa-angle-right""></i> <a href=""#"">13-inch</a></li>
            ");
            WriteLiteral(@"    <li><i class=""fa fa-angle-right""></i> <a href=""#"">15-inch</a></li>
            </ul>
        </div>
        <div class=""section"">
            <h4 class=""subtitle"">Color</h4>
            <ul>
                <li><i class=""fa fa-angle-right""></i> <a href=""#"">White</a></li>
                <li><i class=""fa fa-angle-right""></i> <a href=""#"">Blue</a></li>
                <li><i class=""fa fa-angle-right""></i> <a href=""#"">Green</a></li>
");
            EndContext();
            BeginContext(3435, 72, true);
            WriteLiteral("            </ul>\r\n        </div>\r\n    </aside>\r\n    <!-- .shop-by -->\r\n");
            EndContext();
            BeginContext(4159, 7, true);
            WriteLiteral("\r\n   \r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591