using System;
using AutoMapper;
using HyBe.Domain.Contracts.Backtests;
using HyBe.Domain.Entities.Backtests;

namespace HyBe.Application.Features.Backtests.Profiles;

public class BacktestProfile : Profile
{
	public BacktestProfile()
	{
        CreateMap<GetListBacktestResponse, Backtest>();
        CreateMap<GetByIdBacktestResponse, Backtest>();
        CreateMap<Backtest, CreateBacktestRequest>();
        CreateMap<Backtest, UpdateBacktestRequest>();
    }
}

