using Application.UseCases.Authenticate.DataAccess;

using Microsoft.Extensions.DependencyInjection;

namespace Application.UseCases.Authenticate
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddAuthenticateUseCase(this IServiceCollection services)
        {
            services.AddScoped<IAuthenticateUseCaseRepository, AuthenticateUseCaseRepository>();
            services.AddScoped<IAuthenticateUseCase, AuthenticateUseCase>();

            return services;
        }
    }
}