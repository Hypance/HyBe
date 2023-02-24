using System;
using HyBe.Domain.Contracts.FormationSignals;
using HyBe.SharedKernel.Utilities;
using MediatR;

namespace HyBe.Application.Features.FormationSignals.Queries;

public class CreateFormationSignalCommand : IRequest<IResult>
{
    public CreateFormationSignalRequest Request { get; set; }

    public CreateFormationSignalCommand(CreateFormationSignalRequest request)
    {
        Request = request;
    }
}

