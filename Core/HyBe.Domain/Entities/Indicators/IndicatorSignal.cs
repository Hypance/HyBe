using System;
using HyBe.Domain.Enums;
using HyBe.SharedKernel.Domain;

namespace HyBe.Domain.Entities.Indicators;
public class IndicatorSignal : BaseEntity
{
    public Guid MemberId { get; set; }
    public string IndicatorName { get; set; }
    public string SymbolName { get; set; }
    public int Period { get; set; }
    public Interval Interval { get; set; }
    public int[] Signals { get; set; }
    public bool IsActive { get; set; }
}