namespace Edelstein.Data.Models.Components;

public class LotteryItem
{
    public uint MasterLotteryItemId { get; set; }
    public uint MasterLotteryItemNumber { get; set; }
    public bool IsNew { get; set; }
    public ExchangeItem? ExchangeItem { get; set; }
}
