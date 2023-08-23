using HyBe.Domain.Enums;
using HyBe.SharedKernel.Domain;

namespace HyBe.Domain.Entities.Signals;
public class Signal : BaseEntity
{
    public Guid MemberId { get; private set; }
    public string Name { get; set; }
    public int Period { get; set; }
    public int IndicatorId { get; set; }
    public SignalResult SignalResult { get; set; }
    public Interval Interval { get; set; }
    public TrendStrategy TrendStrategy { get; set; }
}