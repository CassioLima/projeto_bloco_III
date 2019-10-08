using EventBuyingMicroService.Domain.EventBuyingAggregate;
using System;
using System.Collections.Generic;
using System.Text;

namespace EventBuyingMicroService.Domain.Services
{
    public class EventsBuyingManagerService
    {
        private readonly IEventBuyingCommandRepository _eventBuyingCommandRepository;

        public EventsBuyingManagerService(IEventBuyingCommandRepository eventBuyingCommandRepository)
        {
            _eventBuyingCommandRepository = eventBuyingCommandRepository;
        }

        public void AddEventsBuying(EventsBuyingEntity eventsBuying)
        {
            _eventBuyingCommandRepository.Create(eventsBuying);
            _eventBuyingCommandRepository.SaveChanges();
        }

    }
}
