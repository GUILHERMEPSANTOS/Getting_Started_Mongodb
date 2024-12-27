using MyFlix.Api.Contracts;
using MyFlix.Api.Services.Interfaces;
using Myflix.Domain;

namespace MyFlix.Api.Services;

public class MovieService(IMovieRepository movieRepository) : IMovieService
{
    public async Task CreateMovieAsync(NewMovieRequest request)
    {
        var movie = Movie.Create(request.Name, request.ReleaseDate, request.Available, request.Director);

        await movieRepository.Add(movie);
    }

    public Task<Movie> GetMovieByIdAsync(Guid id)
    {
        return movieRepository.GetMovieByIdAsync(id);
    }

    public async Task<IEnumerable<Movie>> GetMoviesWithReleaseDateAfter(DateTime date)
    {
        return await movieRepository.GetMoviesWithReleaseDateAfter(date);
    }

    public async Task UpdateMovie(UpdateMovieRequest request)
    {
        var movie = Movie.Create(request.Name, request.ReleaseDate, request.Available, request.Director);
        await movieRepository.UpdateMovie(request.Id, movie);
    }

    public async Task DeleteMovie(Guid id)
    {
        await movieRepository.DeleteMovie(id);
    }
}