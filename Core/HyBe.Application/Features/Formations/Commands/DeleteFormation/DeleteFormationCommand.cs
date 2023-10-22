using HyBe.Domain.Contracts.Formations;
using HyBe.SharedKernel.Utilities;
using MediatR;
using System;


namespace HyBe.Application.Features.Formations.Commands.DeleteFormation
{
    public class DeleteFormationCommand : IRequest<IResult>
    {
        public DeleteFormationRequest Request { get; set; }
        public string MemberId { get; set; }

        public DeleteFormationCommand(DeleteFormationRequest request)
        {
            Request = request;
        }
    }
}
