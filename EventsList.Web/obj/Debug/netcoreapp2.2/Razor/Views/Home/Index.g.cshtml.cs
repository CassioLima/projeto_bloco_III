#pragma checksum "C:\projetos\Infnet_ProjetoBloco_3\projeto_bloco_III\EventsList.Web\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ee9afb05ccad7cd12c640bb2bf5ff4e57337cbc8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\projetos\Infnet_ProjetoBloco_3\projeto_bloco_III\EventsList.Web\Views\_ViewImports.cshtml"
using EventsList.Web;

#line default
#line hidden
#line 2 "C:\projetos\Infnet_ProjetoBloco_3\projeto_bloco_III\EventsList.Web\Views\_ViewImports.cshtml"
using EventsList.Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee9afb05ccad7cd12c640bb2bf5ff4e57337cbc8", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"339a23e0d2584eebcc17f2c58e4170de3200c623", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EventsListMicroservices.Domain.Model.Eventos>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(66, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\projetos\Infnet_ProjetoBloco_3\projeto_bloco_III\EventsList.Web\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(113, 142, true);
            WriteLiteral("\r\n<script src=\"http://ajax.googleapis.com/ajax/libs/jquery/1.7.1/jquery.min.js\" type=\"text/javascript\"></script>\r\n\r\n<div class=\"list-group\">\r\n");
            EndContext();
#line 10 "C:\projetos\Infnet_ProjetoBloco_3\projeto_bloco_III\EventsList.Web\Views\Home\Index.cshtml"
     foreach (var evento in Model)
    {


#line default
#line hidden
            BeginContext(300, 218, true);
            WriteLiteral("        <a href=\"#\" class=\"list-group-item list-group-item-action flex-column align-items-start\">\r\n            <div class=\"d-flex w-100 justify-content-between\">\r\n                <h5 class=\"mb-1\">\r\n                    ");
            EndContext();
            BeginContext(519, 17, false);
#line 16 "C:\projetos\Infnet_ProjetoBloco_3\projeto_bloco_III\EventsList.Web\Views\Home\Index.cshtml"
               Write(evento.NOM_EVENTO);

#line default
#line hidden
            EndContext();
            BeginContext(536, 394, true);
            WriteLiteral(@"
                </h5>
                <small class=""text-muted"">3 dias atrás</small>
            </div>
            <p class=""mb-1"">Donec id elit non mi porta gravida at eget metus. Maecenas sed diam eget risus varius blandit.</p>
            <small class=""text-muted"">Donec id elit non mi porta.</small>
            <span class=""badge badge-primary badge-pill"">15</span>
        </a>
");
            EndContext();
#line 24 "C:\projetos\Infnet_ProjetoBloco_3\projeto_bloco_III\EventsList.Web\Views\Home\Index.cshtml"


    }

#line default
#line hidden
            BeginContext(941, 12, true);
            WriteLiteral("</div>\r\n\r\n\r\n");
            EndContext();
            BeginContext(1208, 1640, true);
            WriteLiteral(@"
<div id=""iddiv"" class=""modal fade"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <!--<button type=""button"" class=""close"" data-dismiss=""modal""><span aria-hidden=""true"">×</span><span class=""sr-only"">Close</span></button>-->
                <h4 class=""modal-title"">Gerar ingresso do evento</h4>
            </div>
            <div class=""modal-body"">
                <p><div id=""sNomeEvento""></div></p>
                <div class=""input-group"">
                    <div class=""input-group-prepend"">
                        <span class=""input-group-text"" id="""">Informe seu nome</span>
                    </div>
                    <input type=""text"" class=""form-control"">
                </div>

            </div>
        <div class=""modal-footer"">
            <button type=""button"" class=""btn btn-default"" data-dismiss=""modal"">Close</button>
            <button type=""button"" id=""btnExportWord"" class=""btn btn-primary"">Gerar In");
            WriteLiteral(@"gresso</button>
        </div>
    </div><!-- /.modal-content -->
            </div><!-- /.modal-dialog -->
</div><!-- /.modal -->




<script>


    $(document).ready(function () {
        $("".list-group-item"").on('click', function () {


            $('.active').removeClass('active');
            $(this).addClass('active');


            sNomeEvento.innerText = ""Nome do Evento: ""+  $(this).children().children()[0].innerText;

            $('#iddiv').modal('show'); 

            console.log($(this).children().children()[0].innerText);



        });
    });

</script>




");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EventsListMicroservices.Domain.Model.Eventos>> Html { get; private set; }
    }
}
#pragma warning restore 1591
