using System;
using HyBe.Domain.Contracts.Notifications;
using HyBe.SharedKernel.Utilities;
using MediatR;

namespace HyBe.Application.Features.Notifications.Commands.SendNotification;

public class SendNotificationCommand : IRequest<IResult>
{
	public SendNotificationRequest Request { get; set; }
	public SendNotificationCommand(SendNotificationRequest request)
	{
		Request = request;
    }
}

