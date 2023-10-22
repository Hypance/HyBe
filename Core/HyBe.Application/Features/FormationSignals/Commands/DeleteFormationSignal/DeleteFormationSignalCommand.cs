using HyBe.Domain.Contracts.FormationSignals;
using HyBe.SharedKernel.Utilities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyBe.Application.Features.FormationSignals.Commands.DeleteFormationSignal
{
    public class DeleteFormationSignalCommand : IRequest<IResult>
    {
        public DeleteFormationSignalRequest Request { get; set; }
        public string MemberId { get; set; }

        public DeleteFormationSignalCommand(DeleteFormationSignalRequest request)
        {
            Request = request;
        }
    }
}
