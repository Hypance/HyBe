using System;
using HyBe.Domain.Contracts.Signals;
using HyBe.SharedKernel.Utilities;
using MediatR;

namespace HyBe.Application.Features.Signals.Queries;

public class DeleteSignalCommand : IRequest<IResult>
{
    public DeleteSignalRequest Request { get; set; }
    public string MemberId { get; set; }

    public DeleteSignalCommand(DeleteSignalRequest request)
    {
        Request = request;
    }
}

