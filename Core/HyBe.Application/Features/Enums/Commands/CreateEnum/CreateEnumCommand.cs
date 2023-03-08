using System;
using HyBe.Domain.Contracts.Enums;
using HyBe.SharedKernel.Utilities;
using MediatR;


namespace HyBe.Application.Features.Enums.Commands;

public class CreateEnumCommand : IRequest<IResult>
{
    public CreateEnumRequest Request { get; set; }

    public CreateEnumCommand(CreateEnumRequest request)
    {
        Request = request;
    }
}