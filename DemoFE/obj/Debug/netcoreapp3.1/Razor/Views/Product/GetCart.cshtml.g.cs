#pragma checksum "F:\Final Interview\DemoFE\Views\Product\GetCart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a51ca684816dd1abbf1a9620c53778029cd1e892"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_GetCart), @"mvc.1.0.view", @"/Views/Product/GetCart.cshtml")]
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
#nullable restore
#line 1 "F:\Final Interview\DemoFE\Views\Product\GetCart.cshtml"
using DemoP.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a51ca684816dd1abbf1a9620c53778029cd1e892", @"/Views/Product/GetCart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f2eaf06816155905898e191e175783d44e8accf", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_GetCart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<CartViewModel>>
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
#line 3 "F:\Final Interview\DemoFE\Views\Product\GetCart.cshtml"
   ViewData["Title"] = "Product View "; 

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\Final Interview\DemoFE\Views\Product\GetCart.cshtml"
   var data = Model; 

#line default
#line hidden
#nullable disable
            WriteLiteral("<html lang=\"en\">\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a51ca684816dd1abbf1a9620c53778029cd1e8925591", async() => {
                WriteLiteral("\n    <meta charset=\"utf-8\" />\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\" />\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1, shrink-to-fit=no\" />\n    <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 348, "\"", 358, 0);
                EndWriteAttribute();
                WriteLiteral(" />\n    <meta name=\"author\"");
                BeginWriteAttribute("content", " content=\"", 386, "\"", 396, 0);
                EndWriteAttribute();
                WriteLiteral(" />\n    <title>Product View Page</title>\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a51ca684816dd1abbf1a9620c53778029cd1e8926461", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a51ca684816dd1abbf1a9620c53778029cd1e8927894", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a51ca684816dd1abbf1a9620c53778029cd1e8929070", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a51ca684816dd1abbf1a9620c53778029cd1e89211273", async() => {
                WriteLiteral("\n    <div class=\"container\">\n        <h2>Your Selected Items</h2>\n");
#nullable restore
#line 32 "F:\Final Interview\DemoFE\Views\Product\GetCart.cshtml"
         if (@ViewBag.ProductAddError != null)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("<span><strong>");
#nullable restore
#line 34 "F:\Final Interview\DemoFE\Views\Product\GetCart.cshtml"
         Write(ViewBag.ProductAddError);

#line default
#line hidden
#nullable disable
                WriteLiteral("</strong></span>");
#nullable restore
#line 34 "F:\Final Interview\DemoFE\Views\Product\GetCart.cshtml"
                                                      }

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "F:\Final Interview\DemoFE\Views\Product\GetCart.cshtml"
         if (@ViewBag.EmptyCart != null)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("<span><strong>");
#nullable restore
#line 37 "F:\Final Interview\DemoFE\Views\Product\GetCart.cshtml"
         Write(ViewBag.EmptyCart);

#line default
#line hidden
#nullable disable
                WriteLiteral("</strong></span>");
#nullable restore
#line 37 "F:\Final Interview\DemoFE\Views\Product\GetCart.cshtml"
                                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div class=\"row\">\n");
#nullable restore
#line 39 "F:\Final Interview\DemoFE\Views\Product\GetCart.cshtml"
             for (var i = 0; i < Model.Count(); i++)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("<div class=\"col-md-4\">\n");
#nullable restore
#line 42 "F:\Final Interview\DemoFE\Views\Product\GetCart.cshtml"
     using (Html.BeginForm("GetCart", "Product", FormMethod.Post))
    {

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "F:\Final Interview\DemoFE\Views\Product\GetCart.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div class=\"product-top\">\n                        <h3 style=\"block-size:auto\">");
#nullable restore
#line 46 "F:\Final Interview\DemoFE\Views\Product\GetCart.cshtml"
                                               Write(Model[i].Brand);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\n                        <img style=\" width: 100px;height:100px\"");
                BeginWriteAttribute("src", " src=", 1984, "", 2015, 1);
#nullable restore
#line 47 "F:\Final Interview\DemoFE\Views\Product\GetCart.cshtml"
WriteAttributeValue("", 1989, Model[i].PrimaryImageName, 1989, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n                    </div>\n                                        <div id=\"dvProdListing\" class=\"product-bottom text-center \">\n\n                                            <h3>");
#nullable restore
#line 51 "F:\Final Interview\DemoFE\Views\Product\GetCart.cshtml"
                                           Write(Model[i].PName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\n                                            <h3>???");
#nullable restore
#line 52 "F:\Final Interview\DemoFE\Views\Product\GetCart.cshtml"
                                            Write(Model[i].Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\n");
                WriteLiteral("                                            <label>Quantity</label>\n                                            <input type=\"number\" id=\"Qty\" name=\"Qty\"");
                BeginWriteAttribute("value", " value=\"", 2898, "\"", 2924, 1);
#nullable restore
#line 60 "F:\Final Interview\DemoFE\Views\Product\GetCart.cshtml"
WriteAttributeValue("", 2906, Model[i].Quantity, 2906, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" readonly />\n");
                WriteLiteral(@"
                                            <h3><strong>Delivery Charges</strong></h3>
                                            <input type=""text"" id=""deliveryCharges"" name=""deliveryCharges"" value=""69.00"" />
                                            <input type=""text"" name=""Prodprice"" id=""Prodprice"" hidden");
                BeginWriteAttribute("value", " value=\"", 3366, "\"", 3389, 1);
#nullable restore
#line 65 "F:\Final Interview\DemoFE\Views\Product\GetCart.cshtml"
WriteAttributeValue("", 3374, Model[i].Price, 3374, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n                                            <h3>Total Amount</h3>\n                                            <input type=\"text\" readonly name=\"TotalAmount\" id=\"TotalAmount\"");
                BeginWriteAttribute("value", " value=\"", 3567, "\"", 3596, 1);
#nullable restore
#line 67 "F:\Final Interview\DemoFE\Views\Product\GetCart.cshtml"
WriteAttributeValue("", 3575, Model[i].TotalAmount, 3575, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n                                            <button type=\"submit\" class=\"btn btn-secondary\">Place Order</button><br />\n\n\n                                            <input type=\"text\" name=\"ProductId\" hidden");
                BeginWriteAttribute("value", " value=\"", 3808, "\"", 3835, 1);
#nullable restore
#line 71 "F:\Final Interview\DemoFE\Views\Product\GetCart.cshtml"
WriteAttributeValue("", 3816, Model[i].ProductId, 3816, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n                                            <input type=\"text\" name=\"ProductVariationId\" hidden");
                BeginWriteAttribute("value", " value=\"", 3935, "\"", 3971, 1);
#nullable restore
#line 72 "F:\Final Interview\DemoFE\Views\Product\GetCart.cshtml"
WriteAttributeValue("", 3943, Model[i].ProductVariationId, 3943, 28, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n                                        </div>");
#nullable restore
#line 73 "F:\Final Interview\DemoFE\Views\Product\GetCart.cshtml"
                                              }

#line default
#line hidden
#nullable disable
                WriteLiteral("\n</div>            ");
#nullable restore
#line 75 "F:\Final Interview\DemoFE\Views\Product\GetCart.cshtml"
                  }

#line default
#line hidden
#nullable disable
                WriteLiteral("            <script src=\"https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js\" crossorigin=\"anonymous\"></script>\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a51ca684816dd1abbf1a9620c53778029cd1e89218671", async() => {
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
            WriteLiteral(@"
</html>
<script>$(document).ready(function () {
        var price = 0;
        var dlCharge = 0;

        $("".product-top"").each(function () {
            $(this).find(""input:text"").each(function () {
                if ($(this).prop('name') == 'Prodprice') {
                    price = $(this).val();
                }
                if ($(this).prop('name') == 'deliveryCharges') {
                    dlCharge = $(this).val();
                }
                if ($(this).prop('name') == 'TotalAmount') {
                    $(this).val(parseInt(price) + parseInt(dlCharge));
                }

            });
        });



    }));
            // var id = $('#dvProdListing').val();
            //$('#dvProdListing').each(function () {
            //    //var images = $(this).find("".scrolling img"");
            //    //var width = images.width();
            //    //var imgLength = images.length;
            //    //$(this).find("".scrolling"").width(width * imgLength * 1.2);


            //    var Qty = $(thi");
            WriteLiteral(@"s).find(""Qty"").value;
            //    alert(Qty);
            //    //var deliveryCharges = document.getElementById(""deliveryCharges"").value;
            //    //var price = document.getElementById(""price"").value;
            //    //var TotalAmount = (parseInt(Qty) * parseInt(price)) + parseInt(deliveryCharges);

            //});


            //var Prodprice = 0.00;
            //var TotalAmount = 0.00;
            //var deliveryCharges = 0.00;

    /* $(""#dvProdListing > input"").each(function () {*/
            //allVal += '&' + $(this).attr('name') + '=' + $(this).val();

            //if ($(this).attr('name') == 'deliveryCharges') {
            //    deliveryCharges = $(this).val();

            //}
            //if ($(this).attr('name') == 'Prodprice') {
            //    Prodprice = $(this).val();
            //}
            //if ($(this).attr('name') == 'TotalAmount') {
            //    TotalAmount = $(this).val();
            //    TotalAmount =  deliveryCharges + Prodprice;
            //    $(t");
            WriteLiteral(@"his).val(TotalAmount);
            //}
            //var $row = $(this).closest('.row'); // get parent row
            //var est = $(this).val(); // read estimante
            //var count = $row.find('input[name=""deliveryCharges[]""]').val(); // read count
            //$row.find('span.Amount').html(est * count); // put product

    /*  });*/

            //$('input, select').each(
            //    function (index) {
            //        var input = $(this);
            //       alert(input.attr('name') + ' ' + input.val());
            //    }
            //);
            //alert(allVal);




            //function myFunction(Qty, deliveryCharges, price) {
            //    var Qty = document.getElementById(""Qty"").value;
            //    var deliveryCharges = document.getElementById(""deliveryCharges"").value;
            //    var price = document.getElementById(""price"").value;
            //    var TotalAmount = (parseInt(Qty) * parseInt(price)) + parseInt(deliveryCharges);
            //    document.getEl");
            WriteLiteral("ementById(\"TotalAmount\").value = TotalAmount;\n            //}</script>\n\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\n");
#nullable restore
#line 174 "F:\Final Interview\DemoFE\Views\Product\GetCart.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<CartViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
