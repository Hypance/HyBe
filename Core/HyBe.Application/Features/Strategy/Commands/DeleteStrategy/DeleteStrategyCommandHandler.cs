using System;
using AutoMapper;
using HyBe.Application.Abstractions.Services;
using HyBe.SharedKernel.Utilities;
using HyBe.Domain.Entities.Strategies;
using MediatR;
 

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
        var getStrategy = _strategyService.Get(b => b.MemberId.ToString() == query.MemberId && b.Id == query.Request.Id);
        if (getStrategy.Success == false)
        {
            return new ErrorResult("Data Not Found!");
        }
        var result = _strategyService.Delete(query.Request.Id);
        if (result.Success)
            return new SuccessResult();
        return new ErrorResult(result.Message);
    }
    #endregion
}

