using EventBuyingMicroService.Domain.CatalogEventAggregate;
using System;
using System.Collections.Generic;
using System.Text;

namespace EventBuyingMicroService.Domain.EventBuyingAggregate
{
    public class EventsBuyingEntity
    {
        public Guid Id { get; set; }
        public DateTime DataCompra { get; set; }
        public EventBuyingStatus Status { get; set; }
        public string NumeroOrdemCompra { get; set; }
        public decimal Valor { get; set; }
        public string Observacao { get; set; }
        public string StatusNotificacao { get; set; }
        public Events Evento { get; set; }
        public Comprador Comprador { get; set; }
    }
}
