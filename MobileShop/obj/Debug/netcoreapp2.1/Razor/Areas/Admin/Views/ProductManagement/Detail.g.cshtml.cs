#pragma checksum "E:\MobileShop_ASP.NET-CORE\MobileShop\Areas\Admin\Views\ProductManagement\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "38535a60cf9836a6aac7f625e4120ad8cd9eb560"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_ProductManagement_Detail), @"mvc.1.0.view", @"/Areas/Admin/Views/ProductManagement/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/ProductManagement/Detail.cshtml", typeof(AspNetCore.Areas_Admin_Views_ProductManagement_Detail))]
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
#line 1 "E:\MobileShop_ASP.NET-CORE\MobileShop\Areas\Admin\Views\_ViewImports.cshtml"
using MobileShop;

#line default
#line hidden
#line 2 "E:\MobileShop_ASP.NET-CORE\MobileShop\Areas\Admin\Views\_ViewImports.cshtml"
using MobileShop.ViewModels;

#line default
#line hidden
#line 3 "E:\MobileShop_ASP.NET-CORE\MobileShop\Areas\Admin\Views\_ViewImports.cshtml"
using MobileShop.Data.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38535a60cf9836a6aac7f625e4120ad8cd9eb560", @"/Areas/Admin/Views/ProductManagement/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7cb4f6b7a7aca57832721f64923c52f93d3a6df", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_ProductManagement_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Admin/css/ProductManagement/DetailCSS.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 250px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display:block; margin-top: 20px; font-size: 18px; text-decoration: none;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("back"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "E:\MobileShop_ASP.NET-CORE\MobileShop\Areas\Admin\Views\ProductManagement\Detail.cshtml"
  
    ViewData["Title"] = "Detail";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
            BeginContext(122, 76, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "39a49d3e107a4064a3a8daad26f856da", async() => {
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
            EndContext();
            BeginContext(198, 135, true);
            WriteLiteral("\r\n<div class=\"wrapper-content\">\r\n    <h2>CHI TIẾT SẢN PHẨM</h2>\r\n    <div class=\"box\">\r\n        <div class=\"box__detail\">\r\n            ");
            EndContext();
            BeginContext(333, 93, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6f808353cdc941cb8f606b7c2ed100cf", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 343, "~/images/products/", 343, 18, true);
#line 11 "E:\MobileShop_ASP.NET-CORE\MobileShop\Areas\Admin\Views\ProductManagement\Detail.cshtml"
AddHtmlAttributeValue("", 361, Model.Product_ImageThumbnail, 361, 29, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(426, 191, true);
            WriteLiteral("\r\n        </div>\r\n        <div class=\"box__detail\">\r\n            <table>\r\n                <tr>\r\n                    <td style=\"font-weight: bold;\">Tên sản phẩm:</td>\r\n                    <td>");
            EndContext();
            BeginContext(618, 18, false);
#line 17 "E:\MobileShop_ASP.NET-CORE\MobileShop\Areas\Admin\Views\ProductManagement\Detail.cshtml"
                   Write(Model.Product_Name);

#line default
#line hidden
            EndContext();
            BeginContext(636, 138, true);
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td style=\"font-weight: bold;\">Giá:</td>\r\n                    <td>");
            EndContext();
            BeginContext(775, 37, false);
#line 21 "E:\MobileShop_ASP.NET-CORE\MobileShop\Areas\Admin\Views\ProductManagement\Detail.cshtml"
                   Write(Model.Product_Price.ToString("#,###"));

#line default
#line hidden
            EndContext();
            BeginContext(812, 121, true);
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td style=\"font-weight: bold;\">Trạng thái:</td>\r\n");
            EndContext();
#line 25 "E:\MobileShop_ASP.NET-CORE\MobileShop\Areas\Admin\Views\ProductManagement\Detail.cshtml"
                     if (@Model.Product_InStock == true)
                    {

#line default
#line hidden
            BeginContext(1014, 43, true);
            WriteLiteral("                        <td>Còn hàng</td>\r\n");
            EndContext();
#line 28 "E:\MobileShop_ASP.NET-CORE\MobileShop\Areas\Admin\Views\ProductManagement\Detail.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(1129, 43, true);
            WriteLiteral("                        <td>Hết hàng</td>\r\n");
            EndContext();
#line 32 "E:\MobileShop_ASP.NET-CORE\MobileShop\Areas\Admin\Views\ProductManagement\Detail.cshtml"
                    }

#line default
#line hidden
            BeginContext(1195, 113, true);
            WriteLiteral("                </tr>\r\n                <tr>\r\n                    <td style=\"font-weight: bold;\">Yêu thích:</td>\r\n");
            EndContext();
#line 36 "E:\MobileShop_ASP.NET-CORE\MobileShop\Areas\Admin\Views\ProductManagement\Detail.cshtml"
                     if (@Model.Product_IsPreferred == true)
                    {

#line default
#line hidden
            BeginContext(1393, 63, true);
            WriteLiteral("                        <td><i class=\"fas fa-check\"></i></td>\r\n");
            EndContext();
#line 39 "E:\MobileShop_ASP.NET-CORE\MobileShop\Areas\Admin\Views\ProductManagement\Detail.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(1528, 41, true);
            WriteLiteral("                        <td>&nbsp;</td>\r\n");
            EndContext();
#line 43 "E:\MobileShop_ASP.NET-CORE\MobileShop\Areas\Admin\Views\ProductManagement\Detail.cshtml"
                    }

#line default
#line hidden
            BeginContext(1592, 136, true);
            WriteLiteral("                </tr>\r\n                <tr>\r\n                    <td style=\"font-weight: bold;\">Lượt mua:</td>\r\n                    <td>");
            EndContext();
            BeginContext(1729, 23, false);
#line 47 "E:\MobileShop_ASP.NET-CORE\MobileShop\Areas\Admin\Views\ProductManagement\Detail.cshtml"
                   Write(Model.Product_Purchased);

#line default
#line hidden
            EndContext();
            BeginContext(1752, 64, true);
            WriteLiteral("</td>\r\n                </tr>\r\n            </table>\r\n            ");
            EndContext();
            BeginContext(1816, 128, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5228d96fbef74aafbec2e83957560220", async() => {
                BeginContext(1918, 22, true);
                WriteLiteral("Chỉnh sửa sản phẩm này");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1944, 298, true);
            WriteLiteral(@"
        </div>
        <div class=""box__detail"">
            <table>
                <tr>
                    <th class=""product-info__label"" colspan=""2"">Hệ điều hành - CPU</th>
                </tr>
                <tr>
                    <td>Hệ điều hành:</td>
                    <td>");
            EndContext();
            BeginContext(2243, 29, false);
#line 59 "E:\MobileShop_ASP.NET-CORE\MobileShop\Areas\Admin\Views\ProductManagement\Detail.cshtml"
                   Write(Model.Product_OperatingSystem);

#line default
#line hidden
            EndContext();
            BeginContext(2272, 128, true);
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Chipset(Hãng SX CPU):</td>\r\n                    <td>");
            EndContext();
            BeginContext(2401, 21, false);
#line 63 "E:\MobileShop_ASP.NET-CORE\MobileShop\Areas\Admin\Views\ProductManagement\Detail.cshtml"
                   Write(Model.Product_Chipset);

#line default
#line hidden
            EndContext();
            BeginContext(2422, 118, true);
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Tốc độ CPU:</td>\r\n                    <td>");
            EndContext();
            BeginContext(2541, 22, false);
#line 67 "E:\MobileShop_ASP.NET-CORE\MobileShop\Areas\Admin\Views\ProductManagement\Detail.cshtml"
                   Write(Model.Product_CPUSpeed);

#line default
#line hidden
            EndContext();
            BeginContext(2563, 125, true);
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Chip đồ họa (GPU):</td>\r\n                    <td>");
            EndContext();
            BeginContext(2689, 17, false);
#line 71 "E:\MobileShop_ASP.NET-CORE\MobileShop\Areas\Admin\Views\ProductManagement\Detail.cshtml"
                   Write(Model.Product_GPU);

#line default
#line hidden
            EndContext();
            BeginContext(2706, 244, true);
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <th class=\"product-info__label\" colspan=\"2\">Màn hình</th>\r\n                </tr>\r\n                <tr>\r\n                    <td>Độ phân giải:</td>\r\n                    <td>");
            EndContext();
            BeginContext(2951, 30, false);
#line 78 "E:\MobileShop_ASP.NET-CORE\MobileShop\Areas\Admin\Views\ProductManagement\Detail.cshtml"
                   Write(Model.Product_ScreenResolution);

#line default
#line hidden
            EndContext();
            BeginContext(2981, 121, true);
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Màn hình rộng:</td>\r\n                    <td>");
            EndContext();
            BeginContext(3103, 25, false);
#line 82 "E:\MobileShop_ASP.NET-CORE\MobileShop\Areas\Admin\Views\ProductManagement\Detail.cshtml"
                   Write(Model.Product_ScreenWidth);

#line default
#line hidden
            EndContext();
            BeginContext(3128, 243, true);
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <th class=\"product-info__label\" colspan=\"2\">Bộ nhớ & lưu trữ</th>\r\n                </tr>\r\n                <tr>\r\n                    <td>RAM:</td>\r\n                    <td>");
            EndContext();
            BeginContext(3372, 17, false);
#line 89 "E:\MobileShop_ASP.NET-CORE\MobileShop\Areas\Admin\Views\ProductManagement\Detail.cshtml"
                   Write(Model.Product_RAM);

#line default
#line hidden
            EndContext();
            BeginContext(3389, 120, true);
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Bộ nhớ trong:</td>\r\n                    <td>");
            EndContext();
            BeginContext(3510, 17, false);
#line 93 "E:\MobileShop_ASP.NET-CORE\MobileShop\Areas\Admin\Views\ProductManagement\Detail.cshtml"
                   Write(Model.Product_ROM);

#line default
#line hidden
            EndContext();
            BeginContext(3527, 98, true);
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Hỗ trợ thẻ nhớ:</td>\r\n");
            EndContext();
#line 97 "E:\MobileShop_ASP.NET-CORE\MobileShop\Areas\Admin\Views\ProductManagement\Detail.cshtml"
                     if (Model.Product_SDCardSupport == true)
                    {

#line default
#line hidden
            BeginContext(3711, 37, true);
            WriteLiteral("                        <td>Có</td>\r\n");
            EndContext();
#line 100 "E:\MobileShop_ASP.NET-CORE\MobileShop\Areas\Admin\Views\ProductManagement\Detail.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(3820, 40, true);
            WriteLiteral("                        <td>Không</td>\r\n");
            EndContext();
#line 104 "E:\MobileShop_ASP.NET-CORE\MobileShop\Areas\Admin\Views\ProductManagement\Detail.cshtml"
                    }

#line default
#line hidden
            BeginContext(3883, 114, true);
            WriteLiteral("                </tr>\r\n                <tr>\r\n                    <td>Thẻ nhớ ngoài:</td>\r\n                    <td>");
            EndContext();
            BeginContext(3998, 20, false);
#line 108 "E:\MobileShop_ASP.NET-CORE\MobileShop\Areas\Admin\Views\ProductManagement\Detail.cshtml"
                   Write(Model.Product_SDCard);

#line default
#line hidden
            EndContext();
            BeginContext(4018, 242, true);
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <th class=\"product-info__label\" colspan=\"2\">Camera</th>\r\n                </tr>\r\n                <tr>\r\n                    <td>Camera trước:</td>\r\n                    <td>");
            EndContext();
            BeginContext(4261, 25, false);
#line 115 "E:\MobileShop_ASP.NET-CORE\MobileShop\Areas\Admin\Views\ProductManagement\Detail.cshtml"
                   Write(Model.Product_FrontCamera);

#line default
#line hidden
            EndContext();
            BeginContext(4286, 118, true);
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Camera sau:</td>\r\n                    <td>");
            EndContext();
            BeginContext(4405, 24, false);
#line 119 "E:\MobileShop_ASP.NET-CORE\MobileShop\Areas\Admin\Views\ProductManagement\Detail.cshtml"
                   Write(Model.Product_RearCamera);

#line default
#line hidden
            EndContext();
            BeginContext(4429, 84, true);
            WriteLiteral("</td>\r\n                </tr>\r\n            </table>\r\n        </div>\r\n    </div>\r\n    ");
            EndContext();
            BeginContext(4513, 106, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "89330dc799604bb991df71c4dee57806", async() => {
                BeginContext(4548, 67, true);
                WriteLiteral("\r\n        <i class=\"fas fa-arrow-left\"></i>\r\n        Quay lại\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4619, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
