using System;
using HyBe.Domain.Contracts.Candlesticks;
using HyBe.SharedKernel.Utilities;
using MediatR;

namespace HyBe.Application.Features.Candlesticks.Queries;

public class GetListCandlestickQuery : IRequest<IResult>
{
    public GetListCandlestickRequest Request { get; set; }

    public GetListCandlestickQuery(GetListCandlestickRequest request)
    {
        Request = request;
    }
}

