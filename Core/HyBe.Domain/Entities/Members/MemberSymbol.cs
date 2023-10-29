using HyBe.SharedKernel.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyBe.Domain.Entities.Members
{
    public class MemberSymbol : BaseEntity
    {
        public Guid MemberId { get; set; }
        public Guid SymbolId { get; set; } 
    }
}
