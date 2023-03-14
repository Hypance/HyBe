using System;
using HyBe.Domain.Contracts.Strategies;
using HyBe.SharedKernel.Utilities;
using MediatR;

namespace HyBe.Application.Features.Strategies.Queries;

public class GetByIdStrategyQuery : IRequest<IResult>
{
    public GetByIdStrategyRequest Request { get; set; }

    public GetByIdStrategyQuery(GetByIdStrategyRequest request)
    {
        Request = request;
    }
}

