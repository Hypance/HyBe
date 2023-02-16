using System;
using AutoMapper;
using HyBe.Application.Abstractions.Services;
using HyBe.SharedKernel.Utilities;
using HyBe.Domain.Entities.Strategies;
using MediatR;
using HyBe.Domain.Contracts.Strategys;

namespace HyBe.Application.Features.Strategies.Queries;

public class DeleteStrategyCommandHandler : IRequestHandler<DeleteStrategyCommand,IResult>
{
    #region Fileds
    private readonly IStrategyService _strategyService;
    private readonly IMapper _mapper;
    #endregion

    #region Constructor
    public DeleteStrategyCommandHandler(IStrategyService strategyService, IMapper mapper)
    {
        _strategyService = strategyService;
        _mapper = mapper;
    }
    #endregion

    #region Methods
    public async Task<IResult> Handle(DeleteStrategyCommand query, CancellationToken cancellationToken)
    {
        var result = _strategyService.Delete(query.Request.Id);
        if (result.Success)
            return new SuccessResult();
        return new ErrorResult();
    }
    #endregion
}

