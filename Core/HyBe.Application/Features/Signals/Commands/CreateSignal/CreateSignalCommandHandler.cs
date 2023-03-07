using System;
using AutoMapper;
using HyBe.Application.Abstractions.Services;
using HyBe.SharedKernel.Utilities;
using HyBe.Domain.Entities.Signals;
using MediatR;
using HyBe.Domain.Contracts.Signals;

namespace HyBe.Application.Features.Signals.Queries;

public class CreateSignalCommandHandler : IRequestHandler<CreateSignalCommand,IResult>
{
    #region Fileds
    private readonly ISignalService _signalService;
    private readonly IMapper _mapper;
    #endregion

    #region Constructor
    public CreateSignalCommandHandler(ISignalService signalService, IMapper mapper)
    {
        _signalService = signalService;
        _mapper = mapper;
    }
    #endregion

    #region Methods
    public async Task<IResult> Handle(CreateSignalCommand query, CancellationToken cancellationToken)
    {
        var signalMapper = _mapper.Map<Signal>(query.Request);
        var result = _signalService.Add(signalMapper);
        if (result.Success)
            return new SuccessResult();
        return new ErrorResult();
    }
    #endregion
}

