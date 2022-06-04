using Application.UseCases.Segment.GetAll.DataAcess;

using Microsoft.Extensions.DependencyInjection;

namespace Application.UseCases.Segment.GetAll
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddGetAllSegmentUseCase(this IServiceCollection services)
        {
            services.AddScoped<IGetAllSegmentUseCaseRepository, GetAllSegmentUseCaseRepository>();
            services.AddScoped<IGetAllSegmentUseCase, GetAllSegmentUseCase>();

            return services;
        }
    }
}