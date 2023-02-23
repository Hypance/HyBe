using HyBe.Domain.Contracts.Formations;
using HyBe.SharedKernel.Utilities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyBe.Application.Features.Formations.Queries.GetListFormation
{
    public class GetListFormationQuery : IRequest<IResult>
    {
        public GetListFormationRequest Request { get; set; }

        public GetListFormationQuery(GetListFormationRequest request)
        {
            Request = request;
        }
    }
}
