using Application.UseCases.User.GetById.DataAccess;

using Microsoft.Extensions.DependencyInjection;

namespace Application.UseCases.User.GetById
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddGetByIdUserUseCase(this IServiceCollection services)
        {
            services.AddScoped<IGetByIdUserUseCaseRepository, GetByIdUserUseCaseRepository>();
            services.AddScoped<IGetByIdUserUseCase, GetByIdUserUseCase>();

            return services;
        }
    }
}