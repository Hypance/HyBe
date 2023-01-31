using System;
using HyBe.Domain.Contracts.Backtests;
using HyBe.SharedKernel.Utilities;
using MediatR;

namespace HyBe.Application.Features.Backtests.Queries;

public class GetListBacktestQuery : IRequest<IResult>
{
    public GetListBacktestRequest Request { get; set; }

    public GetListBacktestQuery(GetListBacktestRequest request)
    {
        Request = request;
    }
}

