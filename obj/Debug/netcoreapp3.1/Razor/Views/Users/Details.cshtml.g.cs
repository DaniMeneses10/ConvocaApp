#pragma checksum "C:\Users\Administrador\OneDrive - Chr Hansen\ConvocaApp\ConvocaApp\ConvocaApp\Views\Users\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f294e9a81d7b4b2747d7fb928720afdc1b95f838"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_Details), @"mvc.1.0.view", @"/Views/Users/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f294e9a81d7b4b2747d7fb928720afdc1b95f838", @"/Views/Users/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6358e7c53ee5deb3e639ec23c305313970899379", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ConvocaApp.Models.UsersModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Administrador\OneDrive - Chr Hansen\ConvocaApp\ConvocaApp\ConvocaApp\Views\Users\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "_StartApp";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<section class=\"header_login\">\r\n    <h1>Detalles de Usuario</h1>\r\n</section>\r\n<div class=\"user_details\">\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            Nombre:\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 19 "C:\Users\Administrador\OneDrive - Chr Hansen\ConvocaApp\ConvocaApp\ConvocaApp\Views\Users\Details.cshtml"
       Write(Html.DisplayFor(model => model.name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Edad:\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 25 "C:\Users\Administrador\OneDrive - Chr Hansen\ConvocaApp\ConvocaApp\ConvocaApp\Views\Users\Details.cshtml"
       Write(Html.DisplayFor(model => model.age));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Email:\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 31 "C:\Users\Administrador\OneDrive - Chr Hansen\ConvocaApp\ConvocaApp\ConvocaApp\Views\Users\Details.cshtml"
       Write(Html.DisplayFor(model => model.email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Sexo:\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 37 "C:\Users\Administrador\OneDrive - Chr Hansen\ConvocaApp\ConvocaApp\ConvocaApp\Views\Users\Details.cshtml"
       Write(Html.DisplayFor(model => model.sex));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Dirección:\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 43 "C:\Users\Administrador\OneDrive - Chr Hansen\ConvocaApp\ConvocaApp\ConvocaApp\Views\Users\Details.cshtml"
       Write(Html.DisplayFor(model => model.address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Teléfono:\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 49 "C:\Users\Administrador\OneDrive - Chr Hansen\ConvocaApp\ConvocaApp\ConvocaApp\Views\Users\Details.cshtml"
       Write(Html.DisplayFor(model => model.cellphone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Ciudad:\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 55 "C:\Users\Administrador\OneDrive - Chr Hansen\ConvocaApp\ConvocaApp\ConvocaApp\Views\Users\Details.cshtml"
       Write(Html.DisplayFor(model => model.city));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div class=\"details_menu_main\">\r\n");
            WriteLiteral("</div>\r\n    \r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ConvocaApp.Models.UsersModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
