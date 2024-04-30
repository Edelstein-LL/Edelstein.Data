using Edelstein.Data.Msts;

namespace Edelstein.Data.Models.Components;

public class LiveReward
{
    public uint MasterLiveClearRewardId { get; set; }
    public RewardType Type { get; set; }
    public uint Value { get; set; }
    public int Amount { get; set; }
    public int GetableCount { get; set; }
    public int ReceivedCount { get; set; }
}
