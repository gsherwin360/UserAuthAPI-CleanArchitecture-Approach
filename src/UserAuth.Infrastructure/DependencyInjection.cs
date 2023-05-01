using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using UserAuth.Application.Common.Interfaces;
using UserAuth.Infrastructure.Authentication;

namespace UserAuth.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services, 
        ConfigurationManager configuration)
    {
        services.Configure<JwtSettings>(configuration.GetSection(JwtSettings._SectionName));
        services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();
        return services;
    }
} // End of class