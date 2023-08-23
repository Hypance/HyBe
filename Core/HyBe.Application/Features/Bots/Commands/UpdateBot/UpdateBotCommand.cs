using HyBe.Domain.Contracts.Bots;
using HyBe.SharedKernel.Utilities;
using MediatR;
using System;

namespace HyBe.Application.Features.Bots.Commands.UpdateBot
{
    public class UpdateBotCommand : IRequest<IResult>
    {
        public UpdateBotRequest Request { get; set; }
        public string MemberId { get; internal set; }

        public UpdateBotCommand(UpdateBotRequest request)
        {
            Request = request;
        }
    }
}
