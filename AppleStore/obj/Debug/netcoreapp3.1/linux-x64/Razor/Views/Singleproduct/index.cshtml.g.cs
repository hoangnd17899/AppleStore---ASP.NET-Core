#pragma checksum "/home/hoangnd/source/netcoreweb/AppleStore/AppleStore/Views/Singleproduct/index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f8600c3b05b18e517091e1c651bc5400406f38da"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Singleproduct_index), @"mvc.1.0.view", @"/Views/Singleproduct/index.cshtml")]
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
#line 1 "/home/hoangnd/source/netcoreweb/AppleStore/AppleStore/Views/_ViewImports.cshtml"
using AppleStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/hoangnd/source/netcoreweb/AppleStore/AppleStore/Views/_ViewImports.cshtml"
using AppleStore.DL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/hoangnd/source/netcoreweb/AppleStore/AppleStore/Views/_ViewImports.cshtml"
using AppleStore.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/hoangnd/source/netcoreweb/AppleStore/AppleStore/Views/_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "/home/hoangnd/source/netcoreweb/AppleStore/AppleStore/Views/Singleproduct/index.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8600c3b05b18e517091e1c651bc5400406f38da", @"/Views/Singleproduct/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59570638cca05bb4f8830ba7a388887f49069620", @"/Views/_ViewImports.cshtml")]
    public class Views_Singleproduct_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/single-product.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/home/hoangnd/source/netcoreweb/AppleStore/AppleStore/Views/Singleproduct/index.cshtml"
  
    ViewData["Title"] = "Single Product";
    CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");   // try with "en-US"
    string a = double.Parse(Model.Price.ToString()).ToString("#,###", cul.NumberFormat);

#line default
#line hidden
#nullable disable
            DefineSection("css", async() => {
                WriteLiteral("\n     ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f8600c3b05b18e517091e1c651bc5400406f38da4901", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
            }
            );
            WriteLiteral("    <div class=\"category_name\">SINGLE - PRODUCT</div>\n\n\t<div class=\"card single-product\">\n        <div class=\"row\">\n            <aside class=\"col-sm-5 border-right\">\n    <article class=\"gallery-wrap\"> \n    <div class=\"img-big-wrap\">\n      <div>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f8600c3b05b18e517091e1c651bc5400406f38da6378", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 593, "~/contents/images/products/", 593, 27, true);
#nullable restore
#line 18 "/home/hoangnd/source/netcoreweb/AppleStore/AppleStore/Views/Singleproduct/index.cshtml"
AddHtmlAttributeValue("", 620, Model.Image, 620, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</div>\n    </div> <!-- slider-product.// -->\n    </article> <!-- gallery-wrap .end// -->\n            </aside>\n            <aside class=\"col-sm-7\">\n    <article class=\"card-body p-5\">\n        <h3 class=\"title mb-3\">");
#nullable restore
#line 24 "/home/hoangnd/source/netcoreweb/AppleStore/AppleStore/Views/Singleproduct/index.cshtml"
                          Write(Model.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n    \n    <p class=\"price-detail-wrap\"> \n        <span class=\"price h3 text-warning\"> \n            <span class=\"currency\"></span><span class=\"num\">");
#nullable restore
#line 28 "/home/hoangnd/source/netcoreweb/AppleStore/AppleStore/Views/Singleproduct/index.cshtml"
                                                       Write(a);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ₫</span>\n        </span> \n    </p> <!-- price-detail-wrap .// -->\n    <dl class=\"item-property\">\n      <dt>Mô tả</dt>\n      <dd><p>");
#nullable restore
#line 33 "/home/hoangnd/source/netcoreweb/AppleStore/AppleStore/Views/Singleproduct/index.cshtml"
        Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p></dd>
    </dl>
    <dl class=""param param-feature"">
      <dt>Phiên bản</dt>
      <dd>12345611</dd>
    </dl>  <!-- item-property-hor .// -->
    <dl class=""param param-feature"">
      <dt>Màu sắc</dt>
      <dd>Black and white</dd>
    </dl>  <!-- item-property-hor .// -->
    <dl class=""param param-feature"">
      <dt>Xuất xứ</dt>
      <dd>");
#nullable restore
#line 45 "/home/hoangnd/source/netcoreweb/AppleStore/AppleStore/Views/Singleproduct/index.cshtml"
     Write(Model.Origin);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</dd>
    </dl>  <!-- item-property-hor .// -->
    
    <hr>
        <div class=""row"">
            <div class=""col-sm-5"">
                <dl class=""param param-inline"">
                  <dt>Số lượng: </dt>
                  <dd>
                      <select class=""form-control form-control-sm"" style=""width:70px;"">
                          ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f8600c3b05b18e517091e1c651bc5400406f38da10043", async() => {
                WriteLiteral(" 1 ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                          ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f8600c3b05b18e517091e1c651bc5400406f38da11009", async() => {
                WriteLiteral(" 2 ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                          ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f8600c3b05b18e517091e1c651bc5400406f38da11975", async() => {
                WriteLiteral(" 3 ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                      </select>
                  </dd>
                </dl>  <!-- item-property .// -->
            </div> <!-- col.// -->
            <div class=""col-sm-7"">
                <dl class=""param param-inline"">
                      <dt>Dung lượng: </dt>
                      <dd>
                          <label class=""form-check form-check-inline"">
                          <input class=""form-check-input"" type=""radio"" name=""inlineRadioOptions"" id=""inlineRadio2"" value=""option2"">
                          <span class=""form-check-label"">32GB</span>
                        </label>
                        <label class=""form-check form-check-inline"">
                          <input class=""form-check-input"" type=""radio"" name=""inlineRadioOptions"" id=""inlineRadio2"" value=""option2"">
                          <span class=""form-check-label"">64GB</span>
                        </label>
                        <label class=""form-check form-check-inline"">
                          <input class=""form-check-");
            WriteLiteral(@"input"" type=""radio"" name=""inlineRadioOptions"" id=""inlineRadio2"" value=""option2"">
                          <span class=""form-check-label"">128GB</span>
                        </label>
                      </dd>
                </dl>  <!-- item-property .// -->
            </div> <!-- col.// -->
        </div> <!-- row.// -->
        <hr>
        <a href=""#"" class=""btn btn-lg btn-dark text-uppercase""> <i class=""fas fa-shopping-cart""></i> THÊM VÀO GIỎ </a>
    </article> <!-- card-body.// -->
            </aside> <!-- col.// -->
        </div> <!-- row.// -->
    </div> <!-- card.// -->
    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; }
    }
}
#pragma warning restore 1591