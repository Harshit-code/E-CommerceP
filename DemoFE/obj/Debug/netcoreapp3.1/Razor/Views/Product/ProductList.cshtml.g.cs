#pragma checksum "F:\Final Interview\DemoFE\Views\Product\ProductList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "73587c4161d40eaae17f6ed85218d60cfde3bbad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_ProductList), @"mvc.1.0.view", @"/Views/Product/ProductList.cshtml")]
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
#line 1 "F:\Final Interview\DemoFE\Views\_ViewImports.cshtml"
using DemoFE;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Final Interview\DemoFE\Views\_ViewImports.cshtml"
using DemoFE.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"73587c4161d40eaae17f6ed85218d60cfde3bbad", @"/Views/Product/ProductList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f2eaf06816155905898e191e175783d44e8accf", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_ProductList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<ProductListView>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/styles.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/CustomStyleSheet.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/scripts.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("bg-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "F:\Final Interview\DemoFE\Views\Product\ProductList.cshtml"
   ViewData["Title"] = "Product View "; 

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\Final Interview\DemoFE\Views\Product\ProductList.cshtml"
   var data = Model; 

#line default
#line hidden
#nullable disable
            WriteLiteral("<html lang=\"en\">\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "73587c4161d40eaae17f6ed85218d60cfde3bbad5465", async() => {
                WriteLiteral("\n    <meta charset=\"utf-8\" />\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\" />\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1, shrink-to-fit=no\" />\n    <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 329, "\"", 339, 0);
                EndWriteAttribute();
                WriteLiteral(" />\n    <meta name=\"author\"");
                BeginWriteAttribute("content", " content=\"", 367, "\"", 377, 0);
                EndWriteAttribute();
                WriteLiteral(" />\n    <title>Product View Page</title>\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "73587c4161d40eaae17f6ed85218d60cfde3bbad6335", async() => {
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
                WriteLiteral("\n    <link rel=\"stylesheet\" href=\"https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css\" integrity=\"sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm\" crossorigin=\"anonymous\">\n");
                WriteLiteral("    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "73587c4161d40eaae17f6ed85218d60cfde3bbad7768", async() => {
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
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "73587c4161d40eaae17f6ed85218d60cfde3bbad8944", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.3/js/all.min.js"" crossorigin=""anonymous""></script>
    <style>
        /* .container{
            width:100%;
            margin-top:10%;
            font-family:serif;
            letter-spacing:1px;
        }*/
    </style>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "73587c4161d40eaae17f6ed85218d60cfde3bbad11126", async() => {
                WriteLiteral("\n    <div class=\"container\">\n        <h2>New Arrivals</h2>\n        <div class=\"row\">\n");
#nullable restore
#line 31 "F:\Final Interview\DemoFE\Views\Product\ProductList.cshtml"
             if (@TempData["OrderSuccess"] != null)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("<h1>");
#nullable restore
#line 33 "F:\Final Interview\DemoFE\Views\Product\ProductList.cshtml"
Write(TempData["OrderSuccess"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1>            ");
#nullable restore
#line 33 "F:\Final Interview\DemoFE\Views\Product\ProductList.cshtml"
                                              }

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "F:\Final Interview\DemoFE\Views\Product\ProductList.cshtml"
             for (var i = 0; i < Model.Count(); i++)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("<div class=\"col-md-4\">\n");
#nullable restore
#line 38 "F:\Final Interview\DemoFE\Views\Product\ProductList.cshtml"
     using (Html.BeginForm("ProductList", "Product", FormMethod.Post))
    {

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "F:\Final Interview\DemoFE\Views\Product\ProductList.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div class=\"product-top\">\n\n");
                WriteLiteral("\n                        <input type=\"text\" name=\"ProductId\" hidden");
                BeginWriteAttribute("value", " value=\"", 2013, "\"", 2040, 1);
#nullable restore
#line 46 "F:\Final Interview\DemoFE\Views\Product\ProductList.cshtml"
WriteAttributeValue("", 2021, Model[i].ProductId, 2021, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n                        <input type=\"text\" name=\"ProductVariationId\" hidden");
                BeginWriteAttribute("value", " value=\"", 2120, "\"", 2156, 1);
#nullable restore
#line 47 "F:\Final Interview\DemoFE\Views\Product\ProductList.cshtml"
WriteAttributeValue("", 2128, Model[i].ProductVariationId, 2128, 28, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n                        <h3 style=\"block-size:auto\">");
#nullable restore
#line 48 "F:\Final Interview\DemoFE\Views\Product\ProductList.cshtml"
                                               Write(Model[i].Brand);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\n                        <img style=\" width: 300px;height:300px\"");
                BeginWriteAttribute("src", " src=", 2297, "", 2328, 1);
#nullable restore
#line 49 "F:\Final Interview\DemoFE\Views\Product\ProductList.cshtml"
WriteAttributeValue("", 2302, Model[i].PrimaryImageName, 2302, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                        <div class=""overlay"">
                            <button type=""button"" class=""btn btn-secondary"" title=""Quick Shop"">
                                <i class=""fa fa-eye""></i>
                            </button>
                            <button type=""button"" class=""btn btn-secondary"" title=""Add to wishlist"">
                                <i class=""fa fa-heart-o""></i>
                            </button>
                            <button type=""submit"" class=""btn btn-secondary"" title=""Add to cart"">
                                <i class=""fa fa-shopping-cart""></i>
                            </button><br />
                            <span style="" width:45px; height: 20px;"">Qnty want to add in cart<input type=""number"" name=""qnty"" value=""1"" /></span>
                        </div>
                    </div>
                                        <div class=""available_title"">Available: <span>");
#nullable restore
#line 63 "F:\Final Interview\DemoFE\Views\Product\ProductList.cshtml"
                                                                                 Write(Model[i].QunatityAvailable);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</span></div>
                                                            <div class=""product-bottom text-center "">

                                                                <i class=""fa fa-star""></i>
                                                                <i class=""fa fa-star""></i>
                                                                <i class=""fa fa-star""></i>
                                                                <i class=""fa fa-star-half-o""></i>
                                                                <i class=""fa fa-star-half-o""></i>
                                                                <h3>");
#nullable restore
#line 71 "F:\Final Interview\DemoFE\Views\Product\ProductList.cshtml"
                                                               Write(Model[i].PName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\n                                                                <h3>₹");
#nullable restore
#line 72 "F:\Final Interview\DemoFE\Views\Product\ProductList.cshtml"
                                                                Write(Model[i].Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\n                                                                <span>");
#nullable restore
#line 73 "F:\Final Interview\DemoFE\Views\Product\ProductList.cshtml"
                                                                 Write(Model[i].PDescription);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span><br />\n");
#nullable restore
#line 74 "F:\Final Interview\DemoFE\Views\Product\ProductList.cshtml"
                                                                 if (@Model[i].IsReturnable == true)
                                                                {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                            <img src=""https://images-na.ssl-images-amazon.com/images/G/31/A2I-Convert/mobile/IconFarm/icon-returns-struck._CB484058890_.png""
                                                 class=""a-image-wrapper a-manually-loaded icon-box""");
                BeginWriteAttribute("id", " id=\"", 4607, "\"", 4612, 0);
                EndWriteAttribute();
                WriteLiteral(@" style=""height:35px;width:35px;"" alt=""Not Returnable""
                                                 data-a-image-source=""https://images-na.ssl-images-amazon.com/images/G/31/A2I-Convert/mobile/IconFarm/icon-returns-struck._CB484058890_.png"">
                                                                    <h4>Is Returnable</h4> ");
#nullable restore
#line 79 "F:\Final Interview\DemoFE\Views\Product\ProductList.cshtml"
                                                                                           }
                                                                                        else
                                                                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                                    <h4>Not Returnable</h4>");
#nullable restore
#line 82 "F:\Final Interview\DemoFE\Views\Product\ProductList.cshtml"
                                                                                           }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                            </div>");
#nullable restore
#line 83 "F:\Final Interview\DemoFE\Views\Product\ProductList.cshtml"
                                                                  }

#line default
#line hidden
#nullable disable
                WriteLiteral("\n</div>            ");
#nullable restore
#line 85 "F:\Final Interview\DemoFE\Views\Product\ProductList.cshtml"
                  }

#line default
#line hidden
#nullable disable
                WriteLiteral("\n\n\n\n\n\n\n\n");
                WriteLiteral("            <script src=\"https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js\" crossorigin=\"anonymous\"></script>\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "73587c4161d40eaae17f6ed85218d60cfde3bbad20092", async() => {
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
                WriteLiteral(@"
            <script src=""https://code.jquery.com/jquery-3.2.1.slim.min.js"" integrity=""sha384-KJ3o2DKtIkvYIK3UENzmM7KCkRr/rE9/Qpg6aAZGJwFDMVNA/GpGFF93hXpG5KkN"" crossorigin=""anonymous""></script>
            <script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.9/umd/popper.min.js"" integrity=""sha384-ApNbgh9B+Y1QKtv3Rn7W3mgPxhU9K/ScQsAP7hUibX39j7fakFPskvXusvfa0b4Q"" crossorigin=""anonymous""></script>
            <script src=""https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js"" integrity=""sha384-JZR6Spejh4U02d8jOt6vLEHfe/JQGiRRSQQxSfFWpi1MquVdAyjUar5+76PVCmYl"" crossorigin=""anonymous""></script>

        </div>
        <div>
        </div>
    </div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</html>\n\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\n");
#nullable restore
#line 117 "F:\Final Interview\DemoFE\Views\Product\ProductList.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<ProductListView>> Html { get; private set; }
    }
}
#pragma warning restore 1591
