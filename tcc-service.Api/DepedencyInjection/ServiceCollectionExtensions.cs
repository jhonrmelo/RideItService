using Amazon.Runtime;
using Amazon.S3;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace tcc_service.Api.DepedencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddAwsDepedencies(this IServiceCollection services, IConfiguration configuration)
        {
            var awsOptions = configuration.GetAWSOptions();
            var accessKeyAws = configuration.GetValue<string>("AWS:Credentials:AccessKeyId");
            var secretAccessKeyAws = configuration.GetValue<string>("AWS:Credentials:SecretAccessKey");

            awsOptions.Credentials = new BasicAWSCredentials(accessKeyAws, secretAccessKeyAws);

            services.AddDefaultAWSOptions(awsOptions);
            services.AddAWSService<IAmazonS3>();

            return services;
        }
    }
}