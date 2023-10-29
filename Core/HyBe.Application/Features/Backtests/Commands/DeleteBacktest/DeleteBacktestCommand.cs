using System;
using HyBe.Domain.Contracts.Backtests;
using HyBe.SharedKernel.Utilities;
using MediatR;

namespace HyBe.Application.Features.Backtests.Queries;

public class DeleteBacktestCommand : IRequest<IResult>
{
    public DeleteBacktestRequest Request { get; set; }
    public string MemberId { get; set; }
    public DeleteBacktestCommand(DeleteBacktestRequest request)
    {
        Request = request;
    }
}

