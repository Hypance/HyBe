using HyBe.Domain.Contracts.Formations;
using HyBe.SharedKernel.Utilities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyBe.Application.Features.Formations.Commands.CreateFormation
{
    public class CreateFormationCommand : IRequest<IResult>
    {
        public CreateFormationRequest Request { get; set; }

        public CreateFormationCommand(CreateFormationRequest request)
        {
            Request = request;
        }
    }
}
