namespace Edelstein.Data.Models.Components;

public class Movie
{
    public List<uint> MasterMovieIds { get; set; } = [];
    public uint HomeMasterMovieId { get; set; }
}
