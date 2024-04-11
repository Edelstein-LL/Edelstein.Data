using Edelstein.Data.Models.Components;

namespace Edelstein.Data.Models;

public record LotteryDrawResult(
    List<LotteryItem> LotteryItems,
    List<Card> Cards,
    int Lightsticks
);
