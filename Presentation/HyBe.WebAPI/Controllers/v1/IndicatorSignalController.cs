using AutoMapper;
using HyBe.Application.Features.IndicatorSignals.Commands.CreateIndicatorSignal;
using HyBe.Application.Features.IndicatorSignals.Commands.DeleteIndicatorSignal;
using HyBe.Application.Features.IndicatorSignals.Commands.UpdateIndicatorSignal;
using HyBe.Application.Features.IndicatorSignals.Queries.GetByIdIndicatorSignal;
using HyBe.Application.Features.IndicatorSignals.Queries.GetListIndicatorSignal;
using HyBe.Domain.Contracts.IndicatorSignal;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HyBe.WebAPI.Controllers.v1
{
    [Route("api/v1.0/[controller]/[action]")]
    [ApiController]
    public class IndicatorSignalController : ControllerBase
    {
        #region Fileds
        private readonly IMapper _mapper;
        private readonly ISender _mediatr;
        #endregion

        #region Constructor
        public IndicatorSignalController(IMapper mapper, ISender mediatr)
        {
            _mapper = mapper;
            _mediatr = mediatr;
        }
        #endregion

        #region Methods

        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] GetListIndicatorSignalRequest request)
        {
            try
            {
                var query = _mapper.Map<GetListIndicatorSignalQuery>(request);
                var result = await _mediatr.Send(query);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] GetByIdIndicatorSignalRequest request)
        {
            try
            {
                var query = _mapper.Map<GetByIdIndicatorSignalQuery>(request);
                var result = await _mediatr.Send(query);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateIndicatorSignalRequest request)
        {
            try
            {
                var query = _mapper.Map<CreateIndicatorSignalCommand>(request);
                var result = await _mediatr.Send(query);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateIndicatorSignalRequest request)
        {
            try
            {
                var query = _mapper.Map<UpdateIndicatorSignalCommand>(request);
                var result = await _mediatr.Send(query);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] DeleteIndicatorSignalRequest request)
        {
            try
            {
                var query = _mapper.Map<DeleteIndicatorSignalCommand>(request);
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
