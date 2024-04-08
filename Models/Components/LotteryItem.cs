namespace Edelstein.Data.Models.Components;

public class LotteryItem
{
    public uint MasterLotteryItemId { get; set; }
    public uint MasterLotteryItemNumber { get; set; }
    public byte IsNew { get; set; }
    public ExchangeItem? ExchangeItem { get; set; }
}
