using System;
using AutoMapper;
using HyBe.Application.Abstractions.Services;
using HyBe.SharedKernel.Utilities;
using HyBe.Domain.Entities.Strategies;
using MediatR;
using HyBe.Domain.Contracts.Strategies;
using HyBe.Domain.Entities.Backtests;

namespace HyBe.Application.Features.Strategies.Queries;

public class UpdateStrategyCommandHandler : IRequestHandler<UpdateStrategyCommand,IResult>
{
    #region Fileds
    private readonly IStrategyService _strategyService;
    private readonly IMapper _mapper;
    #endregion

    #region Constructor
    public UpdateStrategyCommandHandler(IStrategyService strategyService, IMapper mapper)
    {
        _strategyService = strategyService;
        _mapper = mapper;
    }
    #endregion

    #region Methods
    public async Task<IResult> Handle(UpdateStrategyCommand query, CancellationToken cancellationToken)
    {
        var getStrategy = _strategyService.Get(b => b.MemberId.ToString() == query.MemberId && b.Id == query.Request.Id);
        if (getStrategy == null)
        {
            return new ErrorResult("Data Not Found!");
        }
        var strategyMapper = _mapper.Map<Strategy>(query.Request);
        var result = _strategyService.Update(strategyMapper);
        if (result.Success)
            return new SuccessResult();
        return new ErrorResult();
    }
    #endregion
}

