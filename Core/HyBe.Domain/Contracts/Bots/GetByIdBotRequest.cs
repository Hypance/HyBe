using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyBe.Domain.Contracts.Bots
{
    public class GetByIdBotRequest
    {
        public string MemberId { get; set; }
        public DateTimeOffset? StartDate { get; set; }
        public Guid Id { get; set; }
    }
}
