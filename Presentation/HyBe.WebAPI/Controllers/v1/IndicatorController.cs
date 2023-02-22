using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using HyBe.Application.Features.Indicators.Queries;
using HyBe.Domain.Contracts.Indicators;
using HyBe.SharedKernel.Utilities;
using MediatR;
using Microsoft.AspNetCore.Mvc;
namespace HyBe.WebAPI.Controllers.v1
{
    [Route("api/v1.0/[controller]/[action]")]
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
        public async Task<IActionResult> GetList([FromQuery] GetListIndicatorRequest request)
        {
            try
            {
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
                var query = _mapper.Map<CreateIndicatorCommand>(request);
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
                var query = _mapper.Map<UpdateIndicatorCommand>(request);
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
                var query = _mapper.Map<DeleteIndicatorCommand>(request);
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