using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HyBe.Application.DTOs;

namespace HyBe.Application.Features.AppUser.Commands.RefreshTokenLogin
{
    public class RefreshTokenLoginCommandResponse
    {
        public Token Token { get; set; }
    }
}
