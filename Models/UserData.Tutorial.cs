using Edelstein.Data.Models.Components;

namespace Edelstein.Data.Models;

public partial class UserData
{
    public static UserData CreateTutorialUserData(ulong xuid)
    {
        long currentUnixTimeSeconds = DateTimeOffset.UtcNow.ToUnixTimeSeconds();

        return new UserData
        {
            User = new User
            {
                Id = xuid,
                Name = "チュートリアル中",
                Comment = "よろしくお願いします！",
                MainDeckSlot = 1,
                FriendRequestDisabled = true,
                MasterTitleIds = [0, 0],
                ProfileSettings = [1, 2, 3, 4, 5, 6, 7],
                LastLoginTime = currentUnixTimeSeconds
            },
            Gem = new Gem(),
            DeckList =
            [
                new Deck
                {
                    Slot = 1,
                    MainCardIds = [0, 0, 0, 0, 0, 0, 0, 0, 0]
                },
                new Deck
                {
                    Slot = 2,
                    MainCardIds = [0, 0, 0, 0, 0, 0, 0, 0, 0]
                },
                new Deck
                {
                    Slot = 3,
                    MainCardIds = [0, 0, 0, 0, 0, 0, 0, 0, 0]
                },
                new Deck
                {
                    Slot = 4,
                    MainCardIds = [0, 0, 0, 0, 0, 0, 0, 0, 0]
                },
                new Deck
                {
                    Slot = 5,
                    MainCardIds = [0, 0, 0, 0, 0, 0, 0, 0, 0]
                },
                new Deck
                {
                    Slot = 6,
                    MainCardIds = [0, 0, 0, 0, 0, 0, 0, 0, 0]
                },
                new Deck
                {
                    Slot = 7,
                    MainCardIds = [0, 0, 0, 0, 0, 0, 0, 0, 0]
                },
                new Deck
                {
                    Slot = 8,
                    MainCardIds = [0, 0, 0, 0, 0, 0, 0, 0, 0]
                },
                new Deck
                {
                    Slot = 9,
                    MainCardIds = [0, 0, 0, 0, 0, 0, 0, 0, 0]
                },
                new Deck
                {
                    Slot = 10,
                    MainCardIds = [0, 0, 0, 0, 0, 0, 0, 0, 0]
                },
                new Deck
                {
                    Slot = 100,
                    MainCardIds = [0, 0, 0, 0, 0, 0, 0, 0, 0]
                }
            ],
            Stamina = new Stamina
            {
                StaminaValue = 100,
                LastUpdatedTime = currentUnixTimeSeconds
            },
            MasterMusicIds = Constants.MasterMusicIds.Get().ToList(),
            Movie = (Movie?)null
        };
    }
}
