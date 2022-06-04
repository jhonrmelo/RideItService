using Application.UseCases.User.ImageDownload.DataAccess;

using Microsoft.Extensions.DependencyInjection;

namespace Application.UseCases.User.ImageDownload
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddImageDownloadUseCase(this IServiceCollection services)
        {
            services.AddScoped<IUserImageDownloadUseCaseRepository, UserImageDownloadUseCaseRepository>();
            services.AddScoped<IUserImageDownloadUseCase, UserImageDownloadUseCase>();

            return services;
        }
    }
}