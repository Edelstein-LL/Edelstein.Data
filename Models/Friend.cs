using Edelstein.Data.Models.Components;

namespace Edelstein.Data.Models;

public partial class Friend
{
    public required User User { get; set; }
    public required Card FavoriteCard { get; set; }
    public required Card GuestSmileCard { get; set; }
    public required Card GuestCoolCard { get; set; }
    public required Card GuestPureCard { get; set; }
    public FriendStatus Status { get; set; }
}
