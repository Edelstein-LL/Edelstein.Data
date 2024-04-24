namespace Edelstein.Data.Models.Components;

public class LiveReward
{
    public uint MasterLiveClearRewardId { get; set; }
    public Msts.RewardType Type { get; set; }
    public uint Value { get; set; }
    public int Amount { get; set; }
    public int GetableCount { get; set; }
    public int ReceivedCount { get; set; }
}
