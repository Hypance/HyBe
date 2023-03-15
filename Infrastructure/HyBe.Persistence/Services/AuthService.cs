using HyBe.Application.Abstractions.Services;
using HyBe.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HyBe.Persistence.Services
{
	public class AuthService : IAuthService
	{
		public Task<Token> LoginAsync(string usernameOrEmail, string password, int accessTokenLifeTime)
		{
			throw new NotImplementedException();
		}

		public Task PasswordResetAsnyc(string email)
		{
			throw new NotImplementedException();
		}

		public Task PasswordResetAsync(string email)
		{
			throw new NotImplementedException();
		}

		public Task<Token> RefreshTokenLoginAsync(string refreshToken)
		{
			throw new NotImplementedException();
		}

		public Task<bool> VerifyResetTokenAsync(string resetToken, string userId)
		{
			throw new NotImplementedException();
		}
	}
}