#pragma checksum "C:\Users\anhqu\OneDrive\Máy tính\VietPhuongAnFurniture\VietPhuongAnFurniture\VietPhuongAnFurniture\Views\Detail\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "163db322306d3f5f81ff84a3038d9b23fd03fbe2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Detail_Edit), @"mvc.1.0.view", @"/Views/Detail/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Detail/Edit.cshtml", typeof(AspNetCore.Views_Detail_Edit))]
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
#line 1 "C:\Users\anhqu\OneDrive\Máy tính\VietPhuongAnFurniture\VietPhuongAnFurniture\VietPhuongAnFurniture\Views\_ViewImports.cshtml"
using VietPhuongAnFurniture;

#line default
#line hidden
#line 2 "C:\Users\anhqu\OneDrive\Máy tính\VietPhuongAnFurniture\VietPhuongAnFurniture\VietPhuongAnFurniture\Views\_ViewImports.cshtml"
using VietPhuongAnFurniture.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"163db322306d3f5f81ff84a3038d9b23fd03fbe2", @"/Views/Detail/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"283ad1f1b0caa5581e4d2f338d73f59529f78500", @"/Views/_ViewImports.cshtml")]
    public class Views_Detail_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(47, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 3 "C:\Users\anhqu\OneDrive\Máy tính\VietPhuongAnFurniture\VietPhuongAnFurniture\VietPhuongAnFurniture\Views\Detail\Edit.cshtml"
  
    ViewData["Title"] = "Edit";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(138, 2233, true);
            WriteLiteral(@"
<style>
    .btn-margin-left-10 {
        margin-left: 10px;
    }

    .dx-htmleditor-content img {
        vertical-align: middle;
        padding-right: 10px;
    }

    .value-content {
        margin-top: 20px;
        overflow: auto;
        height: 110px;
        width: 100%;
        white-space: pre-wrap;
    }

    .html-editor {
        margin-bottom: 10px;
        background: white !important;
    }

    .checkbox {
        margin-top: 10px !important;
    }
    /*.register-form {
        background: none !important;
    }*/
    .widget-container {
        margin-right: 320px;
    }

    .content h4 {
        margin-bottom: 10px;
        font-weight: 500;
        font-size: 18px;
    }

    .content {
        margin-top: 50px;
        margin-left: 10px;
    }

    .selected-item {
        margin-bottom: 20px;
    }

    #selected-files {
        display: none;
    }

    .dx-gallery-item-content > img {
        width: 100%;
        height: 100");
            WriteLiteral(@"%;
        object-fit: contain;
    }

    .highlight {
        border: 1px solid red !important;
    }
</style>
<div class=""breadcrumb-box"">
    <div class=""container"">
        <ul class=""breadcrumb"">
            <li><a href=""index.html"">Trang chủ</a> </li>
            <li class=""active"">Cập nhật sản phẩm</li>
        </ul>
    </div>
</div><!-- .breadcrumb-box -->
<section id=""main"">
    <header class=""page-header"">
        <div class=""container"">
            <h1 class=""title"">Cập nhật sản phẩm</h1>
        </div>
    </header>
    <div class=""container"">
        <div class=""row"">
            <div class=""content login col-sm-12 col-md-12"">
                <div class=""row"">
                    <div class=""col-sm-12 col-md-12"">
                        <div class=""alert alert-error fade in alert-warning alert-dismissable"" style=""display: none"">
                            <i class=""fa fa-warning alert-icon""></i>
                            Không được để trống tên sản phẩm.
       ");
            WriteLiteral("                 </div>\r\n                        <label>Tên sản phẩm: <span class=\"required\">*</span></label>\r\n                        <input class=\"form-control\" type=\"text\" id=\"pName\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2371, "\"", 2398, 1);
#line 94 "C:\Users\anhqu\OneDrive\Máy tính\VietPhuongAnFurniture\VietPhuongAnFurniture\VietPhuongAnFurniture\Views\Detail\Edit.cshtml"
WriteAttributeValue("", 2379, Model.Product.Name, 2379, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2399, 134, true);
            WriteLiteral(" />\r\n\r\n                        <label>Mã sản phẩm:</label>\r\n                        <input class=\"form-control\" type=\"text\" id=\"pCode\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2533, "\"", 2560, 1);
#line 97 "C:\Users\anhqu\OneDrive\Máy tính\VietPhuongAnFurniture\VietPhuongAnFurniture\VietPhuongAnFurniture\Views\Detail\Edit.cshtml"
WriteAttributeValue("", 2541, Model.Product.Code, 2541, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2561, 132, true);
            WriteLiteral(" />\r\n\r\n                        <label>Xuất xứ:</label>\r\n                        <input class=\"form-control\" type=\"text\" id=\"pOrigin\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2693, "\"", 2722, 1);
#line 100 "C:\Users\anhqu\OneDrive\Máy tính\VietPhuongAnFurniture\VietPhuongAnFurniture\VietPhuongAnFurniture\Views\Detail\Edit.cshtml"
WriteAttributeValue("", 2701, Model.Product.Origin, 2701, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2723, 131, true);
            WriteLiteral(" />\r\n\r\n                        <label>Màu sắc:</label>\r\n                        <input class=\"form-control\" type=\"text\" id=\"pColor\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2854, "\"", 2882, 1);
#line 103 "C:\Users\anhqu\OneDrive\Máy tính\VietPhuongAnFurniture\VietPhuongAnFurniture\VietPhuongAnFurniture\Views\Detail\Edit.cshtml"
WriteAttributeValue("", 2862, Model.Product.Color, 2862, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2883, 133, true);
            WriteLiteral(" />\r\n\r\n                        <label>Chất liệu:</label>\r\n                        <input class=\"form-control\" type=\"text\" id=\"pStuff\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3016, "\"", 3044, 1);
#line 106 "C:\Users\anhqu\OneDrive\Máy tính\VietPhuongAnFurniture\VietPhuongAnFurniture\VietPhuongAnFurniture\Views\Detail\Edit.cshtml"
WriteAttributeValue("", 3024, Model.Product.Stuff, 3024, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3045, 133, true);
            WriteLiteral(" />\r\n\r\n                        <label>Kích thước:</label>\r\n                        <input class=\"form-control\" type=\"text\" id=\"pSize\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3178, "\"", 3205, 1);
#line 109 "C:\Users\anhqu\OneDrive\Máy tính\VietPhuongAnFurniture\VietPhuongAnFurniture\VietPhuongAnFurniture\Views\Detail\Edit.cshtml"
WriteAttributeValue("", 3186, Model.Product.Size, 3186, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3206, 133, true);
            WriteLiteral(" />\r\n\r\n                        <label>Giá: (VNĐ)</label>\r\n                        <input class=\"form-control\" type=\"text\" id=\"pPrice\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3339, "\"", 3367, 1);
#line 112 "C:\Users\anhqu\OneDrive\Máy tính\VietPhuongAnFurniture\VietPhuongAnFurniture\VietPhuongAnFurniture\Views\Detail\Edit.cshtml"
WriteAttributeValue("", 3347, Model.Product.Price, 3347, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3368, 942, true);
            WriteLiteral(@" />

                        <label>Thông tin:</label>
                        <input class=""form-control value-description"" type=""hidden"" id=""pDes"">
                        <div class=""value-content"" hidden></div>
                        <div class=""html-editor"">
                        </div>
                        <h5>Ảnh sản phẩm</h5>
                        <table id=""shopping-cart-table"" class=""shopping-cart-table table table-bordered table-striped"" style=""margin-bottom: 10px"">
                            <thead>
                                <tr>
                                    <th>Ảnh</th>
                                    <th class=""td-name"">Tên ảnh</th>
                                    <th class=""td-edit"">Vị trí</th>
                                    <th class=""td-remove""></th>
                                </tr>
                            </thead>
                            <tbody>
");
            EndContext();
#line 130 "C:\Users\anhqu\OneDrive\Máy tính\VietPhuongAnFurniture\VietPhuongAnFurniture\VietPhuongAnFurniture\Views\Detail\Edit.cshtml"
                                 for (int i = 0; i < Model.ProductImage.Count; i = i + 1)
                                {

#line default
#line hidden
            BeginContext(4436, 254, true);
            WriteLiteral("                                    <tr>\r\n                                        <td class=\"td-images\">\r\n                                            <a href=\"product-view.html\" class=\"product-image\">\r\n                                                <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 4690, "\"", 4742, 2);
            WriteAttributeValue("", 4696, "../../", 4696, 6, true);
#line 135 "C:\Users\anhqu\OneDrive\Máy tính\VietPhuongAnFurniture\VietPhuongAnFurniture\VietPhuongAnFurniture\Views\Detail\Edit.cshtml"
WriteAttributeValue("", 4702, Url.Content(Model.ProductImage[i].Path), 4702, 40, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4743, 339, true);
            WriteLiteral(@" alt="""" width=""70"" height=""70"">
                                            </a>
                                        </td>
                                        <td class=""td-name"">
                                            <h2 class=""product-name"">
                                                <a href=""product-view.html"">");
            EndContext();
            BeginContext(5083, 24, false);
#line 140 "C:\Users\anhqu\OneDrive\Máy tính\VietPhuongAnFurniture\VietPhuongAnFurniture\VietPhuongAnFurniture\Views\Detail\Edit.cshtml"
                                                                       Write(Model.ProductImage[i].Id);

#line default
#line hidden
            EndContext();
            BeginContext(5107, 216, true);
            WriteLiteral("</a>\r\n                                            </h2>\r\n                                        </td>\r\n                                        <td class=\"td-edit\">\r\n                                            <span>");
            EndContext();
            BeginContext(5324, 27, false);
#line 144 "C:\Users\anhqu\OneDrive\Máy tính\VietPhuongAnFurniture\VietPhuongAnFurniture\VietPhuongAnFurniture\Views\Detail\Edit.cshtml"
                                             Write(Model.ProductImage[i].Index);

#line default
#line hidden
            EndContext();
            BeginContext(5351, 230, true);
            WriteLiteral("</span>\r\n                                        </td>\r\n                                        <td class=\"td-remove\" style=\"cursor:pointer;\">\r\n                                            <p class=\"imgTextId\" style=\"display:none\">");
            EndContext();
            BeginContext(5582, 24, false);
#line 147 "C:\Users\anhqu\OneDrive\Máy tính\VietPhuongAnFurniture\VietPhuongAnFurniture\VietPhuongAnFurniture\Views\Detail\Edit.cshtml"
                                                                                 Write(Model.ProductImage[i].Id);

#line default
#line hidden
            EndContext();
            BeginContext(5606, 411, true);
            WriteLiteral(@"</p>
                                            <p class=""imgStt"" style=""display:none"">1</p>
                                            <a class=""product-remove"">
                                                <i class=""fa fa-trash-o""></i>
                                            </a><!-- .product-remove -->
                                        </td>
                                    </tr>
");
            EndContext();
#line 154 "C:\Users\anhqu\OneDrive\Máy tính\VietPhuongAnFurniture\VietPhuongAnFurniture\VietPhuongAnFurniture\Views\Detail\Edit.cshtml"
                                }

#line default
#line hidden
            BeginContext(6052, 1087, true);
            WriteLiteral(@"                            </tbody>
                        </table><!-- .shopping-cart-table -->
                        <h5>Thêm ảnh</h5>
                        <div id=""file-uploader""></div>
                        <div id=""galleryContainer"" style=""width: 100%; height: 500px; display: none"">
                        </div>
                        <div class=""checkbox"">
                            <label class="""">
                                <input type=""checkbox"" id=""pBes""> Sản phẩm bán chạy?
                            </label>
                        </div>
                        <div class=""buttons-box clearfix"">
                            <button class=""btn pull-left btn-success"" id=""btnSubmit"">Tạo sản phẩm</button>
                            <button id=""btnCancel"" class=""btn pull-left btn-danger btn-margin-left-10"">Hủy</button>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div><!-- .container -->
</s");
            WriteLiteral("ection><!-- #main -->\r\n<div id=\"desHide\" style=\"display: none\">");
            EndContext();
            BeginContext(7140, 25, false);
#line 176 "C:\Users\anhqu\OneDrive\Máy tính\VietPhuongAnFurniture\VietPhuongAnFurniture\VietPhuongAnFurniture\Views\Detail\Edit.cshtml"
                                   Write(Model.Product.Description);

#line default
#line hidden
            EndContext();
            BeginContext(7165, 1932, true);
            WriteLiteral(@"</div>
<script>
    $(document).ready(function () {

    });
    $("".html-editor"").html($(""#desHide"").text());
    // Html Code Editor
    $(function () {
        $("".html-editor"").dxHtmlEditor({
            height: 300,
            toolbar: {
                items: [
                    ""undo"", ""redo"", ""separator"",
                    {
                        formatName: ""size"",
                        formatValues: [""8pt"", ""10pt"", ""12pt"", ""14pt"", ""18pt"", ""24pt"", ""36pt""]
                    },
                    {
                        formatName: ""font"",
                        formatValues: [
                            ""Arial"", ""Courier New"", ""Georgia"", ""Impact"", ""Lucida Console"", ""Tahoma"", ""Times New Roman"",
                            ""Verdana""
                        ]
                    },
                    ""separator"", ""bold"", ""italic"", ""strike"", ""underline"", ""separator"",
                    ""alignLeft"", ""alignCenter"", ""alignRight"", ""alignJustify"", ""separator"",
      ");
            WriteLiteral(@"              {
                        formatName: ""header"",
                        formatValues: [false, 1, 2, 3, 4, 5]
                    }, ""separator"",
                    ""orderedList"", ""bulletList"", ""separator"",
                    ""color"", ""background"", ""separator"",
                    ""link"", ""image"", ""separator"",
                    ""clear"", ""codeBlock"", ""blockquote""
                ]
            },
            mediaResizing: {
                enabled: true
            },
            onValueChanged: function (e) {
                $("".value-content"").text(e.component.option(""value""));
                $("".value-description"").val($("".value-content"").text());
            }
        }).dxHtmlEditor(""instance"");
    });
    // Upload Image
    var imgSrcs = [];
    var imgFilesUploaded = [];
    var imgIndex = """";
    var lstFileLoadFromSv = [];
    $(function () {
");
            EndContext();
            BeginContext(9389, 2288, true);
            WriteLiteral(@"        if (lstFileLoadFromSv) {
            $(""#file-uploader"").dxFileUploader({
                multiple: true,
                accept: ""*"",
                value: [],
                uploadMode: ""useButtons"",
                onValueChanged: function(e) {
                    var indexDefault = 1;
                    imgIndex = """";
                    imgSrcs = [];
                    var files = e.value;
                    if (files.length > 0) {
                        $(""#galleryContainer"").css(""display"", ""block"");
                        $.each(files,
                            function(i, file) {
                                var fileURL = URL.createObjectURL(file);
                                imgSrcs.push({ imageSrc: fileURL, name: file.name });
                                imgIndex += file.name + "";"" + indexDefault + "","";
                                indexDefault++;
                            });

                        $(""#galleryContainer"").dxGallery({
         ");
            WriteLiteral(@"                   dataSource: imgSrcs
                        });
                    } else {
                        $(""#galleryContainer"").css(""display"", ""none"");
                        $(""#galleryContainer"").dxGallery({
                            dataSource: []
                        });
                    }
                },
                onUploaded: function(e) {
                    var file = e.file;
                    imgFilesUploaded.push(file);
                }
            }).dxFileUploader(""instance"");
        } else {
            console.log(""undefined"");
        }
    });
    // Submit
    $(function() {
        $(""#btnSubmit"").click(function(evt) {
            var files = imgFilesUploaded;
            var data = new FormData();
            if (files.length > 0) {
                imgIndex = imgIndex.substring(0, imgIndex.length - 1);
                for (var i = 0; i < files.length; i++) {
                    data.append('fileUploads', files[i]);
             ");
            WriteLiteral("   }\r\n                for (var i = 0; i < lstRemove.length; i++) {\r\n                    data.append(\'fileDeletes\', lstRemove[i]);\r\n                }\r\n            }\r\n            $.ajax({\r\n                type: \"POST\",\r\n                url: \"");
            EndContext();
            BeginContext(11678, 35, false);
#line 287 "C:\Users\anhqu\OneDrive\Máy tính\VietPhuongAnFurniture\VietPhuongAnFurniture\VietPhuongAnFurniture\Views\Detail\Edit.cshtml"
                 Write(Url.Action("EditProduct", "Detail"));

#line default
#line hidden
            EndContext();
            BeginContext(11713, 1961, true);
            WriteLiteral(@""",
                contentType: false,
                processData: false,
                data: data,
                success: function(message) {
                    alert(message);
                },
                error: function(e) {
                    console.log(e);
                }
            });
        });
    });
    // Remove Image
    var lstRemove = [];
    $('.td-remove').click(function (e) {
        $(""i"", this).toggleClass(""fa-trash-o fa-times"");
        var imgId = $("".imgTextId"", this)[0].innerHTML;
        console.log('text: ', imgId);
        if ($("".imgStt"", this)[0].innerHTML == ""1"") {
            $("".imgStt"", this)[0].innerHTML = ""0"";
            $(""i"", this).css(""color"", ""red"");
            lstRemove.push(imgId);
        } else {
            $("".imgStt"", this)[0].innerHTML = ""1"";
            $(""i"", this).css(""color"", ""black"");
            lstRemove.splice($.inArray(imgId, lstRemove), 1);
        }
        console.log('lstRemove: ', lstRemove);
    });");
            WriteLiteral(@"
    function base64toBlob(name, base64Data, contentType) {
        contentType = contentType || '';
        var sliceSize = 1024;
        var byteCharacters = atob(base64Data);
        var bytesLength = byteCharacters.length;
        var slicesCount = Math.ceil(bytesLength / sliceSize);
        var byteArrays = new Array(slicesCount);

        for (var sliceIndex = 0; sliceIndex < slicesCount; ++sliceIndex) {
            var begin = sliceIndex * sliceSize;
            var end = Math.min(begin + sliceSize, bytesLength);

            var bytes = new Array(end - begin);
            for (var offset = begin, i = 0; offset < end; ++i, ++offset) {
                bytes[i] = byteCharacters[offset].charCodeAt(0);
            }
            byteArrays[sliceIndex] = new Uint8Array(bytes);
        }
        return new File([new Blob(byteArrays, { type: contentType })], name, { type: contentType });
    }
</script>
");
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
