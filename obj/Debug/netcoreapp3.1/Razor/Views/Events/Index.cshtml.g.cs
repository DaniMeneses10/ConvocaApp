#pragma checksum "C:\Users\Administrador\OneDrive - Chr Hansen\ConvocaApp\ConvocaApp\ConvocaApp\Views\Events\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a3f0e087eac6b81ba48cd72a9be1fb00b2c7730a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Events_Index), @"mvc.1.0.view", @"/Views/Events/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3f0e087eac6b81ba48cd72a9be1fb00b2c7730a", @"/Views/Events/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6358e7c53ee5deb3e639ec23c305313970899379", @"/Views/_ViewImports.cshtml")]
    public class Views_Events_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ConvocaApp.Models.EventsViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\Administrador\OneDrive - Chr Hansen\ConvocaApp\ConvocaApp\ConvocaApp\Views\Events\Index.cshtml"
  
    //ViewData["Title"] = "Index";
    Layout = "_StartApp";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section class=\"header_login\">\r\n    <h1>Lista de Eventos</h1>\r\n</section>\r\n");
            WriteLiteral(@"<table>
    <thead>
        <tr>
            <th>
                Categoria
            </th>
            <th>
                Sexo
            </th>
            <th>
                Reservación
            </th>
            <th>
                Fecha del evento
            </th>
            <th>
                Hora
            </th>
            <th>
                Costo
            </th>
            <th>
                Forma de pago
            </th>
            <th>
                Lugar del Evento
            </th>
            <th>
                Deporte
            </th>
            <th>
                Detalles
            </th>
            <th>
                Juegas?
            </th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 54 "C:\Users\Administrador\OneDrive - Chr Hansen\ConvocaApp\ConvocaApp\ConvocaApp\Views\Events\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 58 "C:\Users\Administrador\OneDrive - Chr Hansen\ConvocaApp\ConvocaApp\ConvocaApp\Views\Events\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.category));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 61 "C:\Users\Administrador\OneDrive - Chr Hansen\ConvocaApp\ConvocaApp\ConvocaApp\Views\Events\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.sex));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 64 "C:\Users\Administrador\OneDrive - Chr Hansen\ConvocaApp\ConvocaApp\ConvocaApp\Views\Events\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.reserve));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 67 "C:\Users\Administrador\OneDrive - Chr Hansen\ConvocaApp\ConvocaApp\ConvocaApp\Views\Events\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 70 "C:\Users\Administrador\OneDrive - Chr Hansen\ConvocaApp\ConvocaApp\ConvocaApp\Views\Events\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.time));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 73 "C:\Users\Administrador\OneDrive - Chr Hansen\ConvocaApp\ConvocaApp\ConvocaApp\Views\Events\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.cost));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 76 "C:\Users\Administrador\OneDrive - Chr Hansen\ConvocaApp\ConvocaApp\ConvocaApp\Views\Events\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.paymment));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 79 "C:\Users\Administrador\OneDrive - Chr Hansen\ConvocaApp\ConvocaApp\ConvocaApp\Views\Events\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.place_name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 82 "C:\Users\Administrador\OneDrive - Chr Hansen\ConvocaApp\ConvocaApp\ConvocaApp\Views\Events\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.sport_name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
            WriteLiteral("                    ");
#nullable restore
#line 86 "C:\Users\Administrador\OneDrive - Chr Hansen\ConvocaApp\ConvocaApp\ConvocaApp\Views\Events\Index.cshtml"
               Write(Html.ActionLink("Detalles", "Details", new { item.Id/* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("                </td>\r\n                <td>\r\n                    Quiero jugar\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 93 "C:\Users\Administrador\OneDrive - Chr Hansen\ConvocaApp\ConvocaApp\ConvocaApp\Views\Events\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            WriteLiteral("\r\n<div class=\"events_menu\">\r\n    <a href=\"https://localhost:44304/Convoca/Index\"> Home </a>\r\n</div>\r\n<br />\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ConvocaApp.Models.EventsViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
