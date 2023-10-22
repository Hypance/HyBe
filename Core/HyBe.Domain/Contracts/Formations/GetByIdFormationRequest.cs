using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyBe.Domain.Contracts.Formations
{
    public class GetByIdFormationRequest
    {
        public Guid Id { get; set; }
        public string MemberId { get; set; }
    }
}
