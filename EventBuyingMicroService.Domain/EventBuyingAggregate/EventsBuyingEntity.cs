using System;
using System.Collections.Generic;
using System.Text;

namespace EventBuyingMicroService.Domain.EventBuyingAggregate
{
    public class EventsBuyingEntity
    {
        public int Id { get; set; }
        public string Nome{ get; set; }
        public int IdEvento { get; set; }
        public string NomeEvento { get; set; }
    }
}
