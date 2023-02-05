using AutoMapper;
using HyBe.Application.Features.Symbols.Queries.GetListSymbol;
using HyBe.Domain.Contracts.Symbols;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HyBe.WebAPI.Controllers.v1
{
    [Route("api/v1.0/[controller]/[action]")]
    [ApiController]
    public class SymbolController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ISender _mediatr;

        public SymbolController(IMapper mapper, ISender mediatr)
        {
            _mapper = mapper;
            _mediatr = mediatr;
        }

        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] GetListSymbolRequest request)
        {
            try
            {
                var query = _mapper.Map<GetListSymbolQuery>(request);
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
