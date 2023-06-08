using AutoMapper;
using HyBe.Application.Features.Indicators.Queries;
using HyBe.Application.Features.IndicatorSignals.Commands.CreateIndicatorSignal;
using HyBe.Application.Features.Transactions.Commands.CreateTransaction;
using HyBe.Application.Features.Transactions.Queries.GetListTransaction;
using HyBe.Domain.Contracts.IndicatorSignals;
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
    public async Task<IActionResult> GetList([FromQuery] GetListTransactionRequest request)
    {
        try
        {
            System.Security.Claims.ClaimsPrincipal currentUser = this.User;
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
    public IActionResult Get(int id)
    {
        return Ok();
    }

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
    #endregion
}