using HyBe.Application.DTOs;

namespace HyBe.Application.Features.AppUser.Commands.LoginUser
{
    public class LoginUserCommandResponse
    {
        
    }
    public class LoginUserSuccessCommandResponse : LoginUserCommandResponse
    {
        public Token Token { get; set; }
    }
    public class LoginUserErrorCommandResponse : LoginUserCommandResponse
    {
        public string Message { get; set; }
    }
}