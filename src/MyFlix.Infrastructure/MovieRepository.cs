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

    public async Task Add(Movie movie)
    {
        await _collection.InsertOneAsync(movie);
    }

    public async Task<Movie> GetMovieByIdAsync(Guid id)
    {
        var filter = Builders<Movie>.Filter.Eq(movie => movie.Id, id);
        return await _collection.Find(filter).SingleAsync();
    }
}