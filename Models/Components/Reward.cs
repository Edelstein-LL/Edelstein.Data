using Edelstein.Data.Msts;

namespace Edelstein.Data.Models.Components;

public class Reward
{
    public RewardType Type { get; set; }
    public uint Value { get; set; }
    public int Level { get; set; }
    public int Amount { get; set; }
    public ExchangeItem? ExchangeItem { get; set; }
    public DropInfo? DropInfo { get; set; }
    public GiveType GiveType { get; set; }
}
