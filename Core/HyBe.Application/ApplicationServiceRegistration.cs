using System;
using System.Reflection;
using MediatR;
using HyBe.Application.Abstractions.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using HyBe.Application.Common.Behaviors;
using Microsoft.AspNetCore.Http;
using Autofac.Core;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace HyBe.Application;

public static class ApplicationServiceRegistration
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        services.AddMediatR(configuration =>
        {
            configuration.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
        });
        services.AddScoped(typeof(IPipelineBehavior<,>),typeof(RequestValidationBehavior<,>));
        services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();

        return services;
    }
}