using System;
using HyBe.Domain.Contracts.Signals;
using HyBe.SharedKernel.Utilities;
using MediatR;

namespace HyBe.Application.Features.Signals.Queries;

public class CreateSignalCommand : IRequest<IResult>
{
    public CreateSignalRequest Request { get; set; }

    public CreateSignalCommand(CreateSignalRequest request)
    {
        Request = request;
    }
}

