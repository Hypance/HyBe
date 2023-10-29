using System;
using HyBe.Domain.Contracts.Backtests;
using HyBe.SharedKernel.Utilities;
using MediatR;

namespace HyBe.Application.Features.Backtests.Queries;

public class CreateBacktestCommand : IRequest<IResult>
{
    public CreateBacktestRequest Request { get; set; }

    public CreateBacktestCommand(CreateBacktestRequest request)
    {
        Request = request;
    }
}