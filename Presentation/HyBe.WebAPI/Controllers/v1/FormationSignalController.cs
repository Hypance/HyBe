using AutoMapper;
using HyBe.Application.Features.FormationSignals.Commands.DeleteFormationSignal;
using HyBe.Application.Features.FormationSignals.Commands.UpdateFormationSignal;
using HyBe.Application.Features.FormationSignals.Queries;
using HyBe.Application.Features.FormationSignals.Queries.GetByIdFormationSignal;
using HyBe.Domain.Contracts.FormationSignals;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HyBe.WebAPI.Controllers.v1
{
    [Route("api/v1.0/[controller]/[action]"), Authorize]
    [ApiController]

        public class FormationSignalController : ControllerBase
        {
            #region Fields
            private readonly IMapper _mapper;
            private readonly ISender _mediatr;
            #endregion

            #region Constructor
            public FormationSignalController(IMapper mapper, ISender mediatr)
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
                var request = new GetListFormationSignalRequest { MemberId = claims[3].Value };
                var query = _mapper.Map<GetListFormationSignalQuery>(request);
                var result = await _mediatr.Send(query);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] GetByIdFormationSignalRequest request)
        {
            try
            {
                var query = _mapper.Map<GetByIdFormationSignalQuery>(request);
                var result = await _mediatr.Send(query);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateFormationSignalRequest request)
        {
            try
            {
                System.Security.Claims.ClaimsPrincipal currentUser = this.User;
                var claims = currentUser.Claims.ToArray();
                var query = _mapper.Map<CreateFormationSignalCommand>(request);
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
        public async Task<IActionResult> Update([FromBody] UpdateFormationSignalRequest request)
        {
            try
            {
                System.Security.Claims.ClaimsPrincipal currentUser = this.User;
                var claims = currentUser.Claims.ToArray();
                var query = _mapper.Map<UpdateFormationSignalCommand>(request);
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
        public async Task<IActionResult> Delete([FromBody] DeleteFormationSignalRequest request)
        {
            try
            {
                System.Security.Claims.ClaimsPrincipal currentUser = this.User;
                var claims = currentUser.Claims.ToArray();
                var query = _mapper.Map<DeleteFormationSignalCommand>(request);
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
