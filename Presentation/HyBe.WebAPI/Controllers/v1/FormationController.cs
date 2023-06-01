using AutoMapper;
using HyBe.Application.Features.Formations.Commands.CreateFormation;
using HyBe.Application.Features.Formations.Commands.DeleteFormation;
using HyBe.Application.Features.Formations.Commands.UpdateFormation;
using HyBe.Application.Features.Formations.Queries.GetByIdFormation;
using HyBe.Application.Features.Formations.Queries.GetListFormation;
using HyBe.Domain.Contracts.Formations;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HyBe.WebAPI.Controllers.v1
{
    [Route("api/v1.0/[controller]/[action]"), Authorize]
    [ApiController]
    public class FormationController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ISender _mediatr;
        public FormationController(IMapper mapper, ISender mediatr)
        {
            _mapper = mapper;
            _mediatr = mediatr;
        }
        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] GetListFormationRequest request)
        {
            try
            {
                var query = _mapper.Map<GetListFormationQuery>(request);
                var result = await _mediatr.Send(query);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] GetByIdFormationRequest request)
        {
            try
            {
                var query = _mapper.Map<GetByIdFormationQuery>(request);
                var result = await _mediatr.Send(query);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateFormationRequest request)
        {
            try
            {
                var query = _mapper.Map<CreateFormationCommand>(request);
                var result = await _mediatr.Send(query);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateFormationRequest request)
        {
            try
            {
                var query = _mapper.Map<UpdateFormationCommand>(request);
                var result = await _mediatr.Send(query);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] DeleteFormationRequest request)
        {
            try
            {
                var query = _mapper.Map<DeleteFormationCommand>(request);
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
