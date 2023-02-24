using AutoMapper;
using HyBe.Application.Features.Wallets.Commands;
using HyBe.Application.Features.Wallets.Commands.DeleteWallet;
using HyBe.Application.Features.Wallets.Commands.UpdateWallet;
using HyBe.Application.Features.Wallets.Queries.GetByIdWallet;
using HyBe.Application.Features.Wallets.Queries.GetListWallet;
using HyBe.Domain.Contracts.Wallets;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HyBe.WebAPI.Controllers.v1
{
    [Route("api/v1.0/[controller]/[action]")]
    [ApiController]
    public class WalletController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ISender _mediatr;
        public WalletController(IMapper mapper, ISender mediatr)
        {
            _mapper = mapper;
            _mediatr = mediatr;
        }
        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] GetListWalletRequest request)
        {
            try
            {
                var query = _mapper.Map<GetListWalletQuery>(request);
                var result = await _mediatr.Send(query);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] GetByIdWalletRequest request)
        {
            try
            {
                var query = _mapper.Map<GetByIdWalletQuery>(request);
                var result = await _mediatr.Send(query);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateWalletRequest request)
        {
            try
            {
                var query = _mapper.Map<CreateWalletCommand>(request);
                var result = await _mediatr.Send(query);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateWalletRequest request)
        {
            try
            {
                var query = _mapper.Map<UpdateWalletCommand>(request);
                var result = await _mediatr.Send(query);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] DeleteWalletRequest request)
        {
            try
            {
                var query = _mapper.Map<DeleteWalletCommand>(request);
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
