using HyBe.SharedKernel.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyBe.Domain.Entities.Wallets;

public class Wallet : BaseEntity
{
    public Guid MemberId { get; private set; }
    public decimal Balance { get; set; }
}
