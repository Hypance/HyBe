using System;
using HyBe.Domain.Contracts.IndicatorSignals;
using HyBe.SharedKernel.Utilities;
using MediatR;

namespace HyBe.Application.Features.IndicatorSignals.Commands.DeleteIndicatorSignal;
public class DeleteIndicatorSignalCommand : IRequest<IResult>
{
    public DeleteIndicatorSignalRequest Request { get; set; }

    public DeleteIndicatorSignalCommand(DeleteIndicatorSignalRequest request)
    {
        Request = request;
    }
}