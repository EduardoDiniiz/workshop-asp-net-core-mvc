#pragma checksum "C:\src\Projetos\SalesWebMvc\Views\Sellers\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a5b30d8e11c07e7c3a670209b38737ae6f5e3d94"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sellers_Index), @"mvc.1.0.view", @"/Views/Sellers/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Sellers/Index.cshtml", typeof(AspNetCore.Views_Sellers_Index))]
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
#line 1 "C:\src\Projetos\SalesWebMvc\Views\_ViewImports.cshtml"
using SalesWebMvc;

#line default
#line hidden
#line 2 "C:\src\Projetos\SalesWebMvc\Views\_ViewImports.cshtml"
using SalesWebMvc.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5b30d8e11c07e7c3a670209b38737ae6f5e3d94", @"/Views/Sellers/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70dafd425af89a5439216963c7093f2ead686e4a", @"/Views/_ViewImports.cshtml")]
    public class Views_Sellers_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SalesWebMvc.Models.Seller>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(48, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 4 "C:\src\Projetos\SalesWebMvc\Views\Sellers\Index.cshtml"
  
    ViewData["Title"] = "Sellers";

#line default
#line hidden
            BeginContext(95, 6, true);
            WriteLiteral("\r\n<h1>");
            EndContext();
            BeginContext(102, 17, false);
#line 8 "C:\src\Projetos\SalesWebMvc\Views\Sellers\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(119, 135, true);
            WriteLiteral("</h1>\r\n\r\n<table class=\"table table-striped table-hover\">\r\n    <thead>\r\n        <tr class=\"success\">\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(255, 40, false);
#line 14 "C:\src\Projetos\SalesWebMvc\Views\Sellers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(295, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(351, 41, false);
#line 17 "C:\src\Projetos\SalesWebMvc\Views\Sellers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(392, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(448, 45, false);
#line 20 "C:\src\Projetos\SalesWebMvc\Views\Sellers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.BirthDate));

#line default
#line hidden
            EndContext();
            BeginContext(493, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(549, 46, false);
#line 23 "C:\src\Projetos\SalesWebMvc\Views\Sellers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.BaseSalary));

#line default
#line hidden
            EndContext();
            BeginContext(595, 63, true);
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 28 "C:\src\Projetos\SalesWebMvc\Views\Sellers\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(707, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(756, 39, false);
#line 32 "C:\src\Projetos\SalesWebMvc\Views\Sellers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(795, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(851, 40, false);
#line 35 "C:\src\Projetos\SalesWebMvc\Views\Sellers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
            EndContext();
            BeginContext(891, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(947, 44, false);
#line 38 "C:\src\Projetos\SalesWebMvc\Views\Sellers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.BirthDate));

#line default
#line hidden
            EndContext();
            BeginContext(991, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1047, 45, false);
#line 41 "C:\src\Projetos\SalesWebMvc\Views\Sellers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.BaseSalary));

#line default
#line hidden
            EndContext();
            BeginContext(1092, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 44 "C:\src\Projetos\SalesWebMvc\Views\Sellers\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1139, 26, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SalesWebMvc.Models.Seller>> Html { get; private set; }
    }
}
#pragma warning restore 1591
