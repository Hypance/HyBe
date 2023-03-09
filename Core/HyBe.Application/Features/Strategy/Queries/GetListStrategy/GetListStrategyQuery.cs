using System;
using HyBe.Domain.Contracts.Strategies;
using HyBe.SharedKernel.Utilities;
using MediatR;

namespace HyBe.Application.Features.Strategies.Queries;

public class GetListStrategyQuery : IRequest<IResult>
{
    public GetListStrategyRequest Request { get; set; }

    public GetListStrategyQuery(GetListStrategyRequest request)
    {
        Request = request;
    }
}

