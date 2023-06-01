using AutoMapper;
using HyBe.Application.Features.Bots.Commands.DeleteBot;
using HyBe.Application.Features.Bots.Commands.UpdateBot;
using HyBe.Application.Features.Bots.Queries;
using HyBe.Application.Features.Bots.Queries.GetByIdBot;
using HyBe.Application.Features.Bots.Queries.GetListBot;
using HyBe.Domain.Contracts.Bots;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HyBe.WebAPI.Controllers.v1
{
    [Route("api/v1.0/[controller]/[action]"), Authorize]
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
                var query = _mapper.Map<GetListBotQuery>(request);
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
                var query = _mapper.Map<GetByIdBotQuery>(request);
                var result = await _mediatr.Send(query);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateBotRequest request)
        {
            try
            {
                var query = _mapper.Map<CreateBotCommand>(request);
                var result = await _mediatr.Send(query);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateBotRequest request)
        {
            try
            {
                var query = _mapper.Map<UpdateBotCommand>(request);
                var result = await _mediatr.Send(query);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] DeleteBotRequest request)
        {
            try
            {
                var query = _mapper.Map<DeleteBotCommand>(request);
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
