using HyBe.Domain.Contracts.Bots;
using HyBe.SharedKernel.Utilities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyBe.Application.Features.Bots.Queries.GetByIdBot
{
    public class GetByIdBotQuery : IRequest<IResult>
    {
        public GetByIdBotRequest Request { get; set; }

        public GetByIdBotQuery(GetByIdBotRequest request)
        {
            Request = request;
        }
    }
}
