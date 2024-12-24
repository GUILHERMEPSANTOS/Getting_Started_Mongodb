namespace MyFlix.Api.Contracts;

public class UpdateMovieRequest
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public DateTime ReleaseDate { get; set; }
    public bool Available { get; set; }
    public string Director { get; set; }
}