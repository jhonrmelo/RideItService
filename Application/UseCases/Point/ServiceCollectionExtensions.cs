using Application.UseCases.Point.GetAll;
using Application.UseCases.Point.GetById;

using Microsoft.Extensions.DependencyInjection;

namespace Application.UseCases.Point
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddPointUseCases(this IServiceCollection services)
        {
            return services.AddGetByIdPointUseCase()
                           .AddGetAllPointUseCase();
        }
    }
}