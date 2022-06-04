using Application.Shared.Infra.ArangoDb;
using Application.Shared.Infra.MongoDb;
using Application.Shared.Infra.SqlServer;
using Application.UseCases.Authenticate;
using Application.UseCases.Point;
using Application.UseCases.Route;
using Application.UseCases.Segment;
using Application.UseCases.User;

using ArangoDBNetStandard;
using ArangoDBNetStandard.Transport.Http;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using MongoDB.Driver;

using System;

namespace Application.DepedencyInjection
{
    public static class ServiceCollectionExtensions
    {
        private const string _arangoDbUrlPath = "ArangoDBConfiguration:URL";
        private const string _arangoDbDatabasePath = "ArangoDBConfiguration:DataBase";
        private const string _arangoDbUserPath = "ArangoDBConfiguration:User";
        private const string _arangoDbPasswordPath = "ArangoDBConfiguration:Password";
        private const string _mongoDbDatabasePath = "MongoConfiguration:Database";
        private const string _mongoDbConnectionPath = "MongoConfiguration:Connection";

        public static IServiceCollection AddUseCases(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton<IConnectionProvider, ConnectionProvider>()
                    .AddArangoDb(configuration)
                    .AddMongoDb(configuration)
                    .AddAuthenticateUseCase()
                    .AddUserUseCases()
                    .AddSegmentUseCases()
                    .AddPointUseCases()
                    .AddRouteUseCases();

            return services;
        }

        private static IServiceCollection AddArangoDb(this IServiceCollection services, IConfiguration configuration)
        {
            string arangoDbUrl = configuration[_arangoDbUrlPath];
            string arangoDbDataBase = configuration[_arangoDbDatabasePath];
            string arangoDbUser = configuration[_arangoDbUserPath];
            string arangoDbPassword = configuration[_arangoDbPasswordPath];

            var transport = HttpApiTransport.UsingBasicAuth(new Uri(arangoDbUrl),
                                                            arangoDbDataBase,
                                                            arangoDbUser,
                                                            arangoDbPassword);

            var adb = new ArangoDBClient(transport);

            return services.AddSingleton<IArangoDbConnectionProvider>(_ => new ArangoDbConnectionProvider(adb));
        }

        private static IServiceCollection AddMongoDb(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton(sp =>
            {
                var mongoClient = new MongoClient(configuration[_mongoDbConnectionPath]);
                return mongoClient.GetDatabase(configuration[_mongoDbDatabasePath]);
            });

            return services.AddUserRouteCollection();
        }
    }
}