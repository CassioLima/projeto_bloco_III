using AutoMapper;
using EventBuyingMicroService.Domain.CQRS.Commands;
using EventBuyingMicroService.Domain.Interfaces.CQRS;
using EventBuyingMicroService.Domain.Services;
using EventsBuying.Application.AppModel.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace EventsBuying.Application
{
    public class ApiAppService
    {
        private readonly IQueue _queue;
        private readonly IMapper _mapper;
        private readonly EventsBuyingManagerService _eventsBuyingManagerService;

        public ApiAppService(IQueue queue, IMapper mapper, EventsBuyingManagerService eventsBuyingManagerService)
        {
            _queue = queue;
            _mapper = mapper;
            _eventsBuyingManagerService = eventsBuyingManagerService;
        }

        //Commands
        public void AddEventsBuying(EventsBuyingDTO eventsBuyingDTO)
        {
            var command = _mapper.Map<AddEventsBuyingCommands>(eventsBuyingDTO);
            _queue.Enqueue(command);
        }
    }
}
