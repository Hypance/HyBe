using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace HyBe.Application.Features.AppUser.Commands.PasswordReset
{
    public class PasswordResetCommandRequest: IRequest<PasswordResetCommandResponse>
    {
        public string Email { get; set; }
    }
}