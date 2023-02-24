using HyBe.Application.Abstractions.Services.Authentications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HyBe.Application.Abstractions.Services
{
    public interface IAuthService : IInternalAuthentication
    {
        Task PasswordResetAsync(string email);
        Task<bool> VerifyResetTokenAsync(string resetToken, string userId);
    }
}