using System;
using AutoMapper;
using HyBe.Application.Abstractions.Services;
using HyBe.SharedKernel.Utilities;
using HyBe.Domain.Entities.Signals;
using MediatR;
using HyBe.Domain.Contracts.Signals;

namespace HyBe.Application.Features.Signals.Queries;

public class DeleteSignalCommandHandler : IRequestHandler<DeleteSignalCommand,IResult>
{
    #region Fileds
    private readonly ISignalService _signalService;
    private readonly IMapper _mapper;
    #endregion

    #region Constructor
    public DeleteSignalCommandHandler(ISignalService signalService, IMapper mapper)
    {
        _signalService = signalService;
        _mapper = mapper;
    }
    #endregion

    #region Methods
    public async Task<IResult> Handle(DeleteSignalCommand query, CancellationToken cancellationToken)
    {
        var result = _signalService.Delete(query.Request.Id);
        if (result.Success)
            return new SuccessResult();
        return new ErrorResult();
    }
    #endregion
}

