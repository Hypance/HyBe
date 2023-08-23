using System;
using AutoMapper;
using HyBe.Application.Abstractions.Services;
using HyBe.SharedKernel.Utilities;
using HyBe.Domain.Entities.Backtests;
using MediatR;
using HyBe.Domain.Contracts.Backtests;

namespace HyBe.Application.Features.Backtests.Queries;

public class UpdateBacktestCommandHandler : IRequestHandler<UpdateBacktestCommand,IResult>
{
    #region Fileds
    private readonly IBacktestService _backtestService;
    private readonly IMapper _mapper;
    #endregion

    #region Constructor
    public UpdateBacktestCommandHandler(IBacktestService backtestService, IMapper mapper)
    {
        _backtestService = backtestService;
        _mapper = mapper;
    }
    #endregion

    #region Methods
    public async Task<IResult> Handle(UpdateBacktestCommand query, CancellationToken cancellationToken)
    {
        var backtest = _backtestService.Get(x => x.Id == query.Request.Id);
        var getBacktest = _backtestService.Get(b => b.MemberId.ToString() == query.MemberId && b.Id == query.Request.Id);
        if (getBacktest == null) 
        {
            return new ErrorResult("Data Not Found!");
        }
        if (!backtest.Success)
            return new ErrorResult();
        var result = _backtestService.Update(query.Request.Id);
        if (result.Success)
            return new SuccessResult();
        return new ErrorResult();
    }
    #endregion
}
