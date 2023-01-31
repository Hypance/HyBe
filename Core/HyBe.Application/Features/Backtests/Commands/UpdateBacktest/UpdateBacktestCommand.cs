using System;
using HyBe.Domain.Contracts.Backtests;
using HyBe.SharedKernel.Utilities;
using MediatR;

namespace HyBe.Application.Features.Backtests.Queries;

public class UpdateBacktestCommand : IRequest<IResult>
{
    public UpdateBacktestRequest Request { get; set; }

    public UpdateBacktestCommand(UpdateBacktestRequest request)
    {
        Request = request;
    }
}

