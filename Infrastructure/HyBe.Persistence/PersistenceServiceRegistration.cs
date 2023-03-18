using HyBe.Application.Abstractions.Services;
using HyBe.Application.Abstractions.Services.Authentications;
using HyBe.Domain.Entities.Identity;
// using HyBe.Application.Abstractions.Services.Authentications;
using HyBe.Persistence.Contexts;
using HyBe.Persistence.Repositories;
using HyBe.Persistence.Services;
using HyBe.SharedKernel.Events;
using HyBe.SharedKernel.Repositories;
using Microsoft.AspNetCore.Identity;
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
		
        services.AddIdentity<AppUser, AppRole>(options =>
		{
			options.Password.RequiredLength = 3;
			options.Password.RequireNonAlphanumeric = false;
			options.Password.RequireDigit = false;
			options.Password.RequireLowercase = false;
			options.Password.RequireUppercase = false;
		}).AddEntityFrameworkStores<HypanceDbContext>()
			.AddDefaultTokenProviders();

		services.AddScoped(typeof(IRepository<>), typeof(EfRepository<>));
        services.AddScoped<IBacktestService, BacktestService>();
		services.AddScoped<IIndicatorService, IndicatorService>();
        services.AddScoped<ICandlestickServices, CandlestickServices>();
        services.AddScoped<IBotService, BotService>();
        services.AddScoped<IFormationSignalService, FormationSignalService>();
        services.AddScoped<IIndicatorSignalService, IndicatorSignalService>();
        services.AddScoped<IWalletService, WalletService>();
        services.AddScoped<IFormationService, FormationService>();
        services.AddScoped<IStrategyService, StrategyService>();
        services.AddScoped<ISignalService, SignalService>();
        services.AddScoped<ISymbolService, SymbolService>();

		services.AddScoped<IUserService, UserService>();
		services.AddScoped<IAuthService, AuthService>();
		services.AddScoped<IInternalAuthentication, AuthService>();
		// services.AddScoped<IRoleService, RoleService>();
        // services.AddScoped<IAuthorizationEndpointService, AuthorizationEndpointService>();
        
		services.AddScoped<IDomainEventDispatcher, DomainEventDispatcher>();


		
        //services.AddScoped<IAuthorizationEndpointService, AuthorizationEndpointService>();


        return services;
    }

}

