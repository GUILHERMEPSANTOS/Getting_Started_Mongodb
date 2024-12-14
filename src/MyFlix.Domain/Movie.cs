using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Myflix.Domain;

public class Movie
{
    [BsonId, BsonGuidRepresentation(GuidRepresentation.Standard)]
    public Guid Id { get; private set; }

    public string Name { get; private set; }
    public DateTime? ReleaseDate { get; private set; }
    public bool Available { get; private set; }
    public string Director { get; private set; }

    private Movie(string name, DateTime releaseDate, bool available, string director)
    {
        Id = Guid.NewGuid();
        Name = name;
        ReleaseDate = releaseDate;
        Available = available;
        Director = director;
    }

    public static Movie Create(string name, DateTime releaseDate, bool available, string director)
    {
        return new Movie(name, releaseDate, available, director);
    }
}