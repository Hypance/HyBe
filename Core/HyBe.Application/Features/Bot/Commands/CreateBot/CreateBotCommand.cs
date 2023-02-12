using HyBe.SharedKernel.Utilities;
using MediatR;
using System;
using HyBe.Domain.Contracts.Bots;


namespace HyBe.Application.Features.Bot.Commands.CreateBot
{
    public class CreateBotCommand : IRequest<IResult>
    {
        public CreateBotRequest Request { get; set; }

        public CreateBotCommand(CreateBotRequest request) 
        {
            Request = request;
        }
    }
}
