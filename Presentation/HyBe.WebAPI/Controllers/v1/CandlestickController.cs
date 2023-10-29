using AutoMapper;
using HyBe.Application.Features.Candlesticks.Queries;
using HyBe.Domain.Contracts.Candlesticks;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HyBe.WebAPI.Controllers.v1
{
    [Route("api/v1.0/[controller]/[action]"), Authorize]
    [ApiController]
    public class CandlestickController : ControllerBase
    {
        #region Fileds
        private readonly IMapper _mapper;
        private readonly ISender _mediatr;
        #endregion

        #region Constructor
        public CandlestickController(IMapper mapper, ISender mediatr)
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
                var request = new GetListCandlestickRequest { MemberId = claims[3].Value };
                var query = _mapper.Map<GetListCandlestickQuery>(request);
                var result = await _mediatr.Send(query);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] GetByIdCandlestickRequest request)
        {
            try
            {
                var query = _mapper.Map<GetByIdCandlestickQuery>(request);
                var result = await _mediatr.Send(query);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateCandlestickRequest request)
        {
            try
            {
                System.Security.Claims.ClaimsPrincipal currentUser = this.User;
                var claims = currentUser.Claims.ToArray();
                var query = _mapper.Map<CreateCandlestickCommand>(request);
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
        public async Task<IActionResult> Update([FromBody] UpdateCandlestickRequest request)
        {
            try
            {
                System.Security.Claims.ClaimsPrincipal currentUser = this.User;
                var claims = currentUser.Claims.ToArray();
                var query = _mapper.Map<UpdateCandlestickCommand>(request);
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
        public async Task<IActionResult> Delete([FromBody] DeleteCandlestickRequest request)
        {
            try
            {
                System.Security.Claims.ClaimsPrincipal currentUser = this.User;
                var claims = currentUser.Claims.ToArray();
                var query = _mapper.Map<DeleteCandlestickCommand>(request);
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

