using System;
using HyBe.Domain.Contracts.Signals;
using HyBe.SharedKernel.Utilities;
using MediatR;

namespace HyBe.Application.Features.Signals.Queries;

public class UpdateSignalCommand : IRequest<IResult>
{
    public UpdateSignalRequest Request { get; set; }

    public UpdateSignalCommand(UpdateSignalRequest request)
    {
        Request = request;
    }
}

