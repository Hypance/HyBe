using System;
using AutoMapper;
using HyBe.Application.Abstractions.Services;
using HyBe.SharedKernel.Utilities;
using HyBe.Domain.Entities.Backtests;
using MediatR;
using HyBe.Domain.Contracts.Backtests;

namespace HyBe.Application.Features.Backtests.Queries;

public class DeleteBacktestCommandHandler : IRequestHandler<DeleteBacktestCommand,IResult>
{
    #region Fileds
    private readonly IBacktestService _backtestService;
    private readonly IMapper _mapper;
    #endregion

    #region Constructor
    public DeleteBacktestCommandHandler(IBacktestService backtestService, IMapper mapper)
    {
        _backtestService = backtestService;
        _mapper = mapper;
    }
    #endregion

    #region Methods
    public async Task<IResult> Handle(DeleteBacktestCommand query, CancellationToken cancellationToken)
    {
        var result = _backtestService.Delete(query.Request.Id);
        if (result.Success)
            return new SuccessResult();
        return new ErrorResult();
    }
    #endregion
}

