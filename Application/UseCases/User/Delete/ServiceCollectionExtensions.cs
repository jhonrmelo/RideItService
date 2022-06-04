using Application.UseCases.User.Delete.DataAccess;

using Microsoft.Extensions.DependencyInjection;

namespace Application.UseCases.User.Delete
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDeleteUserUseCase(this IServiceCollection services)
        {
            services.AddScoped<IDeleteUserUseCaseRepository, DeleteUserUseCaseRepository>();
            services.AddScoped<IDeleteUserUseCase, DeleteUserUseCase>();

            return services;
        }
    }
}