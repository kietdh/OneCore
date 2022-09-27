using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OneCore.Application.Common.Interfaces.Authentication;
using OneCore.Application.Common.Interfaces.Services;
using OneCore.Infrastructure.Authentication;
using OneCore.Infrastructure.Services;

namespace OneCore.Infrastructure;

public static class DependencyInjection {
    public static IServiceCollection AddInfrastructure(this IServiceCollection services,
        ConfigurationManager configuration) {
        services.Configure<JwtSettings>(configuration.GetSection(JwtSettings.SectionName));
        services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();
        services.AddSingleton<IDateTimeProvider, DateTimeProvider>();
        return services;
    }
}