using Edelstein.Data.Models.Components;

namespace Edelstein.Data.Models;

public record LotteryDrawResult(
    LotteryDrawResultStatus Status,
    List<LotteryItem> LotteryItems,
    UpdatedValueList Updates
);
