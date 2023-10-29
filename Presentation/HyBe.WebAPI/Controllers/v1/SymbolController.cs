using AutoMapper;
using HyBe.Application.Features.Symbols.Commands;
using HyBe.Application.Features.Symbols.Commands.CreateSymbol;
using HyBe.Application.Features.Symbols.Commands.DeleteSymbol;
using HyBe.Application.Features.Symbols.Commands.UpdateSymbol;
using HyBe.Application.Features.Symbols.Queries.GetByIdSymbol;
using HyBe.Application.Features.Symbols.Queries.GetListSymbol;
using HyBe.Domain.Contracts.Symbols;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HyBe.WebAPI.Controllers.v1
{
    [Route("api/v1.0/[controller]/[action]"), Authorize]
    [ApiController]
    public class SymbolController : ControllerBase
    {
        #region Fileds
        private readonly IMapper _mapper;
        private readonly ISender _mediatr;
        #endregion

        #region Constructor
        public SymbolController(IMapper mapper, ISender mediatr)
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
                var request = new GetListSymbolRequest {};
                var query = _mapper.Map<GetListSymbolQuery>(request);
                var result = await _mediatr.Send(query);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] GetByIdSymbolRequest request)
        {
            try
            {
                var query = _mapper.Map<GetByIdSymbolQuery>(request);
                var result = await _mediatr.Send(query);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateSymbolRequest request)
        {
            try
            {
                var query = _mapper.Map<CreateSymbolCommand>(request);
                var result = await _mediatr.Send(query);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateSymbolRequest request)
        {
            try
            {
                var query = _mapper.Map<UpdateSymbolCommand>(request);
                var result = await _mediatr.Send(query);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] DeleteSymbolRequest request)
        {
            try
            {
                var query = _mapper.Map<DeleteSymbolCommand>(request);
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
