namespace MyFlix.Api.Contracts;

public class NewMovieRequest
{
    public string Name { get; set; }
    public DateTime ReleaseDate { get; set; }
    public bool Available { get; set; }
    public string Director { get; set; }
}