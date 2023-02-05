using System;
using AutoMapper;
using HyBe.Domain.Contracts.Candlesticks;
using HyBe.Domain.Entities.Symbols;

namespace HyBe.Application.Features.Candlesticks.Profiles;

public class CandlestickProfile : Profile
{
    public CandlestickProfile()
    {
        CreateMap<GetListCandlestickResponse, Candlestick>();
        CreateMap<GetByIdCandlestickResponse, Candlestick>();
        CreateMap<Candlestick, CreateCandlestickRequest>();
        CreateMap<Candlestick, UpdateCandlestickRequest>();
    }
}

