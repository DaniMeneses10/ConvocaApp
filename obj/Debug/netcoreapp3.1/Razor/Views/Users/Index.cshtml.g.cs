#pragma checksum "C:\Users\Administrador\OneDrive - Chr Hansen\ConvocaApp\ConvocaApp\ConvocaApp\Views\Users\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ac7da9048f97392707fb892b39a9bfebc31686d2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_Index), @"mvc.1.0.view", @"/Views/Users/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac7da9048f97392707fb892b39a9bfebc31686d2", @"/Views/Users/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6358e7c53ee5deb3e639ec23c305313970899379", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ConvocaApp.Models.UsersModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Administrador\OneDrive - Chr Hansen\ConvocaApp\ConvocaApp\ConvocaApp\Views\Users\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Lista de Usuarios</h1>\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ac7da9048f97392707fb892b39a9bfebc31686d23770", async() => {
                WriteLiteral("Crear nuevo Usuario");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</p>
<table class=""table"">
    <thead>
        <tr>
            <th>
                Nombre
            </th>
            <th>
                Edad
            </th>
            <th>
                Email
            </th>
            <th>
                Sexo
            </th>
            <th>
                Dirección
            </th>
");
            WriteLiteral("            <th>\r\n                Telefono\r\n            </th>\r\n            <th>\r\n                Ciudad\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 42 "C:\Users\Administrador\OneDrive - Chr Hansen\ConvocaApp\ConvocaApp\ConvocaApp\Views\Users\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 46 "C:\Users\Administrador\OneDrive - Chr Hansen\ConvocaApp\ConvocaApp\ConvocaApp\Views\Users\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 49 "C:\Users\Administrador\OneDrive - Chr Hansen\ConvocaApp\ConvocaApp\ConvocaApp\Views\Users\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.age));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 52 "C:\Users\Administrador\OneDrive - Chr Hansen\ConvocaApp\ConvocaApp\ConvocaApp\Views\Users\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 55 "C:\Users\Administrador\OneDrive - Chr Hansen\ConvocaApp\ConvocaApp\ConvocaApp\Views\Users\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.sex));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 58 "C:\Users\Administrador\OneDrive - Chr Hansen\ConvocaApp\ConvocaApp\ConvocaApp\Views\Users\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n");
            WriteLiteral("                <td>\r\n                    ");
#nullable restore
#line 64 "C:\Users\Administrador\OneDrive - Chr Hansen\ConvocaApp\ConvocaApp\ConvocaApp\Views\Users\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.cellphone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 67 "C:\Users\Administrador\OneDrive - Chr Hansen\ConvocaApp\ConvocaApp\ConvocaApp\Views\Users\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.city));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 70 "C:\Users\Administrador\OneDrive - Chr Hansen\ConvocaApp\ConvocaApp\ConvocaApp\Views\Users\Index.cshtml"
               Write(Html.ActionLink("Editar", "Edit", new { item.Id /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                    ");
#nullable restore
#line 71 "C:\Users\Administrador\OneDrive - Chr Hansen\ConvocaApp\ConvocaApp\ConvocaApp\Views\Users\Index.cshtml"
               Write(Html.ActionLink("Detalles", "Details", new { item.Id/* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                    ");
#nullable restore
#line 72 "C:\Users\Administrador\OneDrive - Chr Hansen\ConvocaApp\ConvocaApp\ConvocaApp\Views\Users\Index.cshtml"
               Write(Html.ActionLink("Borrar Usuario", "Delete", new { item.Id/* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 75 "C:\Users\Administrador\OneDrive - Chr Hansen\ConvocaApp\ConvocaApp\ConvocaApp\Views\Users\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n<br />\r\n<a href=\"https://localhost:44304/\"> Click aquí para volver a Home </a>\r\n<br />\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ConvocaApp.Models.UsersModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
