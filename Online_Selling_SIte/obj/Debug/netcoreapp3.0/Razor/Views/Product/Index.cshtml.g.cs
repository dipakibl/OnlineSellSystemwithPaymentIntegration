#pragma checksum "D:\IBL\Online_Selling_SIte\Online_Selling_SIte\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c6cc34cc84dee807d360a8a6feea95a244516d33"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
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
#nullable restore
#line 1 "D:\IBL\Online_Selling_SIte\Online_Selling_SIte\Views\_ViewImports.cshtml"
using Online_Selling_SIte;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\IBL\Online_Selling_SIte\Online_Selling_SIte\Views\_ViewImports.cshtml"
using Online_Selling_SIte.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6cc34cc84dee807d360a8a6feea95a244516d33", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"861796b981632b03ed5209278ad23ad63fd71b13", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Online_Selling_SIte.Models.Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Content/plugins/jQuery/jQuery-2.1.3.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\IBL\Online_Selling_SIte\Online_Selling_SIte\Views\Product\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div>
    <section class=""content"">
        <div class=""row"">
            <div class=""col-md-pull-6"">
                <!-- general form elements -->
                <div class=""box box-primary"">
                    <div class=""box-header"">
                        <h3 class=""box-title""><b>Add Product</b></h3>
                        <hr />
                    </div><!-- /.box-header -->
                    <!-- form start -->
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c6cc34cc84dee807d360a8a6feea95a244516d335541", async() => {
                WriteLiteral("\r\n                        <div class=\"box-body\">\r\n                            <div class=\"form-group\">\r\n                                <label for=\"ProductName\">Product Name</label>\r\n                                ");
#nullable restore
#line 24 "D:\IBL\Online_Selling_SIte\Online_Selling_SIte\Views\Product\Index.cshtml"
                           Write(Html.TextBoxFor(model => model.ProductName, htmlAttributes: new { @type = "text", @class = "form-control", @id = "ProductName", @required = "required", @placeholder = "Enter Product Name" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </div>\r\n                            <div class=\"form-group\">\r\n                                <label for=\"ProductName\">Category</label>\r\n                                ");
#nullable restore
#line 28 "D:\IBL\Online_Selling_SIte\Online_Selling_SIte\Views\Product\Index.cshtml"
                           Write(Html.TextBoxFor(model => model.Category, htmlAttributes: new { @type = "text", @class = "form-control", @id = "ProductCat", @required = "required", @placeholder = "Enter Category" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

                            </div>
                            <div class=""form-group"">
                                <label for=""Quntity"">Qnt</label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                ");
#nullable restore
#line 33 "D:\IBL\Online_Selling_SIte\Online_Selling_SIte\Views\Product\Index.cshtml"
                           Write(Html.TextBoxFor(model => model.Qnt, htmlAttributes: new { @type = "number", @class = "form-controlqnt", @id = "Quntity", @required = "required", @placeholder = "Qnt" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                            </div>
                            <div class=""form-group"">
                                <label for=""Price""> Price</label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                ");
#nullable restore
#line 37 "D:\IBL\Online_Selling_SIte\Online_Selling_SIte\Views\Product\Index.cshtml"
                           Write(Html.TextBoxFor(model => model.Price, htmlAttributes: new { @type = "text", @class = "form-controlqnt", @id = "Price", @required = "required", @placeholder = "Price" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </div>\r\n                            <div class=\"form-group\">\r\n                                <label for=\"Sale Price\">Sale Price</label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;\r\n                                ");
#nullable restore
#line 41 "D:\IBL\Online_Selling_SIte\Online_Selling_SIte\Views\Product\Index.cshtml"
                           Write(Html.TextBoxFor(model => model.Saleprice, htmlAttributes: new { @type = "text", @class = "form-controlqnt", @id = "SalePrice", @required = "required", @placeholder = "Sale Price" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </div>\r\n                            <div class=\"form-group\">\r\n                                <label for=\"exampleInputFile\">Image</label>\r\n                                ");
#nullable restore
#line 45 "D:\IBL\Online_Selling_SIte\Online_Selling_SIte\Views\Product\Index.cshtml"
                           Write(Html.TextBoxFor(model => model.Image, htmlAttributes: new { @type = "file", @id = "Image", @class = "form-control", @required = "required", @Name = "Photo" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
                WriteLiteral("\r\n\r\n                            </div>\r\n                            <div class=\"form-group\">\r\n                                <label>Discription</label>\r\n                                ");
#nullable restore
#line 52 "D:\IBL\Online_Selling_SIte\Online_Selling_SIte\Views\Product\Index.cshtml"
                           Write(Html.TextAreaFor(model => model.Discription, htmlAttributes: new { @type = "textarea", @class = "form-control", @rows = "3", @placeholder = "Enter Discription ..." }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                            </div>
                            <div class=""checkbox"">
                                <label>
                                    <input type=""checkbox"" name=""isactive""> <b>IsActive</b>
                                </label>
                            </div>
                        </div><!-- /.box-body -->
                        <div class=""box-footer"">
                            <button type=""submit"" class=""btn btn-primary"">Submit</button>
                        </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute(",", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div><!-- /.box -->\r\n            </div>\r\n\r\n        </div>\r\n\r\n    </section>\r\n</div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c6cc34cc84dee807d360a8a6feea95a244516d3312686", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 72 "D:\IBL\Online_Selling_SIte\Online_Selling_SIte\Views\Product\Index.cshtml"
 if (ViewBag.Message == "Success")
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <script type=\"text/javascript\">\r\n        $(document).ready(function () {\r\n            toastr.success(\'Product Added Successfully..!!\')\r\n        })\r\n    </script>\r\n");
#nullable restore
#line 79 "D:\IBL\Online_Selling_SIte\Online_Selling_SIte\Views\Product\Index.cshtml"
}
else if (ViewBag.Message == "Error")
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <script type=\"text/javascript\">\r\n        $(document).ready(function () {\r\n            toastr.error(\'Error..!\')\r\n        })\r\n    </script>\r\n");
#nullable restore
#line 87 "D:\IBL\Online_Selling_SIte\Online_Selling_SIte\Views\Product\Index.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Online_Selling_SIte.Models.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591