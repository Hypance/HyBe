using HyBe.Domain.Contracts.IndicatorSignal;
using HyBe.SharedKernel.Utilities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyBe.Application.Features.IndicatorSignals.Commands.UpdateIndicatorSignal;

public class UpdateIndicatorSignalCommand : IRequest<IResult>
{
    public UpdateIndicatorSignalRequest Request { get; set; }

    public UpdateIndicatorSignalCommand (UpdateIndicatorSignalRequest request)
    {
        Request = request;
    }
}