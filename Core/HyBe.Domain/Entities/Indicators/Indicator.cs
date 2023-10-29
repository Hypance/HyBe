using HyBe.SharedKernel.Domain;

namespace HyBe.Domain.Entities.Indicators;
public class Indicator : BaseEntity
{
    public string Name { get; set; }
    public int DefaultPeriod { get; set; }
    public bool IsActive { get; set; }
    public Guid MemberId { get; set; }
}