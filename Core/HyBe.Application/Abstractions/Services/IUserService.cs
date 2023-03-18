using HyBe.Application.DTOs.User;
using HyBe.Domain.Entities.Identity;

namespace HyBe.Application.Abstractions.Services
{
   public interface IUserService
   {
        Task<CreateUserResponse> CreateAsync(CreateUser model);
        Task UpdateRefreshTokenAsync(string refreshToken, AppUser user, DateTime accessTokenDate, int addOnAccessTokenDate);
    }
}