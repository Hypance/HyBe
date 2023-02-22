using System;
using HyBe.Domain.Contracts.Indicators;
using HyBe.SharedKernel.Utilities;
using MediatR;

namespace HyBe.Application.Features.Indicators.Queries;

public class DeleteIndicatorCommand : IRequest<IResult>
{
    public DeleteIndicatorRequest Request { get; set; }

    public DeleteIndicatorCommand(DeleteIndicatorRequest request)
    {
        Request = request;
    }
}