using HyBe.Domain.Contracts.Bots;
using HyBe.SharedKernel.Utilities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyBe.Application.Features.Bots.Queries.GetListBot
{
    public class GetListBotQuery : IRequest<IResult>
    {
        public GetListBotRequest Request { get; set; }

        public GetListBotQuery(GetListBotRequest request)
        {
            Request = request;
        }
    }
}
