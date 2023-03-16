using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HyBe.Domain.Entities.Identity
{
    public class AppUser : IdentityUser<string>
	{
		public string NameSurname { get; set; }
		public string? RefreshToken { get; set; }
		public DateTime? RefreshTokenEndDate { get; set; }
	}
}