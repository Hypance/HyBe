using System;
using HyBe.Domain.Contracts.Backtests;
using HyBe.SharedKernel.Utilities;
using MediatR;

namespace HyBe.Application.Features.Backtests.Queries;

public class GetByIdBacktestQuery : IRequest<IResult>
{
    public GetByIdBacktestRequest Request { get; set; }

    public GetByIdBacktestQuery(GetByIdBacktestRequest request)
    {
        Request = request;
    }
}

