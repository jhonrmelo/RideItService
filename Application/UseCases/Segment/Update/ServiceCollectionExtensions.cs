using Application.UseCases.Segment.Update.DataAcess;
using Application.UseCases.Update.Update.DataAcess;

using Microsoft.Extensions.DependencyInjection;

namespace Application.UseCases.Segment.Update
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddUpdateSegmentUseCase(this IServiceCollection services)
        {
            services.AddScoped<IUpdateSegmentUseCaseRepository, UpdateSegmentUseCaseRepository>();
            services.AddScoped<IUpdateSegmentUseCase, UpdateSegmentUseCase>();

            return services;
        }
    }
}