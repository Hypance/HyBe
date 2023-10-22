using System;
using HyBe.Domain.Contracts.Strategies;
using HyBe.SharedKernel.Utilities;
using MediatR;

namespace HyBe.Application.Features.Strategies.Queries;

public class UpdateStrategyCommand : IRequest<IResult>
{
    public UpdateStrategyRequest Request { get; set; }
    public string MemberId { get; set; }

    public UpdateStrategyCommand(UpdateStrategyRequest request)
    {
        Request = request;
    }
}

