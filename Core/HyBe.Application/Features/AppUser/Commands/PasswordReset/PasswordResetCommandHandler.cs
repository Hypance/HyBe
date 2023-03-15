using HyBe.Application.Abstractions.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HyBe.Application.Features.AppUser.Commands.PasswordReset
{
    public class PasswordResetCommandHandler: IRequestHandler<PasswordResetCommandRequest, PasswordResetCommandResponse>
    {
         readonly IAuthService _authService;

        public PasswordResetCommandHandler(IAuthService authService)
        {
            _authService = authService;
        }

        public async Task<PasswordResetCommandResponse> Handle(PasswordResetCommandRequest request, CancellationToken cancellationToken)
        {
            await _authService.PasswordResetAsync(request.Email);
            return new();
        }
    }
}