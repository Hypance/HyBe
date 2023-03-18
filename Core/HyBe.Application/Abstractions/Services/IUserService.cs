using HyBe.Application.DTOs.User;

namespace HyBe.Application.Abstractions.Services
{
   public interface IUserService
   {
        Task<CreateUserResponse> CreateAsync(CreateUser model);
   }
}