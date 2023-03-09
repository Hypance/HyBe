using System;
using HyBe.Domain.Contracts.Strategies;
using HyBe.SharedKernel.Utilities;
using MediatR;

namespace HyBe.Application.Features.Strategies.Queries;

public class DeleteStrategyCommand : IRequest<IResult>
{
    public DeleteStrategyRequest Request { get; set; }

    public DeleteStrategyCommand(DeleteStrategyRequest request)
    {
        Request = request;
    }
}

