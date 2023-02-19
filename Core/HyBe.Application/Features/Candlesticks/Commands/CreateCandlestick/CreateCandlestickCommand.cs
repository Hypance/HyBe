using System;
using HyBe.Domain.Contracts.Candlesticks;
using HyBe.SharedKernel.Utilities;
using MediatR;

namespace HyBe.Application.Features.Candlesticks.Queries;

public class CreateCandlestickCommand : IRequest<IResult>
{
    public CreateCandlestickRequest Request { get; set; }

    public CreateCandlestickCommand(CreateCandlestickRequest request)
    {
        Request = request;
    }
}

