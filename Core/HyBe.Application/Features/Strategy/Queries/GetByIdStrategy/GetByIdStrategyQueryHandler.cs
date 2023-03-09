using System;
using AutoMapper;
using HyBe.Application.Abstractions.Services;
using HyBe.Application.Features.Strategies.Queries;
using HyBe.Domain.Contracts.Strategies;
using HyBe.SharedKernel.Utilities;
using MediatR;


namespace HyBe.Application.Features.Strategys.Queries;

public class GetByIdStrategyQueryHandler : IRequestHandler<GetByIdStrategyQuery,IResult>
{
    #region Fileds
    private readonly IStrategyService _strategyService;
    private readonly IMapper _mapper;
    #endregion

    #region Constructor
    public GetByIdStrategyQueryHandler(IStrategyService strategyService, IMapper mapper)
    {
        _strategyService = strategyService;
        _mapper = mapper;
    }
    #endregion

    #region Methods
    public async Task<IResult> Handle(GetByIdStrategyQuery query, CancellationToken cancellationToken)
    {

        var result = _strategyService.Get(b=>b.Id == query.Request.Id);
        if (result.Success)
        {
            var strategyMapper = _mapper.Map<GetByIdStrategyResponse>(result.Data);
            return new SuccessDataResult<GetByIdStrategyResponse>(strategyMapper);
        }
        return new ErrorDataResult<GetByIdStrategyResponse>();
    }
    #endregion
}

