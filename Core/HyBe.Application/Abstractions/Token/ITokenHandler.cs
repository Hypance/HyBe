using HyBe.Domain.Entities.Identity;

namespace HyBe.Application.Abstractions.Token
{
    public interface ITokenHandler
    {
        DTOs.Token CreateAccessToken(AppUser appUser);
        string CreateRefreshToken();
    }
}