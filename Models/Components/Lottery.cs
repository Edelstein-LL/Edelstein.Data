namespace Edelstein.Data.Models.Components;

public class Lottery
{
    public uint MasterLotteryId { get; set; }
    public uint MasterLotteryPriceNumber { get; set; }
    public int Count { get; set; }
    public int DailyCount { get; set; }
    public string LastCountDate { get; set; } = "";
}
