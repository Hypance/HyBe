using System;
using HyBe.Domain.Contracts.Enums;
using HyBe.SharedKernel.Utilities;
using MediatR;

namespace HyBe.Application.Features.Enums.Commands;

public class UpdateEnumCommand : IRequest<IResult>
{
    public UpdateEnumRequest Request { get; set; }

    public UpdateEnumCommand(UpdateEnumRequest request)
    {
        Request = request;
    }
}