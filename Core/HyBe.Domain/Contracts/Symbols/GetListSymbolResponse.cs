using System;
using HyBe.Domain.Enums;

namespace HyBe.Domain.Contracts.Symbols;

public class GetListSymbolResponse
{
    public string Name { get; set; }
    public decimal MinQuantity { get; set; }
    public decimal MaxQuantity { get; set; }
    public bool IsActive { get; set; }
}

