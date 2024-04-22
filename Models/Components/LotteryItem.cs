using System.Text.Json.Serialization;

namespace Edelstein.Data.Models.Components;

public class LotteryItem
{
    public uint MasterLotteryItemId { get; set; }
    public uint MasterLotteryItemNumber { get; set; }
    public bool IsNew { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public ExchangeItem? ExchangeItem { get; set; }
}
