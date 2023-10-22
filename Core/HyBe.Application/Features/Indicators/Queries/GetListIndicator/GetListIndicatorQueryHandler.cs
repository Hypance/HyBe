using System;
using AutoMapper;
using HyBe.Application.Abstractions.Services;
using HyBe.SharedKernel.Utilities;
using HyBe.Domain.Entities.Indicators;
using MediatR;
using HyBe.Domain.Contracts.Indicators;
using HyBe.Domain.Contracts.Backtests;
using HyBe.Domain.Contracts.Formations;

namespace HyBe.Application.Features.Indicators.Queries;

public class GetListIndicatorQueryHandler : IRequestHandler<GetListIndicatorQuery, IResult>
{
    #region Fileds
    private readonly IIndicatorService _indicatorService;
    private readonly IMapper _mapper;
    #endregion

    #region Constructor
    public GetListIndicatorQueryHandler(IIndicatorService indicatorService, IMapper mapper)
    {
        _indicatorService = indicatorService;
        _mapper = mapper;
    }
    #endregion

    #region Methods
    public async Task<IResult> Handle(GetListIndicatorQuery query, CancellationToken cancellationToken)
    {

        var result = _indicatorService.GetAll(b => b.MemberId.ToString() == query.Request.MemberId);
        if (result.Success)
        {
            var indicatorMapper = _mapper.Map<List<GetListIndicatorResponse>>(result.Data);
            return new SuccessDataResult<List<GetListIndicatorResponse>>(indicatorMapper);
        }
        return new ErrorDataResult<List<GetListIndicatorResponse>>(result.Message);
    }
    #endregion
}

