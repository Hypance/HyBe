using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyBe.Domain.Contracts.Transactions
{
    public class GetByIdTransactionRequest
    {
        public Guid Id { get; set; }
        public string MemberId { get; set; }
    }
}
