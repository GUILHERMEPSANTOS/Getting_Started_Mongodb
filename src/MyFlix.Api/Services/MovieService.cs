using MyFlix.Api.Contracts;
using MyFlix.Api.Services.Interfaces;
using Myflix.Domain;

namespace MyFlix.Api.Services;

public class MovieService(IMovieRepository movieRepository) : IMovieService
{
    public async Task CreateMovieAsync(MovieRequest request)
    {
        var movie = Movie.Create(request.Name, request.ReleaseDate, request.Available, request.Director);

        await movieRepository.Add(movie);
    }
}