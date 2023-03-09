using System;
using AutoMapper;
using HyBe.Domain.Contracts.Strategies;
using HyBe.Domain.Entities.Strategies;

namespace HyBe.Application.Features.strategies.Profiles;

public class StrategyProfile : Profile
{
    public StrategyProfile()
    {
        CreateMap<Strategy, GetListStrategyResponse>().ReverseMap();
        CreateMap<Strategy, GetByIdStrategyResponse>().ReverseMap();
        CreateMap<CreateStrategyRequest, Strategy>();
        CreateMap<UpdateStrategyRequest, Strategy>();
    }
}

