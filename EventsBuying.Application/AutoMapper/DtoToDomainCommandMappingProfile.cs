using AutoMapper;
using EventBuyingMicroService.Domain.CQRS.Commands;
using EventBuyingMicroService.Domain.EventBuyingAggregate;
using EventsBuying.Application.AppModel.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace EventsBuying.Application.AutoMapper
{
    public class DtoToDomainCommandMappingProfile : Profile
    {
        public DtoToDomainCommandMappingProfile()
        {
            var dtoConfig = AutoMapperConfig.RegisterDtoDomainMappings();
            var mapper = dtoConfig.CreateMapper();

            CreateMap<EventsBuyingDTO, AddEventsBuyingCommands>()
                .ConstructUsing(a => new AddEventsBuyingCommands(mapper.Map<EventsBuyingDTO, EventsBuyingEntity>(a)));
        }
    }
}
