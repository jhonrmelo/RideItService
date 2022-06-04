using Application.UseCases.User.ImageUpload.DataAccess;

using Microsoft.Extensions.DependencyInjection;

namespace Application.UseCases.User.ImageUpload
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddUserImageUploadUseCase(this IServiceCollection services)
        {
            services.AddScoped<IUserImageUploadUseCaseRepository, UserImageUploadUseCaseRepository>();
            services.AddScoped<IUserImageUploadUseCase, UserImageUploadUseCase>();

            return services;
        }
    }
}