using Edelstein.Data.Models.Components;

namespace Edelstein.Data.Models;

public record TutorialLotteryDrawResult(
    List<LotteryItem> LotteryItems,
    List<Card> Cards,
    uint FavoriteCardMasterId,
    ulong FavoriteCardId
) : LotteryDrawResult(LotteryItems, Cards);
