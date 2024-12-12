using MongoDB.Driver;
using Myflix.Domain;
using Myflix.Infrastructure.Database;

namespace Myflix.Infrastructure;

public class MovieRepository : IMovieRepository
{
    private readonly IMongoCollection<Movie> _collection;

    public MovieRepository(IMongoClient _client)
    {
        IMongoDatabase database = _client.GetDatabase(DocumentDbSettings.Database);

        _collection = database.GetCollection<Movie>(DocumentDbSettings.Collection);
    }

    public void Add(Movie movie)
    {
        _collection.InsertOne(movie);
    }

    public async Task<Movie> GetMovieByIdAsync(Guid id)
    {
        FilterDefinition<Movie> filter = Builders<Movie>.Filter.Eq(movie => movie.Id, id);
        
        return await _collection.Find(filter).SingleAsync();
    }
}