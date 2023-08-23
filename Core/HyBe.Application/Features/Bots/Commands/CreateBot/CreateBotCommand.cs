using System;
using HyBe.Domain.Contracts.Bots;
using HyBe.SharedKernel.Utilities;
using MediatR;

namespace HyBe.Application.Features.Bots.Commands.CreateBot;

public class CreateBotCommand : IRequest<IResult>
{
    public CreateBotRequest Request { get; set; }

    public CreateBotCommand(CreateBotRequest request)
    {
        Request = request;
    }
}
