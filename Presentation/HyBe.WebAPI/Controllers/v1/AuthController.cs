using HyBe.Application.Abstractions.Services;
using HyBe.Domain.Contracts.Auth;
using HyBe.Domain.Entities.Members;
using HyBe.Persistence.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HyBe.WebAPI.Controllers.v1
{
    [Route("api/[controller]"), Authorize]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly UserManager<Member> _memberManager;
        private readonly TokenService _tokenService;
        private readonly IMemberService _memberService;

        public AuthController(UserManager<Member> memberManager, TokenService tokenService, IMemberService memberService)
        {
            _memberManager = memberManager;
            _tokenService = tokenService;
            _memberService = memberService;
        }

        [HttpPost]
        [Route("login")]
        public async Task<ActionResult<AuthResponse>> Authenticate([FromBody] AuthRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var managedUser = await _memberManager.FindByEmailAsync(request.Email);
            if (managedUser == null)
            {
                return BadRequest("Bad credentials");
            }
            var isPasswordValid = await _memberManager.CheckPasswordAsync(managedUser, request.Password);
            if (!isPasswordValid)
            {
                return BadRequest("Bad credentials");
            }
            var userInDb = _memberService.Get(u => u.Email == request.Email);
            if (userInDb is null)
                return Unauthorized();
            var accessToken = _tokenService.CreateToken(userInDb.Data);
            return Ok(new AuthResponse
            {
                Username = userInDb.Data.UserName,
                Email = userInDb.Data.Email,
                Token = accessToken,
            });
        }

        [HttpPost]
        [Route("register")]
        
        public async Task<IActionResult> Register(RegistrationRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var result = await _memberManager.CreateAsync(
                new Member { UserName = request.Username, Email = request.Email },
                request.Password
            );
            if (result.Succeeded)
            {
                request.Password = "";
                return CreatedAtAction(nameof(Register), new { email = request.Email }, request);
            }
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(error.Code, error.Description);
            }
            return BadRequest(ModelState);
        }
    }
}
