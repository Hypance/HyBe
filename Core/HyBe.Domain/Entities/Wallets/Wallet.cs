﻿using HyBe.SharedKernel.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hypance.Core.Domain.Wallets
{
    public class Wallet : BaseEntity
    {
        public decimal Balance { get; set; }
    }
}
