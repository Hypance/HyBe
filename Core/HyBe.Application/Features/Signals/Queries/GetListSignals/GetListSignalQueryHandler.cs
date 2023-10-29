using System;
using AutoMapper;
using HyBe.Application.Abstractions.Services;
using HyBe.SharedKernel.Utilities;
using HyBe.Domain.Entities.Signals;
using MediatR;
using HyBe.Domain.Contracts.Signals;
using HyBe.Domain.Contracts.IndicatorSignals;

namespace HyBe.Application.Features.Signals.Queries;

public class GetListSignalQueryHandler : IRequestHandler<GetListSignalQuery,IResult>
{
    #region Fileds
    private readonly ISignalService _signalService;
    private readonly IMapper _mapper;
    #endregion

    #region Constructor
    public GetListSignalQueryHandler(ISignalService signalService, IMapper mapper)
    {
        _signalService = signalService;
        _mapper = mapper;
    }
    #endregion

    #region Methods
    public async Task<IResult> Handle(GetListSignalQuery query, CancellationToken cancellationToken)
    {

        var result = _signalService.GetAll(b => b.MemberId.ToString() == query.Request.MemberId);
        if (result.Success)
        {
            var signalMapper = _mapper.Map<List<GetListSignalResponse>>(result.Data);
            return new SuccessDataResult<List<GetListSignalResponse>>(signalMapper);
        }
        return new ErrorDataResult<List<GetListSignalResponse>>(result.Message);
    }
    #endregion
}

