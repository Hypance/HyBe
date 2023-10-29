using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using HyBe.Application.Features.Strategies.Queries;
using HyBe.Domain.Contracts.Strategies;
using HyBe.SharedKernel.Utilities;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HyBe.WebAPI.Controllers.v1
{
    [Route("api/v1.0/[controller]/[action]"), Authorize]
    [ApiController]
    public class StrategyController : ControllerBase
    {
        #region Fileds
        private readonly IMapper _mapper;
        private readonly ISender _mediatr;
        #endregion

        #region Constructor
        public StrategyController(IMapper mapper, ISender mediatr)
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
                var request = new GetListStrategyRequest { MemberId = claims[3].Value };
                var query = _mapper.Map<GetListStrategyQuery>(request);
                var result = await _mediatr.Send(query);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] GetByIdStrategyRequest request)
        {
            try
            {
                var query = _mapper.Map<GetByIdStrategyQuery>(request);
                var result = await _mediatr.Send(query);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateStrategyRequest request)
        {
            try
            {
                System.Security.Claims.ClaimsPrincipal currentUser = this.User;
                var claims = currentUser.Claims.ToArray();
                var query = _mapper.Map<CreateStrategyCommand>(request);
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
        public async Task<IActionResult> Update([FromBody] UpdateStrategyRequest request)
        {
            try
            {
                System.Security.Claims.ClaimsPrincipal currentUser = this.User;
                var claims = currentUser.Claims.ToArray();
                var query = _mapper.Map<UpdateStrategyCommand>(request);
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
        public async Task<IActionResult> Delete([FromBody] DeleteStrategyRequest request)
        {
            try
            {
                System.Security.Claims.ClaimsPrincipal currentUser = this.User;
                var claims = currentUser.Claims.ToArray();
                var query = _mapper.Map<DeleteStrategyCommand>(request);
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

