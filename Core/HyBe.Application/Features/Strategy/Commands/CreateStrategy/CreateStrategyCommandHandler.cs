using System;
using AutoMapper;
using HyBe.Application.Abstractions.Services;
using HyBe.SharedKernel.Utilities;
using HyBe.Domain.Entities.Strategies;
using MediatR;
using HyBe.Domain.Contracts.Strategies;
using HyBe.Application.Features.Strategies.Queries;

namespace HyBe.Application.Features.Strategys.Queries;

public class CreateStrategyCommandHandler : IRequestHandler<CreateStrategyCommand,IResult>
{
    #region Fileds
    private readonly IStrategyService _strategyService;
    private readonly IMapper _mapper;
    #endregion

    #region Constructor
    public CreateStrategyCommandHandler(IStrategyService strategyService, IMapper mapper)
    {
        _strategyService = strategyService;
        _mapper = mapper;
    }
    #endregion

    #region Methods
    public async Task<IResult> Handle(CreateStrategyCommand query, CancellationToken cancellationToken)
    {
        var strategyMapper = _mapper.Map<Strategy>(query.Request);
        var result = _strategyService.Add(strategyMapper);
        if (result.Success)
            return new SuccessResult();
        return new ErrorResult();
    }
    #endregion
}

