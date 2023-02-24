using System;
using AutoMapper;
using HyBe.Application.Abstractions.Services;
using HyBe.SharedKernel.Utilities;
using HyBe.Domain.Entities.Indicators;
using MediatR;
using HyBe.Domain.Contracts.Indicators;

namespace HyBe.Application.Features.Indicators.Queries;

public class GetByIdIndicatorQueryHandler : IRequestHandler<GetByIdIndicatorQuery, IResult>
{
    #region Fileds
    private readonly IIndicatorService _indicatorService;
    private readonly IMapper _mapper;
    #endregion

    #region Constructor
    public GetByIdIndicatorQueryHandler(IIndicatorService indicatorService, IMapper mapper)
    {
        _indicatorService = indicatorService;
        _mapper = mapper;
    }
    #endregion

    #region Methods
    public async Task<IResult> Handle(GetByIdIndicatorQuery query, CancellationToken cancellationToken)
    {

        var result = _indicatorService.Get(b => b.Id == query.Request.Id);
        if (result.Success)
        {
            var indicatorMapper = _mapper.Map<GetByIdIndicatorResponse>(result.Data);
            return new SuccessDataResult<GetByIdIndicatorResponse>(indicatorMapper);
        }
        return new ErrorDataResult<GetByIdIndicatorResponse>();
    }
    #endregion
}