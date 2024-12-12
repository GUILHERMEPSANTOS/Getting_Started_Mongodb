namespace Myflix.Domain;

public interface IMovieRepository
{
    void Add(Movie movie);
    Task<Movie> GetMovieByIdAsync(Guid id);
}
