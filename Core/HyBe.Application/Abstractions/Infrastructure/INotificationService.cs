using System;
using HyBe.Domain.Contracts.Notifications;
using HyBe.SharedKernel.Utilities;

namespace HyBe.Application.Abstractions.Infrastructure
{
	public interface INotificationService
	{
		IResult SendNotification(SendNotificationRequest request);
	}
}

