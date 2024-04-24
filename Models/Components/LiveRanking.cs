namespace Edelstein.Data.Models.Components;

public class LiveRanking
{
    public int Rank { get; set; }
    public int Score { get; set; }
    public required User User { get; set; }
    public required Card FavoriteCard { get; set; }
    public required Card GuestSmileCard { get; set; }
    public required Card GuestCoolCard { get; set; }
    public required Card GuestPureCard { get; set; }
}
