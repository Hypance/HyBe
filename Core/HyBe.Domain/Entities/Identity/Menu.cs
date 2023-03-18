using HyBe.SharedKernel.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyBe.Domain.Entities.Identity
{
	public class Menu : BaseEntity
	{
		public string Name { get; set; }
		public ICollection<Endpoint> Endpoints { get; set; }
	}
}
