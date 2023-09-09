#pragma checksum "C:\Users\yo\OneDrive\Documentos\Escritorio\Trabajoo\Trabajoo\Trabajoo\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "56d274d1453d9e8ab220c1f234491e40e3cf322a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Trabajoo.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace Trabajoo.Pages
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
#line 1 "C:\Users\yo\OneDrive\Documentos\Escritorio\Trabajoo\Trabajoo\Trabajoo\Pages\_ViewImports.cshtml"
using Trabajoo;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"56d274d1453d9e8ab220c1f234491e40e3cf322a", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ade7489d1ea68ca0e1884de3b80fd05add92e0d", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\yo\OneDrive\Documentos\Escritorio\Trabajoo\Trabajoo\Trabajoo\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    /* Estilos para el encabezado */
    .header {
        background-color: #007BFF;
        color: white;
        text-align: center;
        padding: 20px;
    }

    /* Estilos para los enlaces de navegación */
    .nav-link {
        text-decoration: none;
        margin: 10px;
        padding: 5px 10px;
        background-color: #007BFF;
        color: white;
        border-radius: 5px;
    }

    /* Estilos para la tabla de productos */
    .table {
        width: 80%;
        margin: 0 auto;
        border-collapse: collapse;
    }

        .table th, .table td {
            border: 1px solid #ddd;
            padding: 8px;
            text-align: left;
        }

        .table th {
            background-color: #007BFF;
            color: white;
        }

    /* Estilos para el formulario de registro */
    .form-container {
        width: 60%;
        margin: 20px auto;
        padding: 20px;
        border: 1px solid #ddd;
        border-radius");
            WriteLiteral(@": 5px;
    }

    .form-group {
        margin-bottom: 15px;
    }

        .form-group label {
            display: block;
            font-weight: bold;
        }

        .form-group input[type=""text""],
        .form-group input[type=""number""] {
            width: 100%;
            padding: 8px;
            border: 1px solid #ddd;
            border-radius: 5px;
        }

        .form-group button {
            background-color: #007BFF;
            color: white;
            border: none;
            border-radius: 5px;
            padding: 10px 20px;
            cursor: pointer;
        }
</style>

<div class=""header"">
    <h1>Welcome</h1>
    <p>Learn about <a href=""https://docs.microsoft.com/aspnet/core"">building Web apps with ASP.NET Core</a>.</p>
</div>

<div class=""nav"">
    <a class=""nav-link"" href=""#"">Home</a>
    <a class=""nav-link"" href=""#"">Products</a>
    <a class=""nav-link"" href=""#"">Customers</a>
    <a class=""nav-link"" href=""#"">Sales</a>
</div>

<di");
            WriteLiteral(@"v class=""table-container"">
    <h2>Productos Saludables</h2>
    <table class=""table"">
        <thead>
            <tr>
                <th>Nombre</th>
                <th>Precio</th>
                <th>Descripción</th>
            </tr>
        </thead>
        <tbody>
            <tr>
                <td>Producto 1</td>
                <td>$10.99</td>
                <td>Descripción del producto 1.</td>
            </tr>
            <tr>
                <td>Producto 2</td>
                <td>$15.99</td>
                <td>Descripción del producto 2.</td>
            </tr>
            <!-- Agrega más filas de productos aquí -->
        </tbody>
    </table>
</div>

<div class=""form-container"">
    <h2>Registrar Producto</h2>
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "56d274d1453d9e8ab220c1f234491e40e3cf322a6158", async() => {
                WriteLiteral(@"
        <div class=""form-group"">
            <label for=""productName"">Nombre del Producto:</label>
            <input type=""text"" id=""productName"" name=""productName"">
        </div>
        <div class=""form-group"">
            <label for=""productPrice"">Precio:</label>
            <input type=""number"" id=""productPrice"" name=""productPrice"">
        </div>
        <div class=""form-group"">
            <label for=""productDescription"">Descripción:</label>
            <input type=""text"" id=""productDescription"" name=""productDescription"">
        </div>
        <button type=""submit"">Registrar Producto</button>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
