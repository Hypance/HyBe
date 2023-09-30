using HyBe.Domain.Enums;
using HyBe.SharedKernel.Domain;
namespace HyBe.Domain.Entities.Formations;
public class FormationSignal : BaseEntity
{
    public string FormationSignalName { get; set; }
    public string SymbolName { get; set; }
    public int Period { get; set; }
    public Interval Interval { get; set; }
    public bool Result { get; set; }
    public bool IsActive { get; set; }
    public Guid MemberId { get; set; }
}