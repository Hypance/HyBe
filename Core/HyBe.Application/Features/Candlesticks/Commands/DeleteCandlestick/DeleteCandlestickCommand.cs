using System;
using HyBe.Domain.Contracts.Candlesticks;
using HyBe.SharedKernel.Utilities;
using MediatR;

namespace HyBe.Application.Features.Candlesticks.Queries;

public class DeleteCandlestickCommand : IRequest<IResult>
{
    public DeleteCandlestickRequest Request { get; set; }
    public string MemberId { get; set; }
    public DeleteCandlestickCommand(DeleteCandlestickRequest request)
    {
        Request = request;
    }
}

