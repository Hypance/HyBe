using HyBe.Domain.Contracts.FormationSignals;
using HyBe.SharedKernel.Utilities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyBe.Application.Features.FormationSignals.Commands.UpdateFormationSignal;
    public class UpdateFormationSignalCommand : IRequest<IResult>
    {
        public UpdateFormationSignalRequest Request { get; set; }
    public string MemberId { get; internal set; }

    public UpdateFormationSignalCommand(UpdateFormationSignalRequest request)
        {
        Request = request;
        }
    }