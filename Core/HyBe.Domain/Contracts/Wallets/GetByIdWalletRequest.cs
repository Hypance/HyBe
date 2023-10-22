using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyBe.Domain.Contracts.Wallets
{
    public class GetByIdWalletRequest
    {
        public Guid Id { get; set; }
        public string MemberId { get; set; }
    }
}
