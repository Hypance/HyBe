using System;
using AutoMapper;
using HyBe.Application.Abstractions.Services;
using HyBe.SharedKernel.Utilities;
using HyBe.Domain.Entities.Signals;
using MediatR;
using HyBe.Domain.Contracts.Signals;
using HyBe.Domain.Entities.Backtests;

namespace HyBe.Application.Features.Signals.Queries;

public class UpdateSignalCommandHandler : IRequestHandler<UpdateSignalCommand,IResult>
{
    #region Fileds
    private readonly ISignalService _signalService;
    private readonly IMapper _mapper;
    #endregion

    #region Constructor
    public UpdateSignalCommandHandler(ISignalService signalService, IMapper mapper)
    {
        _signalService = signalService;
        _mapper = mapper;
    }
    #endregion

    #region Methods
    public async Task<IResult> Handle(UpdateSignalCommand query, CancellationToken cancellationToken)
    {
        var getSignal = _signalService.Get(b => b.MemberId.ToString() == query.MemberId && b.Id == query.Request.Id);
        if (getSignal == null)
        {
            return new ErrorResult("Data Not Found!");
        }
        var signalMapper = _mapper.Map<Signal>(query.Request);
        var result = _signalService.Update(signalMapper);
        if (result.Success)
            return new SuccessResult();
        return new ErrorResult();
    }
    #endregion
}

