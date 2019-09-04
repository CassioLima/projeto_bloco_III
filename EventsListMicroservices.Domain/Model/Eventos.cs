using System;
using System.Collections.Generic;
using System.Text;

namespace EventsListMicroservices.Domain.Model
{
    public class Eventos
    {
        int SEQ_EVENTO { get; set; }
        string NOM_EVENTO { get; set; }
        string DES_DETALHE { get; set; }
        string DTA_INICIO { get; set; }
        string DTA_FIM { get; set; }
        string STA_PAGO { get; set; }
        string NOM_FAIXA_ETARIA { get; set; }
        string DTA_HORA_INICIO { get; set; }
        string DTA_HORA_FIM { get; set; }
        string COD_LOCAL { get; set; }
        string NOM_LOCAL { get; set; }
        string NOM_LINGUAGEM { get; set; }
        string NOM_IMAGEM { get; set; }
        string NOM_CAMINHO_IMAGEM { get; set; }
        string STA_ATIVO { get; set; }
        string NOM_LOCAL_ABRANGENCIA { get; set; }

    }
}
