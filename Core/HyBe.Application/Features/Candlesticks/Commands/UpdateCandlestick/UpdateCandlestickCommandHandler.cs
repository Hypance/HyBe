using System;
using AutoMapper;
using HyBe.Application.Abstractions.Services;
using HyBe.SharedKernel.Utilities;
using HyBe.Domain.Entities.Symbols;
using MediatR;
using HyBe.Domain.Contracts.Candlesticks;

namespace HyBe.Application.Features.Candlesticks.Queries;

public class UpdateCandlestickCommandHandler : IRequestHandler<UpdateCandlestickCommand, IResult>
{
    #region Fileds
    private readonly ICandlestickServices _candlestickService;
    private readonly IMapper _mapper;
    #endregion

    #region Constructor
    public UpdateCandlestickCommandHandler(ICandlestickServices candlestickService, IMapper mapper)
    {
        _candlestickService = candlestickService;
        _mapper = mapper;
    }
    #endregion

    #region Methods
    public async Task<IResult> Handle(UpdateCandlestickCommand query, CancellationToken cancellationToken)
    {
        var backtest = _candlestickService.Get(x => x.Id == query.Request.Id);
        var getBacktest = _candlestickService.Get(b => b.MemberId.ToString() == query.MemberId && b.Id == query.Request.Id);
        if (getBacktest == null)
        {
            return new ErrorResult("Data Not Found!");
        }
        if (!backtest.Success)
            return new ErrorResult();
        var result = _candlestickService.Update(query.Request.Id);
        if (result.Success)
            return new SuccessResult();
        return new ErrorResult();
    }
    #endregion
}

