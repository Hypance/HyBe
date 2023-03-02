using MediatR;

namespace HyBe.Application.Features.AppUser.Commands.VerifyResetToken
{
    public class VerifyResetTokenCommandRequest: IRequest<VerifyResetTokenCommandResponse>
    {
        public string ResetToken { get; set; }
        public string UserId { get; set; }
    }
}