﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyBe.Domain.Contracts.Symbols
{
    public class UpdateSymbolRequest
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal MinQuantity { get; set; }
        public decimal MaxQuantity { get; set; }
        public bool IsActive { get; set; }
    }
}
