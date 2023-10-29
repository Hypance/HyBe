using HyBe.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyBe.Domain.Contracts.Transactions
{
    public class UpdateTransactionRequest 
    {
        public Guid Id { get; set; }
        public DateTimeOffset EndTime { get; set; }
        public decimal ExitPrice { get; set; }
    }
}
