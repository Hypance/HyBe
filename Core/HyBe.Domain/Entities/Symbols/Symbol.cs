
using HyBe.SharedKernel.Domain;

namespace HyBe.Domain.Entities.Symbols;
public class Symbol : BaseEntity
{
    public string Name { get; set; }
    public decimal MinQuantity { get; set; }
    public decimal MaxQuantity { get; set; }
    public bool IsActive { get; set; }
    public decimal StepSize { get; set; }
    public decimal TickSize { get; set; }
    public decimal Precision { get; set; }
    public string Icon { get; set; }
}