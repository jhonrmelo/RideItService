using Application.UseCases.Segment.GetById.DataAcess;

using Microsoft.Extensions.DependencyInjection;

namespace Application.UseCases.Segment.GetById
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddGetByIdSegmentUseCase(this IServiceCollection services)
        {
            services.AddScoped<IGetByIdSegmentUseCaseRepository, GetByIdSegmentUseCaseRepository>();
            services.AddScoped<IGetByIdSegmentUseCase, GetByIdSegmentUseCase>();

            return services;
        }
    }
}