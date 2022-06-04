using Application.UseCases.User.Create;
using Application.UseCases.User.Delete;
using Application.UseCases.User.GetAll;
using Application.UseCases.User.GetById;
using Application.UseCases.User.ImageDownload;
using Application.UseCases.User.ImageUpload;
using Application.UseCases.User.Update;

using Microsoft.Extensions.DependencyInjection;

namespace Application.UseCases.User
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddUserUseCases(this IServiceCollection services)
        {
            return services.AddUpdateUserUseCase()
                     .AddGetByIdUserUseCase()
                     .AddGetAllUserUseCase()
                     .AddDeleteUserUseCase()
                     .AddCreateUserUseCase()
                     .AddImageDownloadUseCase()
                     .AddUserImageUploadUseCase();
        }
    }
}