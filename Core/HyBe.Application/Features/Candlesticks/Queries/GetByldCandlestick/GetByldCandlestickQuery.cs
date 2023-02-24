using System;
using HyBe.Domain.Contracts.Candlesticks;
using HyBe.SharedKernel.Utilities;
using MediatR;

namespace HyBe.Application.Features.Candlesticks.Queries;

public class GetByIdCandlestickQuery : IRequest<IResult>
{
    public GetByIdCandlestickRequest Request { get; set; }

    public GetByIdCandlestickQuery(GetByIdCandlestickRequest request)
    {
        Request = request;
    }
}

