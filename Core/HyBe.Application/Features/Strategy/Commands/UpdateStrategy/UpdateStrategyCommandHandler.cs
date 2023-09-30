using System;
using AutoMapper;
using HyBe.Application.Abstractions.Services;
using HyBe.SharedKernel.Utilities;
using HyBe.Domain.Entities.Strategies;
using MediatR;
using HyBe.Domain.Contracts.Strategies;

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
        var bot = _strategyService.Get(x => x.Id == query.Request.Id);
        var getBacktest = _strategyService.Get(b => b.MemberId.ToString() == query.MemberId && b.Id == query.Request.Id);
        if (getBacktest == null)
        {
            return new ErrorResult("Data Not Found!");
        }
        if (!bot.Success)
            return new ErrorResult();
        var result = _strategyService.Update(query.Request.Id);
        if (result.Success)
            return new SuccessResult();
        return new ErrorResult();
    }
    #endregion
}

