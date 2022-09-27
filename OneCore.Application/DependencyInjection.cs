using Microsoft.Extensions.DependencyInjection;
using OneCore.Application.Services.Authentication;

namespace OneCore.Application;

public static class DependencyInjection {
    public static IServiceCollection AddApplication(this IServiceCollection services) {
        services.AddScoped<IAuthenticationService, AuthenticationService>();
        return services;
    }
}