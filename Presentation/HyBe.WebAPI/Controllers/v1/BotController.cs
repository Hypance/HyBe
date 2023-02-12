using AutoMapper;
using HyBe.Application.Features.Backtests.Queries;
using HyBe.Domain.Contracts.Bots;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HyBe.WebAPI.Controllers.v1
{
    [Route("api/v1.0/[controller]/[action]")]
    [ApiController]
    public class BotController : ControllerBase
    {
        #region Fields
        private readonly IMapper _mapper;
        private readonly ISender _mediatr;
        #endregion

        #region Constructor
        public BotController(IMapper mapper, ISender mediatr)
        {
            _mapper = mapper;
            _mediatr = mediatr;
        }
        #endregion

        #region Methods
        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] GetListBotRequest request)
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
        public async Task<IActionResult> Get([FromQuery] GetByIdBotRequest request)
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
        public async Task<IActionResult> Create([FromQuery] CreateBotRequest request)
        {
            try
            {
                var query = _mapper.Map<CreateBacktestCommand>(request);
                var result = await _mediatr.Send(request);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut]
        public async Task<IActionResult> Update([FromQuery] UpdateBotRequest request)
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
        [HttpDelete]
        public async Task<IActionResult> Delete([FromQuery] DeleteBotRequest request)
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
