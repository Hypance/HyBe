using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using HyBe.Application.Features.Backtests.Queries;
using HyBe.Domain.Contracts.Backtests;
using HyBe.SharedKernel.Utilities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HyBe.WebAPI.Controllers.v1
{
    [Route("api/v1.0/[controller]/[action]")]
    [ApiController]
    public class BacktestController : ControllerBase
    {
        #region Fileds
        private readonly IMapper _mapper;
        private readonly ISender _mediatr;
        #endregion

        #region Constructor
        public BacktestController(IMapper mapper, ISender mediatr)
        {
            _mapper = mapper;
            _mediatr = mediatr;
        }
        #endregion

        #region Methods

        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery]GetListBacktestRequest request)
        {
            try
            {
                var query = _mapper.Map<GetListBacktestQuery>(request);
                var result = await _mediatr.Send(query);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] GetByIdBacktestRequest request)
        {
            try
            {
                var query = _mapper.Map<GetByIdBacktestQuery>(request);
                var result = await _mediatr.Send(query);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateBacktestRequest request)
        {
            try
            {
                var query = _mapper.Map<CreateBacktestCommand>(request);
                var result = await _mediatr.Send(query);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromQuery] UpdateBacktestRequest request)
        {
            try
            {
                var query = _mapper.Map<UpdateBacktestCommand>(request);
                var result = await _mediatr.Send(query);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromQuery] DeleteBacktestRequest request)
        {
            try
            {
                var query = _mapper.Map<DeleteBacktestCommand>(request);
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

