using System;
using AutoMapper;
using HyBe.Application.Abstractions.Services;
using HyBe.SharedKernel.Utilities;
using HyBe.Domain.Entities.Symbols;
using MediatR;
using HyBe.Domain.Contracts.Candlesticks;

namespace HyBe.Application.Features.Candlesticks.Queries;

public class DeleteCandlestickCommandHandler : IRequestHandler<DeleteCandlestickCommand, IResult>
{
    #region Fileds
    private readonly ICandlestickServices _candlestickService;
    private readonly IMapper _mapper;
    #endregion

    #region Constructor
    public DeleteCandlestickCommandHandler(ICandlestickServices candlestickService, IMapper mapper)
    {
        _candlestickService = candlestickService;
        _mapper = mapper;
    }
    #endregion

    #region Methods
    public async Task<IResult> Handle(DeleteCandlestickCommand query, CancellationToken cancellationToken)
    {
        var result = _candlestickService.Delete(query.Request.Id);
        if (result.Success)
            return new SuccessResult();
        return new ErrorResult();
    }
    #endregion
}

