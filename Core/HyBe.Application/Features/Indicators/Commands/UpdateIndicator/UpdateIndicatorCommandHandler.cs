using System;
using AutoMapper;
using HyBe.Application.Abstractions.Services;
using HyBe.SharedKernel.Utilities;
using HyBe.Domain.Entities.Indicators;
using MediatR;
using HyBe.Domain.Contracts.Indicators;

namespace HyBe.Application.Features.Indicators.Commands;

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
        var bot = _indicatorService.Get(x => x.Id == query.Request.Id);
        var getBacktest = _indicatorService.Get(b => b.MemberId.ToString() == query.MemberId && b.Id == query.Request.Id);
        if (getBacktest == null)
        {
            return new ErrorResult("Data Not Found!");
        }
        if (!bot.Success)
            return new ErrorResult();
        var result = _indicatorService.Update(query.Request.Id);
        if (result.Success)
            return new SuccessResult();
        return new ErrorResult();
    }
    #endregion
}

