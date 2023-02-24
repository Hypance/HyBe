using AutoMapper;
using HyBe.Application.Features.FormationSignals.Commands.DeleteFormationSignal;
using HyBe.Application.Features.FormationSignals.Commands.UpdateFormationSignal;
using HyBe.Application.Features.FormationSignals.Queries;
using HyBe.Application.Features.FormationSignals.Queries.GetByIdFormationSignal;
using HyBe.Domain.Contracts.FormationSignals;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HyBe.WebAPI.Controllers.v1
{
    [Route("api/v1.0/[controller]/[action]")]
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
            public async Task<IActionResult> GetList([FromQuery] GetListFormationSignalRequest request)
            {
                try
                {
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
                    var query = _mapper.Map<CreateFormationSignalCommand>(request);
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
                    var query = _mapper.Map<UpdateFormationSignalCommand>(request);
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
                    var query = _mapper.Map<DeleteFormationSignalCommand>(request);
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
