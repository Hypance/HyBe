using HyBe.Domain.Contracts.Bots;
using HyBe.SharedKernel.Utilities;
using MediatR;
using System;


namespace HyBe.Application.Features.Bot.Commands.DeleteBot
{
    public class DeleteBotCommand : IRequest<IResult>
    {
        public DeleteBotRequest Request { get; set; }

        public DeleteBotCommand(DeleteBotRequest request) 
        {
            Request = request;
        }
    }
}
