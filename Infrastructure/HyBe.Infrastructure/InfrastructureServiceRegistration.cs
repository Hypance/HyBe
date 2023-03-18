using System;
using HyBe.Application.Abstractions.Infrastructure;
using HyBe.Application.Abstractions.Services;
// using HyBe.Application.Abstractions.Token;
using HyBe.Infrastructure.Services;
using HyBe.Infrastructure.Services.NotificationService;
// using HyBe.Infrastructure.Services.Token;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace HyBe.Infrastructure
{
	public static class InfrastructureServiceRegistration
	{
		public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
		{
			// services.AddScoped<ITokenHandler, TokenHandler>();
			// services.AddScoped<IMailService, MailService>();
			// services.AddScoped<IApplicationService, ApplicationService>();
			services.AddScoped<INotificationService, TelegramNotificationService>();
			return services;
		}
	}
}

