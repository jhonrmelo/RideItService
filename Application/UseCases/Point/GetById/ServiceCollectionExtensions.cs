using Application.UseCases.Point.GetById.DataAcess;

using Microsoft.Extensions.DependencyInjection;

namespace Application.UseCases.Point.GetById
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddGetByIdPointUseCase(this IServiceCollection services)
        {
            services.AddScoped<IGetByIdPointUseCaseRepository, GetByIdPointUseCaseRepository>();
            services.AddScoped<IGetByIdPointUseCase, GetByIdPointUseCase>();

            return services;
        }
    }
}