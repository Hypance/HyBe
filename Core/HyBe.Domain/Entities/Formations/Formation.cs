using HyBe.SharedKernel.Domain;
namespace HyBe.Domain.Entities.Formations;
public class Formation : BaseEntity
{
    public string Name { get; set; }

    public bool IsActive { get; set; }

    public int DefaultPeriod { get; set; }
    public Guid MemberId { get; set; }
}