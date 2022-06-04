using Application.UseCases.Segment.GetAll;
using Application.UseCases.Segment.GetById;
using Application.UseCases.Segment.Update;

using Microsoft.Extensions.DependencyInjection;

namespace Application.UseCases.Segment
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddSegmentUseCases(this IServiceCollection services)
        {
            return services.AddGetByIdSegmentUseCase()
                           .AddGetAllSegmentUseCase()
                           .AddUpdateSegmentUseCase();
        }
    }
}