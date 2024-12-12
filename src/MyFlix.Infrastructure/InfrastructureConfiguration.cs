using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using MongoDB.Driver;
using Myflix.Domain;

namespace Myflix.Infrastructure;

public static class InfrastructureConfiguration
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, string connectionString)
    {
        var mongoSettings = MongoClientSettings.FromConnectionString(connectionString);

        services.AddSingleton<IMongoClient>(new MongoClient(mongoSettings));
        services.AddScoped<IMovieRepository, MovieRepository>();
        
        return services;
    }
}