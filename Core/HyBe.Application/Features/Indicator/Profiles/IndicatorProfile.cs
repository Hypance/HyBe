using System;
using AutoMapper;
using HyBe.Domain.Contracts.Indicators;
using HyBe.Domain.Entities.Indicators;

namespace HyBe.Application.Features.Indicators.Profiles;

public class IndicatorProfile : Profile
{
    public IndicatorProfile()
    {
        CreateMap<GetListIndicatorResponse, Indicator>();
        CreateMap<GetByIdIndicatorResponse, Indicator>();
        CreateMap<Indicator, CreateIndicatorRequest>();
        CreateMap<Indicator, UpdateIndicatorRequest>();
    }
}

