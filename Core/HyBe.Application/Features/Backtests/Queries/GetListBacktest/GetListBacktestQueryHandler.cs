using System;
using AutoMapper;
using HyBe.Application.Abstractions.Services;
using HyBe.SharedKernel.Utilities;
using HyBe.Domain.Entities.Backtests;
using MediatR;
using HyBe.Domain.Contracts.Backtests;

namespace HyBe.Application.Features.Backtests.Queries;

public class GetListBacktestQueryHandler : IRequestHandler<GetListBacktestQuery,IResult>
{
    #region Fileds
    private readonly IBacktestService _backtestService;
    private readonly IMapper _mapper;
    #endregion

    #region Constructor
    public GetListBacktestQueryHandler(IBacktestService backtestService, IMapper mapper)
    {
        _backtestService = backtestService;
        _mapper = mapper;
    }
    #endregion

    #region Methods
    public async Task<IResult> Handle(GetListBacktestQuery query, CancellationToken cancellationToken)
    {

        var result = _backtestService.GetAll();
        if (result.Success)
        {
            var backtestMapper = _mapper.Map<List<GetListBacktestResponse>>(result.Data);
            return new SuccessDataResult<List<GetListBacktestResponse>>(backtestMapper);
        }
        return new ErrorDataResult<List<GetListBacktestResponse>>(result.Message);
    }
    #endregion
}

