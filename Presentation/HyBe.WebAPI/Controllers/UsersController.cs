using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HyBe.Application.Abstractions.Services;
using HyBe.Application.Features.AppUser.Commands.CreateUser;
using HyBe.Domain.Enums;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;

namespace HyBe.WebAPI.Controllers
{
    [Microsoft.AspNetCore.Mvc.Route("api/[Controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        readonly IMediator _mediator;
        public UsersController(IMediator mediator)
        {
            _mediator = mediator;

        }
        [HttpPost]
        public async Task<IActionResult> CreateUser(CreateUserCommandRequest createUserCommandRequest)
        {
            CreateUserCommandResponse response = await _mediator.Send(createUserCommandRequest);
            return Ok(response);
        }

    }
}