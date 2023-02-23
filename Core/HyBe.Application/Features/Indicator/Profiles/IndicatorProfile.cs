using System;
using AutoMapper;
using HyBe.Domain.Contracts.Indicators;
using HyBe.Domain.Entities.Indicators;

namespace HyBe.Application.Features.Indicators.Profiles;

public class IndicatorProfile : Profile
{
    public IndicatorProfile()
    {
        CreateMap<Indicator , GetListIndicatorResponse>().ReverseMap();
        CreateMap<Indicator , GetByIdIndicatorResponse>().ReverseMap();
        CreateMap<CreateIndicatorRequest, Indicator>().ReverseMap();
        CreateMap<UpdateIndicatorRequest, Indicator>().ReverseMap();
    }
}

