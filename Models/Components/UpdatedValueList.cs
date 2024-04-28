namespace Edelstein.Data.Models.Components;

public class UpdatedValueList
{
    public Gem? Gem { get; set; } = null;
    public List<Card> CardList { get; set; } = [];
    public List<CardSub> CardSubList { get; set; } = [];
    public List<Item> ItemList { get; set; } = [];
    public List<Point> PointList { get; set; } = [];
    public HashSet<uint> MasterTitleIds { get; set; } = [];
    public List<uint> MasterMusicIds { get; set; } = [];
    public HashSet<uint> MasterStampIds { get; set; } = [];
    public List<EventPoint> EventPointList { get; set; } = [];
    public Stamina? Stamina { get; set; } = null;
    public List<uint> MasterMovieIds { get; set; } = [];
}
