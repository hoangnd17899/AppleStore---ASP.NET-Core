#pragma checksum "/home/hoangnd/source/netcoreweb/AppleStore/AppleStore/Views/Checkout/index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a25a57cac6234c526ce3a142b9cac5994a74721"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Checkout_index), @"mvc.1.0.view", @"/Views/Checkout/index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a25a57cac6234c526ce3a142b9cac5994a74721", @"/Views/Checkout/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59570638cca05bb4f8830ba7a388887f49069620", @"/Views/_ViewImports.cshtml")]
    public class Views_Checkout_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/checkout.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("needs-validation"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/common.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/checkout.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/home/hoangnd/source/netcoreweb/AppleStore/AppleStore/Views/Checkout/index.cshtml"
  
    ViewData["Title"] = "Checkout";

#line default
#line hidden
#nullable disable
            DefineSection("css", async() => {
                WriteLiteral("\n     ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "1a25a57cac6234c526ce3a142b9cac5994a747216128", async() => {
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
            WriteLiteral("<div class=\"category_name\">CHECKOUT</div>\n\n    <div class=\"col-md-8 order-md-1 billingform\">\n          <h4 class=\"mb-3\">Checkout Details</h4>\n          ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1a25a57cac6234c526ce3a142b9cac5994a747217503", async() => {
                WriteLiteral("\n            <div class=\"row\">\n              <div class=\"col-md-6 mb-3\">\n                <label for=\"firstName\">First name</label>\n                <input type=\"text\" class=\"form-control\" id=\"firstName\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 508, "\"", 522, 0);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 523, "\"", 531, 0);
                EndWriteAttribute();
                WriteLiteral(@" required>
                <div class=""invalid-feedback"">
                  Valid first name is required.
                </div>
              </div>
              <div class=""col-md-6 mb-3"">
                <label for=""lastName"">Last name</label>
                <input type=""text"" class=""form-control"" id=""lastName""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 849, "\"", 863, 0);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 864, "\"", 872, 0);
                EndWriteAttribute();
                WriteLiteral(@" required>
                <div class=""invalid-feedback"">
                  Valid last name is required.
                </div>
              </div>
            </div>

            <div class=""mb-3"">
              <label for=""email"">Email <span class=""text-muted"">(Optional)</span></label>
              <input type=""email"" class=""form-control"" id=""email"" placeholder=""you@example.com"">
              <div class=""invalid-feedback"">
                Please enter a valid email address for shipping updates.
              </div>
            </div>

            <div class=""mb-3"">
              <label for=""address"">Address</label>
              <input type=""text"" class=""form-control"" id=""address"" placeholder=""1234 Main St"" required>
              <div class=""invalid-feedback"">
                Please enter your shipping address.
              </div>
            </div>

            <div class=""mb-3"">
              <label for=""address2"">Address 2 <span class=""text-muted"">(Optional)</span></label>
              <input type=");
                WriteLiteral(@"""text"" class=""form-control"" id=""address2"" placeholder=""Apartment or suite"">
            </div>

            <div class=""row"">
              <div class=""col-md-5 mb-3"">
                <label for=""country"">Country</label>
                <select class=""custom-select d-block w-100"" id=""country"" required>
                  ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1a25a57cac6234c526ce3a142b9cac5994a7472110292", async() => {
                    WriteLiteral("Choose...");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                  ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1a25a57cac6234c526ce3a142b9cac5994a7472111519", async() => {
                    WriteLiteral("United States");
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
                <div class=""invalid-feedback"">
                  Please select a valid country.
                </div>
              </div>
              <div class=""col-md-4 mb-3"">
                <label for=""state"">State</label>
                <select class=""custom-select d-block w-100"" id=""state"" required>
                  ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1a25a57cac6234c526ce3a142b9cac5994a7472112891", async() => {
                    WriteLiteral("Choose...");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                  ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1a25a57cac6234c526ce3a142b9cac5994a7472114118", async() => {
                    WriteLiteral("California");
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
                <div class=""invalid-feedback"">
                  Please provide a valid state.
                </div>
              </div>
              <div class=""col-md-3 mb-3"">
                <label for=""zip"">Zip</label>
                <input type=""text"" class=""form-control"" id=""zip""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 3058, "\"", 3072, 0);
                EndWriteAttribute();
                WriteLiteral(@" required>
                <div class=""invalid-feedback"">
                  Zip code required.
                </div>
              </div>
            </div>
            
            <hr class=""mb-4"">

            <h4 class=""mb-3"">Payment</h4>

            <div class=""d-block my-3"">
              <div class=""custom-control custom-radio"">
                <input id=""credit"" name=""paymentMethod"" type=""radio"" class=""custom-control-input"" checked required>
                <label class=""custom-control-label"" for=""credit"">Credit card</label>
              </div>
              <div class=""custom-control custom-radio"">
                <input id=""debit"" name=""paymentMethod"" type=""radio"" class=""custom-control-input"" required>
                <label class=""custom-control-label"" for=""debit"">Debit card</label>
              </div>
              <div class=""custom-control custom-radio"">
                <input id=""paypal"" name=""paymentMethod"" type=""radio"" class=""custom-control-input"" required>
                <label class=""c");
                WriteLiteral(@"ustom-control-label"" for=""paypal"">Paypal</label>
              </div>
            </div>
            <div class=""row"">
              <div class=""col-md-6 mb-3"">
                <label for=""cc-name"">Name on card</label>
                <input type=""text"" class=""form-control"" id=""cc-name""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 4384, "\"", 4398, 0);
                EndWriteAttribute();
                WriteLiteral(@" required>
                <small class=""text-muted"">Full name as displayed on card</small>
                <div class=""invalid-feedback"">
                  Name on card is required
                </div>
              </div>
              <div class=""col-md-6 mb-3"">
                <label for=""cc-number"">Credit card number</label>
                <input type=""text"" class=""form-control"" id=""cc-number""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 4803, "\"", 4817, 0);
                EndWriteAttribute();
                WriteLiteral(@" required>
                <div class=""invalid-feedback"">
                  Credit card number is required
                </div>
              </div>
            </div>
            <div class=""row"">
              <div class=""col-md-3 mb-3"">
                <label for=""cc-expiration"">Expiration</label>
                <input type=""text"" class=""form-control"" id=""cc-expiration""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 5196, "\"", 5210, 0);
                EndWriteAttribute();
                WriteLiteral(@" required>
                <div class=""invalid-feedback"">
                  Expiration date required
                </div>
              </div>
              <div class=""col-md-3 mb-3"">
                <label for=""cc-expiration"">CVV</label>
                <input type=""text"" class=""form-control"" id=""cc-cvv""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 5520, "\"", 5534, 0);
                EndWriteAttribute();
                WriteLiteral(@" required>
                <div class=""invalid-feedback"">
                  Security code required
                </div>
              </div>
            </div>
            <hr class=""mb-4"">
            <h4 class=""mb-3"">Total</h4>
            <h3 id=""total""></h3>
            <button class=""btn btn-dark btn-lg btn-block"" type=""submit"">Continue to checkout</button>
          ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("novalidate", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n        </div>\n");
            DefineSection("js", async() => {
                WriteLiteral("\n\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1a25a57cac6234c526ce3a142b9cac5994a7472120649", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n  ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1a25a57cac6234c526ce3a142b9cac5994a7472121731", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
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