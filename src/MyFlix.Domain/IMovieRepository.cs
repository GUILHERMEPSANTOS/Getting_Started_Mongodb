namespace Myflix.Domain;

public interface IMovieRepository
{
    Task Add(Movie movie);
    Task<Movie> GetMovieByIdAsync(Guid id);
    Task<IEnumerable<Movie>> GetMoviesWithReleaseDateAfter(DateTime date);
    Task UpdateMovie(Guid id, Movie movie);
    Task DeleteMovie(Guid id);

}