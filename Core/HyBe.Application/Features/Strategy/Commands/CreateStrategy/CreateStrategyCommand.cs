using System;
using HyBe.Domain.Contracts.Strategies;
using HyBe.SharedKernel.Utilities;
using MediatR;

namespace HyBe.Application.Features.Strategies.Queries;

public class CreateStrategyCommand : IRequest<IResult>
{
    public CreateStrategyRequest Request { get; set; }

    public CreateStrategyCommand(CreateStrategyRequest request)
    {
        Request = request;
    }
}

