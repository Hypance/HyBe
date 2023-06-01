using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using HyBe.Application.Features.Notifications.Commands.SendNotification;
using HyBe.Domain.Contracts.Notifications;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HyBe.WebAPI.Controllers.v1
{
    [Route("api/v1.0/[controller]/[action]"), Authorize]
    public class NotificationController : ControllerBase
    {

        #region Fields
        private readonly IMapper _mapper;
        private readonly ISender _sender;
        #endregion

        #region Constructor
        public NotificationController(IMapper mapper, ISender sender)
        {
            _mapper = mapper;
            _sender = sender;
        }
        #endregion

        #region Methods

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] SendNotificationRequest request)
        {
            try
            {
                var command = _mapper.Map<SendNotificationCommand>(request);
                var result = await _sender.Send(command);
                if (!result.Success)
                    throw new Exception(result.Message);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        #endregion

    }
}

