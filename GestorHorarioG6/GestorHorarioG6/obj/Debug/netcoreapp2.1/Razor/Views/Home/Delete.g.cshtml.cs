#pragma checksum "C:\Users\tiago\Desktop\ES3.14_Grupo6\GestorHorarioG6\GestorHorarioG6\Views\Home\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e77c9c5a6966dc8966599f90bd617220a1d3ab07"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Delete), @"mvc.1.0.view", @"/Views/Home/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Delete.cshtml", typeof(AspNetCore.Views_Home_Delete))]
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
#line 1 "C:\Users\tiago\Desktop\ES3.14_Grupo6\GestorHorarioG6\GestorHorarioG6\Views\_ViewImports.cshtml"
using GestorHorarioG6;

#line default
#line hidden
#line 2 "C:\Users\tiago\Desktop\ES3.14_Grupo6\GestorHorarioG6\GestorHorarioG6\Views\_ViewImports.cshtml"
using GestorHorarioG6.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e77c9c5a6966dc8966599f90bd617220a1d3ab07", @"/Views/Home/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e7dd2ff891d062cebc3098292d7dc1d6d5d895b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GestorHorarioG6.Models.Funcionario>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(43, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\tiago\Desktop\ES3.14_Grupo6\GestorHorarioG6\GestorHorarioG6\Views\Home\Delete.cshtml"
  
    ViewData["Title"] = "Eliminar";

#line default
#line hidden
            BeginContext(89, 171, true);
            WriteLiteral("\r\n<h2>Eliminar</h2>\r\n\r\n<h3>Tem a certeza que pretende editar?</h3>\r\n<div>\r\n    <h4>Funcionário</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(261, 40, false);
#line 15 "C:\Users\tiago\Desktop\ES3.14_Grupo6\GestorHorarioG6\GestorHorarioG6\Views\Home\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(301, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(345, 36, false);
#line 18 "C:\Users\tiago\Desktop\ES3.14_Grupo6\GestorHorarioG6\GestorHorarioG6\Views\Home\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(381, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(425, 41, false);
#line 21 "C:\Users\tiago\Desktop\ES3.14_Grupo6\GestorHorarioG6\GestorHorarioG6\Views\Home\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Cargo));

#line default
#line hidden
            EndContext();
            BeginContext(466, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(510, 37, false);
#line 24 "C:\Users\tiago\Desktop\ES3.14_Grupo6\GestorHorarioG6\GestorHorarioG6\Views\Home\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Cargo));

#line default
#line hidden
            EndContext();
            BeginContext(547, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(591, 46, false);
#line 27 "C:\Users\tiago\Desktop\ES3.14_Grupo6\GestorHorarioG6\GestorHorarioG6\Views\Home\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Nascimento));

#line default
#line hidden
            EndContext();
            BeginContext(637, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(681, 42, false);
#line 30 "C:\Users\tiago\Desktop\ES3.14_Grupo6\GestorHorarioG6\GestorHorarioG6\Views\Home\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Nascimento));

#line default
#line hidden
            EndContext();
            BeginContext(723, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(767, 39, false);
#line 33 "C:\Users\tiago\Desktop\ES3.14_Grupo6\GestorHorarioG6\GestorHorarioG6\Views\Home\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.NIF));

#line default
#line hidden
            EndContext();
            BeginContext(806, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(850, 35, false);
#line 36 "C:\Users\tiago\Desktop\ES3.14_Grupo6\GestorHorarioG6\GestorHorarioG6\Views\Home\Delete.cshtml"
       Write(Html.DisplayFor(model => model.NIF));

#line default
#line hidden
            EndContext();
            BeginContext(885, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(929, 44, false);
#line 39 "C:\Users\tiago\Desktop\ES3.14_Grupo6\GestorHorarioG6\GestorHorarioG6\Views\Home\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Telefone));

#line default
#line hidden
            EndContext();
            BeginContext(973, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1017, 40, false);
#line 42 "C:\Users\tiago\Desktop\ES3.14_Grupo6\GestorHorarioG6\GestorHorarioG6\Views\Home\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Telefone));

#line default
#line hidden
            EndContext();
            BeginContext(1057, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1101, 41, false);
#line 45 "C:\Users\tiago\Desktop\ES3.14_Grupo6\GestorHorarioG6\GestorHorarioG6\Views\Home\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1142, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1186, 37, false);
#line 48 "C:\Users\tiago\Desktop\ES3.14_Grupo6\GestorHorarioG6\GestorHorarioG6\Views\Home\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1223, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1267, 41, false);
#line 51 "C:\Users\tiago\Desktop\ES3.14_Grupo6\GestorHorarioG6\GestorHorarioG6\Views\Home\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Notas));

#line default
#line hidden
            EndContext();
            BeginContext(1308, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1352, 37, false);
#line 54 "C:\Users\tiago\Desktop\ES3.14_Grupo6\GestorHorarioG6\GestorHorarioG6\Views\Home\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Notas));

#line default
#line hidden
            EndContext();
            BeginContext(1389, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(1427, 214, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "73ae383311bd4993bd5bedf1c3de20c4", async() => {
                BeginContext(1453, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(1463, 47, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7a0588593bf24e5eafc553ee8d619521", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 59 "C:\Users\tiago\Desktop\ES3.14_Grupo6\GestorHorarioG6\GestorHorarioG6\Views\Home\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.FuncionarioID);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1510, 86, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Eliminar\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(1596, 32, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "69ec8caf312f46d180f16e38d8353d05", async() => {
                    BeginContext(1618, 6, true);
                    WriteLiteral("Voltar");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1628, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1641, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GestorHorarioG6.Models.Funcionario> Html { get; private set; }
    }
}
#pragma warning restore 1591
