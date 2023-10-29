using AutoMapper;
using HyBe.Application.Features.Indicators.Commands;
using HyBe.Application.Features.Indicators.Queries;
using HyBe.Domain.Contracts.Indicators;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
namespace HyBe.WebAPI.Controllers.v1
{
    [Route("api/v1.0/[controller]/[action]"), Authorize]
    [ApiController]
    public class IndicatorController : ControllerBase
    {
        #region Fields
        private readonly IMapper _mapper;
        private readonly ISender _mediatr;
        #endregion
        #region Constructor
        public IndicatorController(IMapper mapper, ISender mediatr)
        {
            _mapper = mapper;
            _mediatr = mediatr;
        }
        #endregion
        #region Methods
        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            try
            {
                System.Security.Claims.ClaimsPrincipal currentUser = this.User;
                var claims = currentUser.Claims.ToArray();
                var request = new GetListIndicatorRequest { MemberId = claims[3].Value };
                var query = _mapper.Map<GetListIndicatorQuery>(request);
                var result = await _mediatr.Send(query);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] GetByIdIndicatorRequest request)
        {
            try
            {
                var query = _mapper.Map<GetByIdIndicatorQuery>(request);
                var result = await _mediatr.Send(query);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateIndicatorRequest request)
        {
            try
            {
                System.Security.Claims.ClaimsPrincipal currentUser = this.User;
                var claims = currentUser.Claims.ToArray();
                var query = _mapper.Map<CreateIndicatorCommand>(request);
                query.Request.MemberId = claims[3].Value;
                var result = await _mediatr.Send(query);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateIndicatorRequest request)
        {
            try
            {
                System.Security.Claims.ClaimsPrincipal currentUser = this.User;
                var claims = currentUser.Claims.ToArray();
                var query = _mapper.Map<UpdateIndicatorCommand>(request);
                query.MemberId = claims[3].Value;
                var result = await _mediatr.Send(query);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] DeleteIndicatorRequest request)
        {
            try
            {
                System.Security.Claims.ClaimsPrincipal currentUser = this.User;
                var claims = currentUser.Claims.ToArray();
                var query = _mapper.Map<DeleteIndicatorCommand>(request);
                query.MemberId = claims[3].Value;
                var result = await _mediatr.Send(query);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        #endregion
    }
}