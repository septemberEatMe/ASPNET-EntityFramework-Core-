#pragma checksum "D:\Code_Code_Code\ASPNETandEntityFramework\RazorTest\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "de6476dcacd58eb59ef6233305fef25234bf4ba7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "D:\Code_Code_Code\ASPNETandEntityFramework\RazorTest\Views\_ViewImports.cshtml"
using RazorTest.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de6476dcacd58eb59ef6233305fef25234bf4ba7", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cff5e08753a93156eb4b4fea7c8c88b352a5fb74", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\Code_Code_Code\ASPNETandEntityFramework\RazorTest\Views\Home\Index.cshtml"
  
    ViewBag.Title = "Product Name";

#line default
#line hidden
            BeginContext(60, 21, true);
            WriteLiteral("<div data-productId=\"");
            EndContext();
            BeginContext(82, 15, false);
#line 5 "D:\Code_Code_Code\ASPNETandEntityFramework\RazorTest\Views\Home\Index.cshtml"
                Write(Model.ProductId);

#line default
#line hidden
            EndContext();
            BeginContext(97, 26, true);
            WriteLiteral("\" \r\n     data-stocklevel=\"");
            EndContext();
            BeginContext(124, 18, false);
#line 6 "D:\Code_Code_Code\ASPNETandEntityFramework\RazorTest\Views\Home\Index.cshtml"
                 Write(ViewBag.StockLevel);

#line default
#line hidden
            EndContext();
            BeginContext(142, 26, true);
            WriteLiteral("\">\r\n    <p>Наименование : ");
            EndContext();
            BeginContext(169, 10, false);
#line 7 "D:\Code_Code_Code\ASPNETandEntityFramework\RazorTest\Views\Home\Index.cshtml"
                 Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(179, 21, true);
            WriteLiteral(" </p>\r\n    <p>Цена : ");
            EndContext();
            BeginContext(202, 19, false);
#line 8 "D:\Code_Code_Code\ASPNETandEntityFramework\RazorTest\Views\Home\Index.cshtml"
          Write($"{Model.Price:c2}");

#line default
#line hidden
            EndContext();
            BeginContext(222, 36, true);
            WriteLiteral("</p>\r\n    <p>Количество Товара</p>\r\n");
            EndContext();
#line 10 "D:\Code_Code_Code\ASPNETandEntityFramework\RazorTest\Views\Home\Index.cshtml"
     switch ((int)ViewBag.StockLevel)
    {
        case 0:

#line default
#line hidden
            BeginContext(321, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(335, 15, true);
            WriteLiteral("Нет в наличии\r\n");
            EndContext();
#line 14 "D:\Code_Code_Code\ASPNETandEntityFramework\RazorTest\Views\Home\Index.cshtml"
            break;
        case 1:
        case 2:
        case 3:

#line default
#line hidden
            BeginContext(421, 25, true);
            WriteLiteral("            <b>Остаток :(");
            EndContext();
            BeginContext(447, 18, false);
#line 18 "D:\Code_Code_Code\ASPNETandEntityFramework\RazorTest\Views\Home\Index.cshtml"
                    Write(ViewBag.StockLevel);

#line default
#line hidden
            EndContext();
            BeginContext(465, 7, true);
            WriteLiteral(")</b>\r\n");
            EndContext();
#line 19 "D:\Code_Code_Code\ASPNETandEntityFramework\RazorTest\Views\Home\Index.cshtml"
            break;
        default:

#line default
#line hidden
            BeginContext(510, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(524, 30, true);
            WriteLiteral(" ViewBag.StockLevel Осталось\r\n");
            EndContext();
#line 22 "D:\Code_Code_Code\ASPNETandEntityFramework\RazorTest\Views\Home\Index.cshtml"
            break;
    }

#line default
#line hidden
            BeginContext(581, 6, true);
            WriteLiteral("</div>");
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
