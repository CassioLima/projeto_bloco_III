using EventBuyingMicroService.Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace EventBuyingMicroService.Domain.CQRS.Commands
{
    public class CommandHandler
    {
        private readonly EventsBuyingManagerService _eventsBuyingManagerService;
        public CommandHandler(EventsBuyingManagerService eventsBuyingManagerService)
        {
            _eventsBuyingManagerService = eventsBuyingManagerService;
        }

        public void Handle(AddEventsBuyingCommands command)
        {
            _eventsBuyingManagerService.AddEventsBuying(command.EventsBuying);
        }
    }
}
