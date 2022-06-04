using Application.UseCases.User.Update.DataAccess;

using Microsoft.Extensions.DependencyInjection;

namespace Application.UseCases.User.Update
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddUpdateUserUseCase(this IServiceCollection services)
        {
            services.AddScoped<IUpdateUserUseCaseRepository, UpdateUserUseCaseRepository>();
            services.AddScoped<IUpdateUserUseCase, UpdateUserUseCase>();

            return services;
        }
    }
}