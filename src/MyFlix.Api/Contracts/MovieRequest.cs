namespace MyFlix.Api.Contracts;

public class MovieRequest
{
    public string Name { get; set; }
    public string ReleaseDate { get; set; }
    public bool Available { get; set; }
    public string Director { get; set; }
}