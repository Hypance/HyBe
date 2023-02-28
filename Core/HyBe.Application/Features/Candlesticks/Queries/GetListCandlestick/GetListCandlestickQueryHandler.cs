using System;
using AutoMapper;
using HyBe.Application.Abstractions.Services;
using HyBe.SharedKernel.Utilities;
using HyBe.Domain.Entities.Symbols;
using MediatR;
using HyBe.Domain.Contracts.Candlesticks;

namespace HyBe.Application.Features.Candlesticks.Queries;

public class GetListCandlestickQueryHandler : IRequestHandler<GetListCandlestickQuery, IResult>
{
    #region Fileds
    private readonly ICandlestickServices _candlestickService;
    private readonly IMapper _mapper;
    #endregion

    #region Constructor
    public GetListCandlestickQueryHandler(ICandlestickServices candlestickService, IMapper mapper)
    {
        _candlestickService = candlestickService;
        _mapper = mapper;
    }
    #endregion

    #region Methods
    public async Task<IResult> Handle(GetListCandlestickQuery query, CancellationToken cancellationToken)
    {

        var result = _candlestickService.GetAll();
        if (result.Success)
        {
            var candlestickMapper = _mapper.Map<List<GetListCandlestickResponse>>(result.Data);
            return new SuccessDataResult<List<GetListCandlestickResponse>>(candlestickMapper);
        }
        return new ErrorDataResult<List<GetListCandlestickResponse>>();
    }
    #endregion
}

