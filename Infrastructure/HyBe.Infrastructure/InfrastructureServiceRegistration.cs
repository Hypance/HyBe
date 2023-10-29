using System;
using HyBe.Application.Abstractions.Infrastructure;
using HyBe.Infrastructure.Services.NotificationService;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace HyBe.Infrastructure
{
	public static class InfrastructureServiceRegistration
	{
		public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
		{
			services.AddScoped<INotificationService, TelegramNotificationService>();
			services.AddScoped<IBinanceFutureService, IBinanceFutureService>();
			return services;
		}
	}
}

