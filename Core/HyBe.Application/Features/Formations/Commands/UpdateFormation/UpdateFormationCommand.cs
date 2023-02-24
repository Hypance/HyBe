using HyBe.Domain.Contracts.Formations;
using HyBe.SharedKernel.Utilities;
using MediatR;
using System;

namespace HyBe.Application.Features.Formations.Commands.UpdateFormation
{
    public class UpdateFormationCommand : IRequest<IResult>
    {
        public UpdateFormationRequest Request { get; set; }

        public UpdateFormationCommand(UpdateFormationRequest request)
        {
            Request = request;
        }
    }
}
