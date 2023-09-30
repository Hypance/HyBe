using System;
using HyBe.Domain.Contracts.Candlesticks;
using HyBe.SharedKernel.Utilities;
using MediatR;

namespace HyBe.Application.Features.Candlesticks.Queries;

public class UpdateCandlestickCommand : IRequest<IResult>
{
    public UpdateCandlestickRequest Request { get; set; }
    public string MemberId { get; internal set; }

    public UpdateCandlestickCommand(UpdateCandlestickRequest request)
    {
        Request = request;
    }
}

