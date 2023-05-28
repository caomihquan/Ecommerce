using EServices.Token.Models;
using EServices.Token.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EServices.Token
{
    public static class TokenServiceCollection
    {
        public static IServiceCollection AddInternalServices(this IServiceCollection services, IConfiguration configuration)
        {
            return services
                .Configure<TokenSetting>(configuration.GetSection("JwtToken"))
                .AddScoped<ITokenGeneratorService, TokenGeneratorService>()
                ;
        }
    }
}
