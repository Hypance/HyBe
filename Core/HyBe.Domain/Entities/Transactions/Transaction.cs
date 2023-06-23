using HyBe.Domain.Enums;
using HyBe.SharedKernel.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace HyBe.Domain.Entities.Transactions
{
    public class Transaction : BaseEntity
    {
        public long TranId { get; set; }
        public string Asset { get; set; }
        public decimal Amount { get; set; }
        public decimal Size { get; set; }
        public DateTimeOffset? StartTime { get; set; }
        public DateTimeOffset? EndTime { get; set; }
        public Side Side { get; set; }
        public decimal EntryPrice { get; set; }
        public decimal? ExitPrice { get; set; }
        public bool IsDeleted { get; set; } = false;
        private decimal profit;
        public decimal Profit { get { return profit; } set 
            {
                if (ExitPrice.HasValue)
                    profit = Side == Side.LONG
                        ? ((decimal)ExitPrice - EntryPrice) * (Amount * Size)
                        : (EntryPrice - (decimal)ExitPrice) * (Amount * Size);
                profit = 0;
            } 
        }
    }
}