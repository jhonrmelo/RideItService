using Application.UseCases.User.GetAll.DataAccess;

using Microsoft.Extensions.DependencyInjection;

namespace Application.UseCases.User.GetAll
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddGetAllUserUseCase(this IServiceCollection services)
        {
            services.AddScoped<IGetAllUserUseCaseRepository, GetAllUserUseCaseRepository>();
            services.AddScoped<IGetAllUserUseCase, GetAllUserUseCase>();

            return services;
        }
    }
}