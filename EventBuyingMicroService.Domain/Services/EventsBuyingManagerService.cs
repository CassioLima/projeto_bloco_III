using EventBuyingMicroService.Domain.EventBuyingAggregate;
using EventBuyingMicroService.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace EventBuyingMicroService.Domain.Services
{
    public class EventsBuyingManagerService
    {   
        private readonly IEventBuyingRepository _eventBuyingRepository;

        public EventsBuyingManagerService(IEventBuyingRepository eventBuyingRepository)
        {
            _eventBuyingRepository = eventBuyingRepository;
        }

        public void AddEventsBuying(EventsBuyingEntity eventsBuying)
        {
            _eventBuyingRepository.Create(eventsBuying);
        }

    }
}
