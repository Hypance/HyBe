using HyBe.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyBe.Domain.Contracts.Formations
{
    public class GetByIdFormationResponse
    {
        public string Name { get; set; }

        public bool IsActive { get; set; }

        public int DefaultPeriod { get; set; }
    }
}
