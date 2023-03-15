using HyBe.Application.Abstractions.Services;
using HyBe.Application.DTOs.User;
using HyBe.Domain.Entities.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HyBe.Persistence.Services
{
	public class UserService : IUserService
	{
		public Task AssignRoleToUserAsnyc(string userId, string[] roles)
		{
			throw new NotImplementedException();
		}

		public Task<CreateUserResponse> CreateAsync(CreateUser model)
		{
			throw new NotImplementedException();
		}

		public Task<List<ListUser>> GetAllUsersAsync(int page, int size)
		{
			throw new NotImplementedException();
		}

		public Task<string[]> GetRolesToUserAsync(string userIdOrName)
		{
			throw new NotImplementedException();
		}

		public Task<bool> HasRolePermissionToEndpointAsync(string name, string code)
		{
			throw new NotImplementedException();
		}

		public Task UpdatePasswordAsync(string userId, string resetToken, string newPassword)
		{
			throw new NotImplementedException();
		}

		public Task UpdateRefreshTokenAsync(string refreshToken, AppUser user, DateTime accessTokenDate, int addOnAccessTokenDate)
		{
			throw new NotImplementedException();
		}
	}
}