using System;
using AutoMapper;
using HyBe.Application.Abstractions.Services;
using HyBe.SharedKernel.Utilities;
using HyBe.Domain.Entities.Backtests;
using MediatR;
using HyBe.Domain.Contracts.Backtests;

namespace HyBe.Application.Features.Backtests.Queries;

public class GetByIdBacktestQueryHandler : IRequestHandler<GetByIdBacktestQuery,IResult>
{
    #region Fileds
    private readonly IBacktestService _backtestService;
    private readonly IMapper _mapper;
    #endregion

    #region Constructor
    public GetByIdBacktestQueryHandler(IBacktestService backtestService, IMapper mapper)
    {
        _backtestService = backtestService;
        _mapper = mapper;
    }
    #endregion

    #region Methods
    public async Task<IResult> Handle(GetByIdBacktestQuery query, CancellationToken cancellationToken)
    {

        var result = _backtestService.Get(b => b.MemberId.ToString() == query.Request.MemberId && b.Id == query.Request.Id);
        if (result.Success)
        {
            var backtestMapper = _mapper.Map<GetByIdBacktestResponse>(result.Data);
            return new SuccessDataResult<GetByIdBacktestResponse>(backtestMapper);
        }
        return new ErrorDataResult<GetByIdBacktestResponse>(result.Message);
    }
    #endregion
}

