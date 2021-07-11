#pragma checksum "C:\projetos\kinvo-back-end-test\Aliquota.Domain\Views\Investments\Rescue.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e62679afeb2524da2be1e612ebbef5221c4fab56"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Investments_Rescue), @"mvc.1.0.view", @"/Views/Investments/Rescue.cshtml")]
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
#line 1 "C:\projetos\kinvo-back-end-test\Aliquota.Domain\Views\_ViewImports.cshtml"
using Aliquota.Domain;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\projetos\kinvo-back-end-test\Aliquota.Domain\Views\_ViewImports.cshtml"
using Aliquota.Domain.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e62679afeb2524da2be1e612ebbef5221c4fab56", @"/Views/Investments/Rescue.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a945cf6aa20908a1d46f86c17747c3215055b8f", @"/Views/_ViewImports.cshtml")]
    public class Views_Investments_Rescue : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Investment>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Rescue", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\projetos\kinvo-back-end-test\Aliquota.Domain\Views\Investments\Rescue.cshtml"
  
    ViewData["Title"] = "Resgate";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h3>");
#nullable restore
#line 7 "C:\projetos\kinvo-back-end-test\Aliquota.Domain\Views\Investments\Rescue.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>


<div class=""alert alert-info"" role=""alert"">
    <h4 class=""alert-heading"">Informações sobre o cálculo do Imposto de Renda</h4>
    <p>
        O Imposto de Renda só é recolhido quando você faz o resgate. O cálculo de IR se dá em cima do seu valor final de lucro e
        segue a seguinte lógica:
    </p>
    <hr>
    <p class=""mb-0"">
        <ul>
            <li>Até 1 ano de aplicação: 22,5% sobre o lucro</li>
            <li>De 1 a 2 anos de aplicação: 18,5% sobre o lucro</li>
            <li>Acima de 2 anos de aplicação: 15% sobre o lucro</li>
            <li>Seu investimento rende aproximadamente 4,15% ao ano de lucro</li>
        </ul>
    </p>
</div>

<div class=""row"">
    <div class=""col-md-4"">
        <strong>");
#nullable restore
#line 29 "C:\projetos\kinvo-back-end-test\Aliquota.Domain\Views\Investments\Rescue.cshtml"
           Write(Html.DisplayNameFor(x => x.InvestmentDate));

#line default
#line hidden
#nullable disable
            WriteLiteral(" : </strong> ");
#nullable restore
#line 29 "C:\projetos\kinvo-back-end-test\Aliquota.Domain\Views\Investments\Rescue.cshtml"
                                                                   Write(Model.InvestmentDate.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"col-md-4\">\r\n        <strong>");
#nullable restore
#line 32 "C:\projetos\kinvo-back-end-test\Aliquota.Domain\Views\Investments\Rescue.cshtml"
           Write(Html.DisplayNameFor(x => x.RescueDate));

#line default
#line hidden
#nullable disable
            WriteLiteral(" : </strong> ");
#nullable restore
#line 32 "C:\projetos\kinvo-back-end-test\Aliquota.Domain\Views\Investments\Rescue.cshtml"
                                                               Write(ViewBag.RescueDate.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"col-md-4\">\r\n        <strong> Tempo investindo (dias) : </strong> ");
#nullable restore
#line 35 "C:\projetos\kinvo-back-end-test\Aliquota.Domain\Views\Investments\Rescue.cshtml"
                                                Write(ViewBag.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<div class=\"row\">\r\n    <div class=\"col-md-4\">\r\n        <strong>");
#nullable restore
#line 40 "C:\projetos\kinvo-back-end-test\Aliquota.Domain\Views\Investments\Rescue.cshtml"
           Write(Html.DisplayNameFor(x => x.Value));

#line default
#line hidden
#nullable disable
            WriteLiteral(" : </strong> ");
#nullable restore
#line 40 "C:\projetos\kinvo-back-end-test\Aliquota.Domain\Views\Investments\Rescue.cshtml"
                                                          Write(Model.Value.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"col-md-4\">\r\n        <strong>Lucro Total : </strong> ");
#nullable restore
#line 43 "C:\projetos\kinvo-back-end-test\Aliquota.Domain\Views\Investments\Rescue.cshtml"
                                   Write(ViewBag.TotalProfit.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"col-md-4\">\r\n        <strong>Porcentagem do IR : </strong> ");
#nullable restore
#line 46 "C:\projetos\kinvo-back-end-test\Aliquota.Domain\Views\Investments\Rescue.cshtml"
                                         Write(ViewBag.Percentage.ToString("N1"));

#line default
#line hidden
#nullable disable
            WriteLiteral("%\r\n    </div>\r\n</div>\r\n<div class=\"row\">\r\n    <div class=\"col-md-4\">\r\n        <strong>Desconto do IR : </strong> ");
#nullable restore
#line 51 "C:\projetos\kinvo-back-end-test\Aliquota.Domain\Views\Investments\Rescue.cshtml"
                                      Write(ViewBag.Discout.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"col-md-4\">\r\n        <strong>Valor total de Resgate : </strong> ");
#nullable restore
#line 54 "C:\projetos\kinvo-back-end-test\Aliquota.Domain\Views\Investments\Rescue.cshtml"
                                              Write(ViewBag.RescueTotal.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n<br />\r\n\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e62679afeb2524da2be1e612ebbef5221c4fab569423", async() => {
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e62679afeb2524da2be1e612ebbef5221c4fab569689", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 62 "C:\projetos\kinvo-back-end-test\Aliquota.Domain\Views\Investments\Rescue.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Confirmar Resgate\" class=\"btn btn-success\" />\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e62679afeb2524da2be1e612ebbef5221c4fab5611485", async() => {
                    WriteLiteral("Voltar a página inicial");
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
                WriteLiteral("\r\n    ");
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
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Investment> Html { get; private set; }
    }
}
#pragma warning restore 1591