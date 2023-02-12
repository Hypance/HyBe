using HyBe.Domain.Contracts.Bots;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyBe.Application.Features.Bot.Queries.GetListBot
{
    public class GetListBotQuery
    {
        public GetListBotRequest Request { get; set; }

        public GetListBotQuery(GetListBotRequest request)
        {
            Request = request;
        }
    }
}
