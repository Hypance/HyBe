using System;
using AutoMapper;
using HyBe.Application.Abstractions.Services;
using HyBe.SharedKernel.Utilities;
using HyBe.Domain.Entities.Indicators;
using MediatR;
using HyBe.Domain.Contracts.Indicators;

namespace HyBe.Application.Features.Indicators.Queries;

public class CreateIndicatorCommandHandler : IRequestHandler<CreateIndicatorCommand, IResult>
{
    #region Fileds
    private readonly IIndicatorService _indicatorService;
    private readonly IMapper _mapper;
    #endregion

    #region Constructor
    public CreateIndicatorCommandHandler(IIndicatorService indicatorService, IMapper mapper)
    {
        _indicatorService = indicatorService;
        _mapper = mapper;
    }
    #endregion

    #region Methods
    public async Task<IResult> Handle(CreateIndicatorCommand query, CancellationToken cancellationToken)
    {
        var indicatorMapper = _mapper.Map<Indicator>(query.Request);
        var result = _indicatorService.Add(indicatorMapper);
        if (result.Success)
            return new SuccessResult();
        return new ErrorResult();
    }
    #endregion
}

