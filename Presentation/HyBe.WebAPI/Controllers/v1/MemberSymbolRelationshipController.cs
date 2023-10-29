using AutoMapper;
using HyBe.Application.Features.MemberSymbolRelations.Commands.CreateMemberSymbol;
using HyBe.Application.Features.MemberSymbolRelations.Commands.DeleteMemberSymbol;
using HyBe.Application.Features.MemberSymbolRelations.Queries.GetListMemberSymbol;
using HyBe.Domain.Contracts.MemberSymbols;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Update.Internal;

namespace HyBe.WebAPI.Controllers.v1
{
    [Route("api/v1.0/[controller]/[action]"), Authorize]
    [ApiController]
    public class MemberSymbolRelationshipController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IMediator _mediatr;
        public MemberSymbolRelationshipController(IMapper mapper, IMediator mediatr)
        {
            _mapper = mapper;
            _mediatr = mediatr;
        }
        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            try
            {
                System.Security.Claims.ClaimsPrincipal currentUser = this.User;
                var claims = currentUser.Claims.ToArray();
                var request = new GetListMemberSymbolRequest { MemberId = claims[3].Value };
                var query = _mapper.Map<GetListMemberSymbolQuery>(request);
                var result = await _mediatr.Send(query);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateMemberSymbolRequest request)
        {
            try
            {
                System.Security.Claims.ClaimsPrincipal currentUser = this.User;
                var claims = currentUser.Claims.ToArray();
                var query = _mapper.Map<CreateMemberSymbolCommand>(request);
                query.Request.MemberId = claims[3].Value;
                var result = await _mediatr.Send(query);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] DeleteMemberSymbolRequest request)
        {
            try
            {
                System.Security.Claims.ClaimsPrincipal currentUser = this.User;
                var claims = currentUser.Claims.ToArray();
                var query = _mapper.Map<DeleteMemberSymbolCommand>(request);
                query.MemberId = claims[3].Value;
                var result = await _mediatr.Send(query);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
