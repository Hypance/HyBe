using AutoMapper;
using HyBe.Application.Abstractions.Services;
using HyBe.Domain.Contracts.Indicators;
using HyBe.Domain.Contracts.IndicatorSignals;
using HyBe.SharedKernel.Utilities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyBe.Application.Features.IndicatorSignals.Queries.GetListIndicatorSignal;
public class GetListIndicatorSignalQueryHandler : IRequestHandler<GetListIndicatorSignalQuery, IResult>
{
    #region Fileds
    private readonly IIndicatorSignalService _indicatorSignalService;
    private readonly IMapper _mapper;
    #endregion

    #region Constructor
    public GetListIndicatorSignalQueryHandler(IIndicatorSignalService indicatorSignalService, IMapper mapper)
    {
        _indicatorSignalService = indicatorSignalService;
        _mapper = mapper;
    }
    #endregion

    #region Methods
    public async Task<IResult> Handle(GetListIndicatorSignalQuery query, CancellationToken cancellationToken)
    {

        var result = _indicatorSignalService.GetAll(b => b.MemberId.ToString() == query.Request.MemberId);
        if (result.Success)
        {
            var indicatorSignalMapper = _mapper.Map<List<GetListIndicatorSignalResponse>>(result.Data);
            return new SuccessDataResult<List<GetListIndicatorSignalResponse>>(indicatorSignalMapper);
        }
        return new ErrorDataResult<List<GetListIndicatorSignalResponse>>(result.Message);
    }
    #endregion
}
