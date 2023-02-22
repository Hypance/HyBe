using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using HyBe.Application.Abstractions.Services;
using HyBe.Application.Features.IndicatorSignals.Queries;
using HyBe.Application.Features.IndicatorSignals.Queries.GetByIdIndicatorSignal;
using HyBe.Domain.Contracts.IndicatorSignals;
using HyBe.SharedKernel.Utilities;
using MediatR;

namespace HyBe.Application.Features.IndicatorSignals.Queries;
public class GetByIdIndicatorSignalQueryHandler : IRequestHandler<GetByIdIndicatorSignalQuery, IResult>
{
    private readonly IIndicatorSignalService _indicatorSignalService;
    private readonly IMapper _mapper;

    #region Constructor
    public GetByIdIndicatorSignalQueryHandler(IIndicatorSignalService indicatorSignalService, IMapper mapper)
    {
        _indicatorSignalService = indicatorSignalService;
        _mapper = mapper;
    }
    #endregion

    #region Methods
    public async Task<IResult> Handle(GetByIdIndicatorSignalQuery query, CancellationToken cancellationToken)
    {

        var result = _indicatorSignalService.Get(b => b.Id == query.Request.Id);
        if (result.Success)
        {
            var indicatorSignalMapper = _mapper.Map<GetByIdIndicatorSignalResponse>(result.Data);
            return new SuccessDataResult<GetByIdIndicatorSignalResponse>(indicatorSignalMapper);
        }
        return new ErrorDataResult<GetByIdIndicatorSignalResponse>();
    }
    #endregion
}