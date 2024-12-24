using MyFlix.Api.Contracts;
using Myflix.Domain;

namespace MyFlix.Api.Services.Interfaces;

public interface IMovieService
{
    Task CreateMovieAsync(NewMovieRequest movieRequest);
    Task<Movie> GetMovieByIdAsync(Guid id);
    Task<IEnumerable<Movie>> GetMoviesWithReleaseDateAfter(DateTime date);
    Task UpdateMovie(UpdateMovieRequest movie);
}