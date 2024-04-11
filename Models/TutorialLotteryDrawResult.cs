using Edelstein.Data.Models.Components;

namespace Edelstein.Data.Models;

public record TutorialLotteryDrawResult(
    List<LotteryItem> LotteryItems,
    List<Card> Cards,
    int Lightsticks,
    uint FavoriteCardMasterId,
    ulong FavoriteCardId
) : LotteryDrawResult(LotteryItems, Cards, Lightsticks);
