using System;
using AutoMapper;
using HyBe.Application.Abstractions.Services;
using HyBe.SharedKernel.Utilities;
using HyBe.Domain.Entities.Indicators;
using MediatR;
using HyBe.Domain.Contracts.IndicatorSignals;

namespace HyBe.Application.Features.IndicatorSignals.Commands.DeleteIndicatorSignal;

public class DeleteIndicatorSignalCommandHandler : IRequestHandler<DeleteIndicatorSignalCommand, IResult>
{
    #region Fileds
    private readonly IIndicatorSignalService _indicatorSignalService;
    private readonly IMapper _mapper;
    #endregion

    #region Constructor
    public DeleteIndicatorSignalCommandHandler(IIndicatorSignalService indicatorSignalService, IMapper mapper)
    {
        _indicatorSignalService = indicatorSignalService;
        _mapper = mapper;
    }
    #endregion

    #region Methods
    public async Task<IResult> Handle(DeleteIndicatorSignalCommand query, CancellationToken cancellationToken)
    {
        var result = _indicatorSignalService.Delete(query.Request.Id);
        if (result.Success)
            return new SuccessResult();
        return new ErrorResult();
    }
    #endregion
}
