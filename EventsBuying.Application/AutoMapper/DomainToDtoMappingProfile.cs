using AutoMapper;
using EventBuyingMicroService.Domain.EventBuyingAggregate;
using EventsBuying.Application.AppModel.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace EventsBuying.Application.AutoMapper
{
    public class DomainToDtoMappingProfile : Profile
    {
        public DomainToDtoMappingProfile()
        {
            CreateMap<EventsBuyingEntity, EventsBuyingDTO>();
        }
    }
}
