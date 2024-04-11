namespace Edelstein.Data.Models.Components;

public class UserDetail
{
    public required User User { get; set; }
    public required Card FavoriteCard { get; set; }
    public required Card GuestSmileCard { get; set; }
    public required Card GuestCoolCard { get; set; }
    public required Card GuestPureCard { get; set; }
    public List<Group> GroupList { get; set; } = [];
    public required DeckDetail MainDeckDetail { get; set; }
    public required LiveDataSummary LiveDataSummary { get; set; }
    public List<uint> MasterTitleIds { get; set; } = [];
}
