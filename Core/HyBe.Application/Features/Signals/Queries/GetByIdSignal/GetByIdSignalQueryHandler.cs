using System;
using AutoMapper;
using HyBe.Application.Abstractions.Services;
using HyBe.SharedKernel.Utilities;
using HyBe.Domain.Entities.Signals;
using MediatR;
using HyBe.Domain.Contracts.Signals;

namespace HyBe.Application.Features.Signals.Queries;

public class GetByIdSignalQueryHandler : IRequestHandler<GetByIdSignalQuery,IResult>
{
    #region Fileds
    private readonly ISignalService _signalService;
    private readonly IMapper _mapper;
    #endregion

    #region Constructor
    public GetByIdSignalQueryHandler(ISignalService signalService, IMapper mapper)
    {
        _signalService = signalService;
        _mapper = mapper;
    }
    #endregion

    #region Methods
    public async Task<IResult> Handle(GetByIdSignalQuery query, CancellationToken cancellationToken)
    {

        var result = _signalService.Get(b=>b.Id == query.Request.Id);
        if (result.Success)
        {
            var signalMapper = _mapper.Map<GetByIdSignalResponse>(result.Data);
            return new SuccessDataResult<GetByIdSignalResponse>(signalMapper);
        }
        return new ErrorDataResult<GetByIdSignalResponse>();
    }
    #endregion
}

