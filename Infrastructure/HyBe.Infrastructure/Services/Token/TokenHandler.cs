using HyBe.Application.Abstractions.Token;
using HyBe.Domain.Entities.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Telegram.BotAPI.AvailableTypes;


namespace HyBe.Infrastructure.Services.Token
{
	public class TokenHandler : ITokenHandler
	{
		public Application.DTOs.Token CreateAccessToken(int second, AppUser appUser)
		{
			throw new NotImplementedException();
		}

		public string CreateRefreshToken()
		{
			throw new NotImplementedException();
		}
	}
}