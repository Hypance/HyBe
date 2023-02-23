using HyBe.Domain.Contracts.Formations;
using HyBe.SharedKernel.Utilities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyBe.Application.Features.Formations.Queries.GetByIdFormation
{
    public class GetByIdFormationQuery : IRequest<IResult>
    {
        public GetByIdFormationRequest Request { get; set; }

        public GetByIdFormationQuery(GetByIdFormationRequest request)
        {
            Request = request;
        }
    }
}
