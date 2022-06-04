using Application.UseCases.User.Create.DataAccess;

using Microsoft.Extensions.DependencyInjection;

namespace Application.UseCases.User.Create
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddCreateUserUseCase(this IServiceCollection services)
        {
            services.AddScoped<ICreateUserUseCaseRepository, CreateUserUseCaseRepository>();
            services.AddScoped<ICreateUserUseCase, CreateUserUseCase>();

            return services;
        }
    }
}