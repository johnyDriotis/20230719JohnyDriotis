#pragma checksum "C:\Repository\Net\20230719JohnyDriotis\Proyecto\20230719JohnyDriotis\20230719JohnyDriotis\Views\Informacion\DepartamentosPorEmpresa.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "84cba494f91da248f439e03eee8fb1a483044d47"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(_20230719JohnyDriotis.Pages.Informacion.Views_Informacion_DepartamentosPorEmpresa), @"mvc.1.0.view", @"/Views/Informacion/DepartamentosPorEmpresa.cshtml")]
namespace _20230719JohnyDriotis.Pages.Informacion
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
#line 1 "C:\Repository\Net\20230719JohnyDriotis\Proyecto\20230719JohnyDriotis\20230719JohnyDriotis\Views\_ViewImports.cshtml"
using _20230719JohnyDriotis;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Repository\Net\20230719JohnyDriotis\Proyecto\20230719JohnyDriotis\20230719JohnyDriotis\Views\Informacion\DepartamentosPorEmpresa.cshtml"
using _20230719JohnyDriotis.Models.ModelsOut;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"84cba494f91da248f439e03eee8fb1a483044d47", @"/Views/Informacion/DepartamentosPorEmpresa.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47227db4c29067cffc8da05f2d40255ae4a97036", @"/Views/_ViewImports.cshtml")]
    public class Views_Informacion_DepartamentosPorEmpresa : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<DepartamentosPorEmpresa>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Informacion", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Repository\Net\20230719JohnyDriotis\Proyecto\20230719JohnyDriotis\20230719JohnyDriotis\Views\Informacion\DepartamentosPorEmpresa.cshtml"
 if (Model is not null && Model.Count > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <label class=\"text-success\">Departamentos de empresa: ");
#nullable restore
#line 7 "C:\Repository\Net\20230719JohnyDriotis\Proyecto\20230719JohnyDriotis\20230719JohnyDriotis\Views\Informacion\DepartamentosPorEmpresa.cshtml"
                                                     Write(Model[0].Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label>
    <hr />
    <table class=""table"">
        <thead>
            <tr>
                <th scope=""col"">CodDepartamento</th>
                <th scope=""col"">Nombre</th>
                <th scope=""col"">NumeroEmpleados</th>
                <th scope=""col"">NivelOrganizacion</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 19 "C:\Repository\Net\20230719JohnyDriotis\Proyecto\20230719JohnyDriotis\20230719JohnyDriotis\Views\Informacion\DepartamentosPorEmpresa.cshtml"
             foreach (var dep in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <th scope=\"row\">");
#nullable restore
#line 22 "C:\Repository\Net\20230719JohnyDriotis\Proyecto\20230719JohnyDriotis\20230719JohnyDriotis\Views\Informacion\DepartamentosPorEmpresa.cshtml"
                               Write(dep.IdDepartamento);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th scope=\"row\">");
#nullable restore
#line 23 "C:\Repository\Net\20230719JohnyDriotis\Proyecto\20230719JohnyDriotis\20230719JohnyDriotis\Views\Informacion\DepartamentosPorEmpresa.cshtml"
                               Write(dep.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <td>");
#nullable restore
#line 24 "C:\Repository\Net\20230719JohnyDriotis\Proyecto\20230719JohnyDriotis\20230719JohnyDriotis\Views\Informacion\DepartamentosPorEmpresa.cshtml"
                   Write(dep.NumeroEmpleados);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 25 "C:\Repository\Net\20230719JohnyDriotis\Proyecto\20230719JohnyDriotis\20230719JohnyDriotis\Views\Informacion\DepartamentosPorEmpresa.cshtml"
                   Write(dep.NivelOrganizacion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 27 "C:\Repository\Net\20230719JohnyDriotis\Proyecto\20230719JohnyDriotis\20230719JohnyDriotis\Views\Informacion\DepartamentosPorEmpresa.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 30 "C:\Repository\Net\20230719JohnyDriotis\Proyecto\20230719JohnyDriotis\20230719JohnyDriotis\Views\Informacion\DepartamentosPorEmpresa.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <label class=\"text-danger\">No se encontraton departamentos en la empresa seleccionada</label>\r\n");
#nullable restore
#line 34 "C:\Repository\Net\20230719JohnyDriotis\Proyecto\20230719JohnyDriotis\20230719JohnyDriotis\Views\Informacion\DepartamentosPorEmpresa.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "84cba494f91da248f439e03eee8fb1a483044d478126", async() => {
                WriteLiteral("Home");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<DepartamentosPorEmpresa>> Html { get; private set; }
    }
}
#pragma warning restore 1591
