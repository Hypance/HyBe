using System;
using HyBe.Domain.Contracts.Indicators;
using HyBe.SharedKernel.Utilities;
using MediatR;

namespace HyBe.Application.Features.Indicators.Commands;

public class UpdateIndicatorCommand : IRequest<IResult>
{
    public UpdateIndicatorRequest Request { get; set; }
    public string MemberId { get; internal set; }

    public UpdateIndicatorCommand(UpdateIndicatorRequest request)
    {
        Request = request;
    }
}