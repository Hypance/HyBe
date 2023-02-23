using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyBe.Domain.Contracts.IndicatorSignals;

public class GetByIdIndicatorSignalRequest
{
    public Guid Id { get; set; }
}
