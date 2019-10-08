using System;
using System.Collections.Generic;
using System.Text;

namespace EventBuyingMicroService.Domain.EventBuyingAggregate
{
    public class Events
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }
    }
}
