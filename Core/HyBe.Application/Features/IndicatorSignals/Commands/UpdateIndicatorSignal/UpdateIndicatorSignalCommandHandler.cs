using AutoMapper;
using HyBe.Application.Abstractions.Services;
using HyBe.Domain.Entities.Indicators;
using HyBe.SharedKernel.Utilities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyBe.Application.Features.IndicatorSignals.Commands.UpdateIndicatorSignal;

public class UpdateIndicatorSignalCommandHandler : IRequestHandler<UpdateIndicatorSignalCommand, IResult>
{
    #region Fileds
    private readonly IIndicatorSignalService _indicatorSignalService;
    private readonly IMapper _mapper;
    #endregion

    #region Constructor
    public UpdateIndicatorSignalCommandHandler(IIndicatorSignalService indicatorSignalService, IMapper mapper)
    {
        _indicatorSignalService = indicatorSignalService;
        _mapper = mapper;
    }
    #endregion

    #region Methods
    public async Task<IResult> Handle(UpdateIndicatorSignalCommand query, CancellationToken cancellationToken)
    {
        var getIndicatorSignal = _indicatorSignalService.Get(b => b.MemberId.ToString() == query.MemberId && b.Id == query.Request.Id);
        if (getIndicatorSignal == null)
        {
            return new ErrorResult("Data Not Found!");
        }
        var indicatorSignalMapper = _mapper.Map<IndicatorSignal>(query.Request);
        var result = _indicatorSignalService.Update(indicatorSignalMapper);
        if (result.Success)
            return new SuccessResult();
        return new ErrorResult();
    }
    #endregion
}