using System;
using AutoMapper;
using HyBe.Application.Abstractions.Services;
using HyBe.SharedKernel.Utilities;
using HyBe.Domain.Entities.Strategies;
using MediatR;
using HyBe.Domain.Contracts.Strategies;

namespace HyBe.Application.Features.Strategies.Queries;

public class GetListStrategyQueryHandler : IRequestHandler<GetListStrategyQuery,IResult>
{
    #region Fileds
    private readonly IStrategyService _strategyService;
    private readonly IMapper _mapper;
    #endregion

    #region Constructor
    public GetListStrategyQueryHandler(IStrategyService strategyService, IMapper mapper)
    {
        _strategyService = strategyService;
        _mapper = mapper;
    }
    #endregion

    #region Methods
    public async Task<IResult> Handle(GetListStrategyQuery query, CancellationToken cancellationToken)
    {

        var result = _strategyService.GetAll(b => b.MemberId.ToString() == query.Request.MemberId);
        if (result.Success)
        {
            var strategyMapper = _mapper.Map<List<GetListStrategyResponse>>(result.Data);
            return new SuccessDataResult<List<GetListStrategyResponse>>(strategyMapper);
        }
        return new ErrorDataResult<List<GetListStrategyResponse>>(result.Message);
    }
    #endregion
}

