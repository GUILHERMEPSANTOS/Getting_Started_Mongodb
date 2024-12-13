using MyFlix.Api.Contracts;

namespace MyFlix.Api.Services.Interfaces;

public interface IMovieService
{
    Task CreateMovieAsync(MovieRequest movieRequest);
}