using HyBe.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyBe.Domain.Contracts.IndicatorSignals;

public class CreateIndicatorSignalRequest
{
    public string IndicatorName { get; set; }
    public string SymbolName { get; set; }
    public int Period { get; set; }
    public Interval Interval { get; set; }
    public int[] Signals { get; set; }
    public bool IsActive { get; set; }
}
