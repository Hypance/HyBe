using System;
using AutoMapper;
using HyBe.Application.Abstractions.Services;
using HyBe.SharedKernel.Utilities;
using HyBe.Domain.Entities.Symbols;
using MediatR;
using HyBe.Domain.Contracts.Candlesticks;

namespace HyBe.Application.Features.Candlesticks.Queries;

public class GetByIdCandlestickQueryHandler : IRequestHandler<GetByIdCandlestickQuery, IResult>
{
    #region Fileds
    private readonly ICandlestickServices _candlestickService;
    private readonly IMapper _mapper;
    #endregion

    #region Constructor
    public GetByIdCandlestickQueryHandler(ICandlestickServices candlestickService, IMapper mapper)
    {
        _candlestickService = candlestickService;
        _mapper = mapper;
    }
    #endregion

    #region Methods
    public async Task<IResult> Handle(GetByIdCandlestickQuery query, CancellationToken cancellationToken)
    {

        var result = _candlestickService.Get(b => b.Id == query.Request.Id);
        if (result.Success)
        {
            var candlestickMapper = _mapper.Map<GetByIdCandlestickResponse>(result.Data);
            return new SuccessDataResult<GetByIdCandlestickResponse>(candlestickMapper);
        }
        return new ErrorDataResult<GetByIdCandlestickResponse>();
    }
    #endregion
}

