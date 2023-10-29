using HyBe.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyBe.Domain.Contracts.Transactions
{
    public class CreateTransactionRequest
    {
        public Guid MemberId { get; set; }
        public string Asset { get; set; }
        public decimal Amount { get; set; }
        public DateTimeOffset? StartTime { get; set; }
        public Side Side { get; set; }
        public decimal EntryPrice { get; set; }
     }
}
