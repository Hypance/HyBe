using HyBe.Application.Abstractions.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HyBe.Persistence.Services
{
	public class AuthorizationEndpointService : IAuthorizationEndpointService
	{
		public Task AssignRoleEndpointAsync(string[] roles, string code)
		{
			throw new NotImplementedException();
		}

		public Task<List<string>> GetRolesToEndpointAsync(string code)
		{
			throw new NotImplementedException();
		}
	}
}