﻿using HyBe.Application.Abstractions.Services;
using HyBe.Persistence.Contexts;
using HyBe.Persistence.Repositories;
using HyBe.Persistence.Services;
using HyBe.SharedKernel.Events;
using HyBe.SharedKernel.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace HyBe.Persistence;
public static class PersistenceServiceRegistration
{
    public static IServiceCollection AddPersistenceServices(this IServiceCollection services,
                                                                IConfiguration configuration)
    {
        services.AddDbContext<HypanceDbContext>(options => options.UseNpgsql(configuration.GetConnectionString("HypanceConnectionString")));
        services.AddScoped(typeof(IRepository<>), typeof(EfRepository<>));
        services.AddScoped<IBacktestService, BacktestService>();
        services.AddScoped<ICandlestickServices, CandlestickServices>();
        services.AddScoped<IBotService, BotService>();
        services.AddScoped<IFormationSignalService, FormationSignalService>();
        services.AddScoped<IIndicatorSignalService, IndicatorSignalService>();
        services.AddScoped<IWalletService, WalletService>();
        services.AddScoped<IDomainEventDispatcher, DomainEventDispatcher>();
        return services;
    }
}