#pragma checksum "C:\Users\hamid.mammadov\Desktop\P225Allup\P225Allup\Views\Shared\_ProductModalPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "89e795e0c08c61a94ae45e18942345e85e185f02"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ProductModalPartial), @"mvc.1.0.view", @"/Views/Shared/_ProductModalPartial.cshtml")]
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
#line 2 "C:\Users\hamid.mammadov\Desktop\P225Allup\P225Allup\Views\_ViewImports.cshtml"
using P225Allup.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\hamid.mammadov\Desktop\P225Allup\P225Allup\Views\_ViewImports.cshtml"
using P225Allup.ViewModels.Home;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89e795e0c08c61a94ae45e18942345e85e185f02", @"/Views/Shared/_ProductModalPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52b12eb2673f4f1f6b4517db21cdec6d1df71659", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ProductModalPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n    <div class=\"row\">\r\n        <div class=\"col-md-6\">\r\n            <div class=\"product-quick-view-image mt-30\">\r\n                <div class=\"quick-view-image\">\r\n");
#nullable restore
#line 7 "C:\Users\hamid.mammadov\Desktop\P225Allup\P225Allup\Views\Shared\_ProductModalPartial.cshtml"
                     foreach (ProductImage productImage in Model.ProductImages)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"single-view-image\">\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 372, "\"", 425, 2);
            WriteAttributeValue("", 378, "assets/images/product-quick/", 378, 28, true);
#nullable restore
#line 10 "C:\Users\hamid.mammadov\Desktop\P225Allup\P225Allup\Views\Shared\_ProductModalPartial.cshtml"
WriteAttributeValue("", 406, productImage.Image, 406, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"product\">\r\n                        </div>\r\n");
#nullable restore
#line 12 "C:\Users\hamid.mammadov\Desktop\P225Allup\P225Allup\Views\Shared\_ProductModalPartial.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n                <ul class=\"quick-view-thumb\">\r\n");
#nullable restore
#line 15 "C:\Users\hamid.mammadov\Desktop\P225Allup\P225Allup\Views\Shared\_ProductModalPartial.cshtml"
                     foreach (ProductImage productImage in Model.ProductImages)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li>\r\n                            <div class=\"single-thumb\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "89e795e0c08c61a94ae45e18942345e85e185f025356", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 801, "~/assets/images/product-quick/", 801, 30, true);
#nullable restore
#line 19 "C:\Users\hamid.mammadov\Desktop\P225Allup\P225Allup\Views\Shared\_ProductModalPartial.cshtml"
AddHtmlAttributeValue("", 831, productImage.Image, 831, 19, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </div>\r\n                        </li>\r\n");
#nullable restore
#line 22 "C:\Users\hamid.mammadov\Desktop\P225Allup\P225Allup\Views\Shared\_ProductModalPartial.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </ul>\r\n            </div> <!-- Modal Quick View Image -->\r\n        </div>\r\n        <div class=\"col-md-6\">\r\n            <div class=\"product-quick-view-content mt-30\">\r\n                <h3 class=\"product-title\">");
#nullable restore
#line 28 "C:\Users\hamid.mammadov\Desktop\P225Allup\P225Allup\Views\Shared\_ProductModalPartial.cshtml"
                                     Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
                <p class=""reference"">Reference: demo_12</p>
                <ul class=""rating"">
                    <li class=""rating-on""><i class=""fas fa-star""></i></li>
                    <li class=""rating-on""><i class=""fas fa-star""></i></li>
                    <li class=""rating-on""><i class=""fas fa-star""></i></li>
                    <li class=""rating-on""><i class=""fas fa-star""></i></li>
                    <li class=""rating-on""><i class=""fas fa-star""></i></li>
                </ul>
                <div class=""product-prices"">
");
#nullable restore
#line 38 "C:\Users\hamid.mammadov\Desktop\P225Allup\P225Allup\Views\Shared\_ProductModalPartial.cshtml"
                     if (Model.DiscountPrice > 0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span class=\"sale-price\"> €");
#nullable restore
#line 40 "C:\Users\hamid.mammadov\Desktop\P225Allup\P225Allup\Views\Shared\_ProductModalPartial.cshtml"
                                              Write(Model.Price.ToString("F2"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        <span class=\"regular-price\">€");
#nullable restore
#line 41 "C:\Users\hamid.mammadov\Desktop\P225Allup\P225Allup\Views\Shared\_ProductModalPartial.cshtml"
                                                Write(Model.DiscountPrice.ToString("F2"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        <span class=\"save\">Save ");
#nullable restore
#line 42 "C:\Users\hamid.mammadov\Desktop\P225Allup\P225Allup\Views\Shared\_ProductModalPartial.cshtml"
                                            Write((100-((Model.DiscountPrice * 100) / Model.Price)).ToString("F2"));

#line default
#line hidden
#nullable disable
            WriteLiteral("%</span>\r\n");
#nullable restore
#line 43 "C:\Users\hamid.mammadov\Desktop\P225Allup\P225Allup\Views\Shared\_ProductModalPartial.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span class=\"regular-price\">€");
#nullable restore
#line 46 "C:\Users\hamid.mammadov\Desktop\P225Allup\P225Allup\Views\Shared\_ProductModalPartial.cshtml"
                                                Write(Model.Price.ToString("F2"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 47 "C:\Users\hamid.mammadov\Desktop\P225Allup\P225Allup\Views\Shared\_ProductModalPartial.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n                <p class=\"product-description\" ><div style=\"height:100px;overflow:scroll;\">\r\n    ");
#nullable restore
#line 50 "C:\Users\hamid.mammadov\Desktop\P225Allup\P225Allup\Views\Shared\_ProductModalPartial.cshtml"
Write(Html.Raw(Model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
</div></p>
                <div class=""product-size-color flex-wrap"">
                    <div class=""product-quantity"">
                        <h5 class=""title"">Quantity</h5>
                        <div class=""quantity d-flex"">
                            <button type=""button"" id=""sub"" class=""sub""><i class=""fal fa-minus""></i></button>
                            <input type=""text"" value=""1"" />
                            <button type=""button"" id=""add"" class=""add""><i class=""fal fa-plus""></i></button>
                        </div>
                    </div>
                </div>
                <div class=""product-add-cart"">
                    <button><i class=""icon ion-bag""></i> Add to cart</button>
                </div>
                <div class=""product-wishlist-compare"">
                    <ul class=""d-flex flex-wrap"">
                        <li><a href=""#""><i class=""fal fa-heart""></i> Add to wishlist</a></li>
                        <li><a href=""#""><i class=""fal fa-repeat""></i>");
            WriteLiteral(@" Add to compare</a></li>
                    </ul>
                </div>
                <div class=""product-share d-flex"">
                    <p>Share</p>
                    <ul class=""social media-body"">
                        <li><a href=""#""><i class=""fab fa-facebook-f""></i></a></li>
                        <li><a href=""#""><i class=""fab fa-twitter""></i></a></li>
                        <li><a href=""#""><i class=""fab fa-google""></i></a></li>
                        <li><a href=""#""><i class=""fab fa-pinterest-p""></i></a></li>
                    </ul>
                </div>
            </div> <!-- Modal Quick View Content -->
        </div>
    </div> <!-- row -->");
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
