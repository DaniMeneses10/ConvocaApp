#pragma checksum "C:\Users\Administrador\OneDrive - Chr Hansen\ConvocaApp\ConvocaApp\ConvocaApp\Views\Events\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "379002a0f4eb85ea7113c3c6a9db9cdbdf3f94eb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Events_Details), @"mvc.1.0.view", @"/Views/Events/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"379002a0f4eb85ea7113c3c6a9db9cdbdf3f94eb", @"/Views/Events/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6358e7c53ee5deb3e639ec23c305313970899379", @"/Views/_ViewImports.cshtml")]
    public class Views_Events_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ConvocaApp.Models.EventsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("botons"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Administrador\OneDrive - Chr Hansen\ConvocaApp\ConvocaApp\ConvocaApp\Views\Events\Details.cshtml"
  
    ViewData["Title"] = "Events Details";
    Layout = "_StartApp";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<section class=\"header_login\">\r\n    <h1>Detalles de tu evento</h1>\r\n</section>\r\n\r\n<section class=\"form-register\">\r\n    <img class=\"smallEvent_image\"");
            BeginWriteAttribute("src", " src=\"", 273, "\"", 310, 1);
#nullable restore
#line 14 "C:\Users\Administrador\OneDrive - Chr Hansen\ConvocaApp\ConvocaApp\ConvocaApp\Views\Events\Details.cshtml"
WriteAttributeValue("", 279, Url.Content(Model.picture_url), 279, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <hr />\r\n    <label class=\"controls\">Deporte: ");
#nullable restore
#line 16 "C:\Users\Administrador\OneDrive - Chr Hansen\ConvocaApp\ConvocaApp\ConvocaApp\Views\Events\Details.cshtml"
                                Write(Html.DisplayFor(model => model.sport_name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n    <label class=\"controls\">Lugar: ");
#nullable restore
#line 17 "C:\Users\Administrador\OneDrive - Chr Hansen\ConvocaApp\ConvocaApp\ConvocaApp\Views\Events\Details.cshtml"
                              Write(Html.DisplayFor(model => model.place_name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n    <label class=\"controls\">Fecha:  ");
#nullable restore
#line 18 "C:\Users\Administrador\OneDrive - Chr Hansen\ConvocaApp\ConvocaApp\ConvocaApp\Views\Events\Details.cshtml"
                               Write(Html.DisplayFor(model => model.date));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n    <label class=\"controls\">Hora: ");
#nullable restore
#line 19 "C:\Users\Administrador\OneDrive - Chr Hansen\ConvocaApp\ConvocaApp\ConvocaApp\Views\Events\Details.cshtml"
                             Write(Html.DisplayFor(model => model.time));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n    <label class=\"controls\">Categoria: ");
#nullable restore
#line 20 "C:\Users\Administrador\OneDrive - Chr Hansen\ConvocaApp\ConvocaApp\ConvocaApp\Views\Events\Details.cshtml"
                                  Write(Html.DisplayFor(model => model.category));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n    <label class=\"controls\">Generó: ");
#nullable restore
#line 21 "C:\Users\Administrador\OneDrive - Chr Hansen\ConvocaApp\ConvocaApp\ConvocaApp\Views\Events\Details.cshtml"
                               Write(Html.DisplayFor(model => model.sex));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n    <label class=\"controls\">Reservación: ");
#nullable restore
#line 22 "C:\Users\Administrador\OneDrive - Chr Hansen\ConvocaApp\ConvocaApp\ConvocaApp\Views\Events\Details.cshtml"
                                    Write(Html.DisplayFor(model => model.reserve));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n    <label class=\"controls\">Costo: ");
#nullable restore
#line 23 "C:\Users\Administrador\OneDrive - Chr Hansen\ConvocaApp\ConvocaApp\ConvocaApp\Views\Events\Details.cshtml"
                              Write(Html.DisplayFor(model => model.cost));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n    <label class=\"controls\">Forma de Pago: ");
#nullable restore
#line 24 "C:\Users\Administrador\OneDrive - Chr Hansen\ConvocaApp\ConvocaApp\ConvocaApp\Views\Events\Details.cshtml"
                                      Write(Html.DisplayFor(model => model.paymment));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n\r\n    <div class=\"details_menu_main\">\r\n");
            WriteLiteral("        ");
#nullable restore
#line 28 "C:\Users\Administrador\OneDrive - Chr Hansen\ConvocaApp\ConvocaApp\ConvocaApp\Views\Events\Details.cshtml"
   Write(Html.ActionLink("Participar", "Create", "Convocados", new { Model.Id/* id=item.PrimaryKey */}, new { @class = "botons" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "379002a0f4eb85ea7113c3c6a9db9cdbdf3f94eb8310", async() => {
                WriteLiteral("Regresar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        <a class=\"botons\" href=\"https://localhost:44304/Convoca/Index\"> Home </a>\r\n    </div>\r\n\r\n\r\n\r\n</section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ConvocaApp.Models.EventsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
