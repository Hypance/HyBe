using HyBe.Domain.Entities.Signals;
using HyBe.SharedKernel.Domain;
namespace HyBe.Domain.Entities.Strategies;

public class Strategy : BaseEntity
{
    public Guid MemberId { get; private set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public ICollection<Signal> Signals { get; set; }
}