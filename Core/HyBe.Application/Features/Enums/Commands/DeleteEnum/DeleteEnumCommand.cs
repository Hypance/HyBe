using System;
using HyBe.Domain.Contracts.Enums;
using HyBe.SharedKernel.Utilities;
using MediatR;

namespace HyBe.Application.Features.Enums.Commands;

public class DeleteEnumCommand : IRequest<IResult>
{
    public DeleteEnumRequest Request { get; set; }

    public DeleteEnumCommand(DeleteEnumRequest request)
    {
        Request = request;
    }
}