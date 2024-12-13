namespace Myflix.Domain;

public interface IMovieRepository
{
    Task Add(Movie movie);
    Task<Movie> GetMovieByIdAsync(Guid id);
}
