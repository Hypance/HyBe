using System;
using AutoMapper;
using HyBe.Domain.Contracts.strategies;
using HyBe.Domain.Entities.strategies;

namespace HyBe.Application.Features.strategies.Profiles;

public class StrategyProfile : Profile
{
    public StrategyProfile()
    {
        CreateMap<GetListstrategyResponse, strategy>();
        CreateMap<GetByIdstrategyResponse, strategy>();
        CreateMap<strategy, CreatestrategyRequest>();
        CreateMap<strategy, UpdatestrategyRequest>();
    }
}

