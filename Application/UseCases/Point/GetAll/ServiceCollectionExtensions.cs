using Application.UseCases.Point.GetAll.DataAcess;

using Microsoft.Extensions.DependencyInjection;

namespace Application.UseCases.Point.GetAll
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddGetAllPointUseCase(this IServiceCollection services)
        {
            services.AddScoped<IGetAllPointUseCaseRepository, GetAllPointUseCaseRepository>();
            services.AddScoped<IGetAllPointUseCase, GetAllPointUseCase>();

            return services;
        }
    }
}