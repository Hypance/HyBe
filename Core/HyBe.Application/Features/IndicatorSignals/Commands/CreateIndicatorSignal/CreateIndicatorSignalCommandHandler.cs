using AutoMapper;
using HyBe.Application.Abstractions.Services;
using HyBe.Domain.Entities.Indicators;
using HyBe.SharedKernel.Utilities;
using MediatR;
using System;

namespace HyBe.Application.Features.IndicatorSignals.Commands.CreateIndicatorSignal;
public class CreateIndicatorSignalCommandHandler : IRequestHandler<CreateIndicatorSignalCommand, IResult>
{
    #region Fileds
    private readonly IIndicatorSignalService _indicatorSignalService;
    private readonly IMapper _mapper;
    #endregion

    #region Constructor
    public CreateIndicatorSignalCommandHandler(IIndicatorSignalService indicatorSignalService, IMapper mapper)
    {
        _indicatorSignalService = indicatorSignalService;
        _mapper = mapper;
    }
    #endregion

    #region Methods
    public async Task<IResult> Handle(CreateIndicatorSignalCommand query, CancellationToken cancellationToken)
    {
        var indicatorSignalMapper = _mapper.Map<IndicatorSignal>(query.Request);
        var result = _indicatorSignalService.Add(indicatorSignalMapper);
        if (result.Success)
            return new SuccessResult();
        return new ErrorResult();
    }
    #endregion
}