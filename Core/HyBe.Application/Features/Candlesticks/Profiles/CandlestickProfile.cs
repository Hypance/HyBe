using System;
using AutoMapper;
using HyBe.Domain.Contracts.Candlesticks;
using HyBe.Domain.Entities.Symbols;

namespace HyBe.Application.Features.Candlesticks.Profiles;

public class CandlestickProfile : Profile
{
    public CandlestickProfile()
    {
        CreateMap<Candlestick, GetListCandlestickResponse>();
        CreateMap<Candlestick, GetByIdCandlestickResponse>();
        CreateMap<CreateCandlestickRequest, Candlestick>();
        CreateMap<UpdateCandlestickRequest, Candlestick>();
    }
}

