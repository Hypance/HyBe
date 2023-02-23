using System;
using HyBe.Domain.Contracts.IndicatorSignals;
using HyBe.SharedKernel.Utilities;
using MediatR;

namespace HyBe.Application.Features.IndicatorSignals.Commands.CreateIndicatorSignal;

public class CreateIndicatorSignalCommand : IRequest<IResult>
{
    public CreateIndicatorSignalRequest Request { get; set; }

    public CreateIndicatorSignalCommand(CreateIndicatorSignalRequest request)
    {
        Request = request;
    }
}