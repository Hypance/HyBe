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
        var backtestMapper = _mapper.Map<Backtest>(query.Request);
        var result = _backtestService.Update(backtestMapper);
        if (result.Success)
            return new SuccessResult();
        return new ErrorResult(result.Message);
    }
    #endregion
}

