using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EventsListMicroservices.Domain.Model
{
    public class Eventos
    {
        [Key]
        public int SEQ_EVENTO { get; set; }
        public string NOM_EVENTO { get; set; }
        public string DES_DETALHE { get; set; }
        public DateTime DTA_INICIO { get; set; }
        public DateTime DTA_FIM { get; set; }
        public Boolean STA_PAGO { get; set; }
        public string NOM_FAIXA_ETARIA { get; set; }
        public DateTime DTA_HORA_INICIO { get; set; }
        public DateTime DTA_HORA_FIM { get; set; }
        public int COD_LOCAL { get; set; }
        public string NOM_LOCAL { get; set; }
        public string NOM_LINGUAGEM { get; set; }
        public string NOM_IMAGEM { get; set; }
        public string NOM_CAMINHO_IMAGEM { get; set; }
        public string STA_ATIVO { get; set; }
        public string NOM_LOCAL_ABRANGENCIA { get; set; }

    }
}
