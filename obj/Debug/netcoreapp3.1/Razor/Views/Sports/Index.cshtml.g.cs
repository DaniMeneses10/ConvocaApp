#pragma checksum "C:\Users\Administrador\OneDrive - Chr Hansen\ConvocaApp\ConvocaApp\ConvocaApp\Views\Sports\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7ade8f740b100f353bb8efd0208167091eee8f11"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sports_Index), @"mvc.1.0.view", @"/Views/Sports/Index.cshtml")]
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
#line 1 "C:\Users\Administrador\OneDrive - Chr Hansen\ConvocaApp\ConvocaApp\ConvocaApp\Views\_ViewImports.cshtml"
using ConvocaApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Administrador\OneDrive - Chr Hansen\ConvocaApp\ConvocaApp\ConvocaApp\Views\_ViewImports.cshtml"
using ConvocaApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ade8f740b100f353bb8efd0208167091eee8f11", @"/Views/Sports/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6358e7c53ee5deb3e639ec23c305313970899379", @"/Views/_ViewImports.cshtml")]
    public class Views_Sports_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ConvocaApp.Models.SportsModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Administrador\OneDrive - Chr Hansen\ConvocaApp\ConvocaApp\ConvocaApp\Views\Sports\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "_StartApp";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<section class=""header_login"">
    <h1>Lista de Deportes</h1>
</section>


    <table class=""sports_table"">
        <thead>
            <tr>
                <th>
                    Deporte
                </th>
                <th>
                    Número de Jugadores
                </th>
                <th>
                    Accesorios
                </th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 29 "C:\Users\Administrador\OneDrive - Chr Hansen\ConvocaApp\ConvocaApp\ConvocaApp\Views\Sports\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 33 "C:\Users\Administrador\OneDrive - Chr Hansen\ConvocaApp\ConvocaApp\ConvocaApp\Views\Sports\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 36 "C:\Users\Administrador\OneDrive - Chr Hansen\ConvocaApp\ConvocaApp\ConvocaApp\Views\Sports\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.playerNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 39 "C:\Users\Administrador\OneDrive - Chr Hansen\ConvocaApp\ConvocaApp\ConvocaApp\Views\Sports\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.accesories));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 42 "C:\Users\Administrador\OneDrive - Chr Hansen\ConvocaApp\ConvocaApp\ConvocaApp\Views\Sports\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n<section class=\"sport-list\">\r\n    <div class=\"details_menu_main_sports\">\r\n        <a class=\"botons\" href=\"https://localhost:44304/Convoca/Index\"> Home </a>\r\n    </div>\r\n</section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ConvocaApp.Models.SportsModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
