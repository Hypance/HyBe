using HyBe.Domain.Contracts.Bots;
using HyBe.SharedKernel.Utilities;
using MediatR;
using System;

namespace HyBe.Application.Features.Bot.Commands.UpdateBot
{
    public class UpdateBotCommand : IRequest<IResult>
    {
        public UpdateBotRequest Request { get; set; }

        public UpdateBotCommand(UpdateBotRequest request)
        {
            Request = request;
        }
    }
}
