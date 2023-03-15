using HyBe.Application.Abstractions.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HyBe.Persistence.Services
{
	public class RoleService : IRoleService
	{
		public Task<bool> CreateRole(string name)
		{
			throw new NotImplementedException();
		}

		public Task<bool> DeleteRole(string id)
		{
			throw new NotImplementedException();
		}

		public (object, int) GetAllRoles(int page, int size)
		{
			throw new NotImplementedException();
		}

		public Task<(string id, string name)> GetRoleById(string id)
		{
			throw new NotImplementedException();
		}

		public Task<bool> UpdateRole(string id, string name)
		{
			throw new NotImplementedException();
		}
	}
}