using HyBe.Domain.Contracts.FormationSignals;
using HyBe.SharedKernel.Utilities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyBe.Application.Features.FormationSignals.Queries.GetByIdFormationSignal
{
    public class GetByIdFormationSignalQuery : IRequest<IResult>
    {
        public GetByIdFormationSignalRequest Request { get; set; }

        public GetByIdFormationSignalQuery(GetByIdFormationSignalRequest request)
        {
            Request = request;
        }
    }
}
