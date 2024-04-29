using Edelstein.Data.Models.Components;

namespace Edelstein.Data.Models;

public partial class Friend
{
    public static Friend GetTutorial() =>
        new()
        {
            User = new User
            {
                Name = "素敵なゲストさん",
                Comment = "初めてのライブ楽しんでね！",
                Exp = 900,
                MainDeckSlot = 1,
                FavoriteMasterCardId = 10010013,
                GuestSmileMasterCardId = 10010013,
                GuestCoolMasterCardId = 10010013,
                GuestPureMasterCardId = 10010013,
                MasterTitleIds = [3000001, 0],
                LastLoginTime = DateTimeOffset.UtcNow.ToUnixTimeSeconds()
            },
            FavoriteCard = new Card
            {
                MasterCardId = 10010013,
                Exp = 1025
            },
            GuestSmileCard = new Card
            {
                MasterCardId = 10010013,
                Exp = 1025
            },
            GuestCoolCard = new Card
            {
                MasterCardId = 10010013,
                Exp = 1025
            },
            GuestPureCard = new Card
            {
                MasterCardId = 10010013,
                Exp = 1025
            },
            Status = 0
        };
}
