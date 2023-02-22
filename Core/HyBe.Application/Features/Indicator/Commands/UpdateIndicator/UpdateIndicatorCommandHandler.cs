using System;
using AutoMapper;
using HyBe.Application.Abstractions.Services;
using HyBe.SharedKernel.Utilities;
using HyBe.Domain.Entities.Indicators;
using MediatR;
using HyBe.Domain.Contracts.Indicators;

namespace HyBe.Application.Features.Indicators.Queries;

public class UpdateIndicatorCommandHandler : IRequestHandler<UpdateIndicatorCommand, IResult>
{
    #region Fileds
    private readonly IIndicatorService _indicatorService;
    private readonly IMapper _mapper;
    #endregion

    #region Constructor
    public UpdateIndicatorCommandHandler(IIndicatorService indicatorService, IMapper mapper)
    {
        _indicatorService = indicatorService;
        _mapper = mapper;
    }
    #endregion

    #region Methods
    public async Task<IResult> Handle(UpdateIndicatorCommand query, CancellationToken cancellationToken)
    {
        var indicatorMapper = _mapper.Map<Indicator>(query.Request);
        var result = _indicatorService.Update(indicatorMapper);
        if (result.Success)
            return new SuccessResult();
        return new ErrorResult();
    }
    #endregion
}

