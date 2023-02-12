using HyBe.Domain.Contracts.Bots;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyBe.Application.Features.Bot.Queries.GetByIdBot
{
    public class GetByIdBotQuery
    {
        public GetByIdBotRequest Request { get; set; }

        public GetByIdBotQuery(GetByIdBotRequest request)
        {
            Request = request;
        }
    }
}
