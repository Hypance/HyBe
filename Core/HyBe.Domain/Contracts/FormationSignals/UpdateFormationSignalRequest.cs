﻿using HyBe.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyBe.Domain.Contracts.FormationSignals
{
    public class UpdateFormationSignalRequest
    {
        public string FormationSignalName { get; set; }
        public string SymbolName { get; set; }
        public int Period { get; set; }
        public Interval Interval { get; set; }
        public bool Result { get; set; }
        public bool IsActive { get; set; }
        public Guid Id { get; set; }
    }
}
