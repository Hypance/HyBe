using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HyBe.Application.Abstractions.Services.Authentications;

namespace HyBe.Application.Abstractions.Services
{
    public interface IAuthService : IInternalAuthentication
    {
        Task PasswordResetAsnyc(string email);
        Task<bool> VerifyResetTokenAsync(string resetToken, string userId);
    }
}
