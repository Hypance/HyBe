using AutoMapper;
using HyBe.Application.Features.Indicators.Queries;
using HyBe.Application.Features.IndicatorSignals.Commands.CreateIndicatorSignal;
using HyBe.Application.Features.Signals.Queries;
using HyBe.Application.Features.Transactions.Commands.CreateTransaction;
using HyBe.Application.Features.Transactions.Commands.UpdateTransaction;
using HyBe.Application.Features.Transactions.Queries.GetListTransaction;
using HyBe.Domain.Contracts.IndicatorSignals;
using HyBe.Domain.Contracts.Signals;
using HyBe.Domain.Contracts.Transactions;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HyBe.WebAPI.Controllers.v1;

[Route("api/v1.0/[controller]/[action]"), Authorize]
[ApiController]
public class TransactionController : ControllerBase
{
    #region Fields
    private readonly IMapper _mapper;
    private readonly ISender _mediatr;
    #endregion
    #region Constructor
    public TransactionController(IMapper mapper, ISender mediatr)
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
            System.Security.Claims.ClaimsPrincipal currentUser = this.User;
            var claims = currentUser.Claims.ToArray();

            var request = new GetListTransactionRequest
            {
                MemberId = claims[3].Value,
            };
            var query = _mapper.Map<GetListTransactionQuery>(request);
            var result = await _mediatr.Send(query);
            return Ok(result);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
    [HttpGet]
    public async Task<IActionResult> GetListByLastDay()
    { 
        try
        { 
            System.Security.Claims.ClaimsPrincipal currentUser = this.User;
            var claims = currentUser.Claims.ToArray();

            var request = new GetListTransactionRequest
            {
                MemberId = claims[3].Value,
                StartDate = DateTimeOffset.UtcNow.AddDays(-1)
            };
     
            var query = _mapper.Map<GetListTransactionQuery>(request);
            var result = await _mediatr.Send(query);
            return Ok(result);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
    [HttpGet]
    public async Task<IActionResult> GetListByLastWeek()
    {
        try
        {
            System.Security.Claims.ClaimsPrincipal currentUser = this.User;
            var claims = currentUser.Claims.ToArray();
            var request = new GetListTransactionRequest
            {
                MemberId = claims[3].Value,
                StartDate = DateTimeOffset.UtcNow.AddDays(-7)
            };
            var query = _mapper.Map<GetListTransactionQuery>(request);
            var result = await _mediatr.Send(query);
            return Ok(result);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
    [HttpGet]
    public async Task<IActionResult> GetListByLastMonth()
    {
        try
        {
            System.Security.Claims.ClaimsPrincipal currentUser = this.User;
            var claims = currentUser.Claims.ToArray();
            var request = new GetListTransactionRequest
            {
                MemberId = claims[3].Value,
                StartDate = DateTimeOffset.UtcNow.AddMonths(-1)
            };
            var query = _mapper.Map<GetListTransactionQuery>(request);
            var result = await _mediatr.Send(query);
            return Ok(result);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
   /* [HttpGet] 
    * public IActionResult Get(Guid id)
    {
        return Ok();
    }
   */
    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateTransactionRequest request)
    {
        try
        {
            var query = _mapper.Map<CreateTransactionCommand>(request);
            var result = await _mediatr.Send(query);
            return Ok(result);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
    [HttpPut]
    public async Task<IActionResult> Update()
    {
        try
        {
            System.Security.Claims.ClaimsPrincipal currentUser = this.User;
            var claims = currentUser.Claims.ToArray();
            var request = new GetListTransactionRequest
            {
                MemberId = claims[3].Value
            };
            var query = _mapper.Map<UpdateTransactionCommand>(request);
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