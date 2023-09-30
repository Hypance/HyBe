
using HyBe.SharedKernel.Domain;

namespace HyBe.Domain.Entities.Symbols;
public class Symbol : BaseEntity
{
    public string Name { get; set; }
    public decimal MinQuantity { get; set; }
    public decimal MaxQuantity { get; set; }
    public bool IsActive { get; set; }
    public Guid MemberId { get; set; }
}