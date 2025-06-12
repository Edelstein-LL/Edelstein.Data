using Edelstein.Data.Msts;

using MongoDB.Bson.Serialization.Attributes;

using System.Text.Json.Serialization;

namespace Edelstein.Data.Models.Components;

public class Live
{
    private Dictionary<uint, int>? _remainingLimitedRewards;

    public uint MasterLiveId { get; set; }
    public LiveLevel Level { get; set; }
    public int ClearCount { get; set; }
    public int HighScore { get; set; }
    public int MaxCombo { get; set; }
    public bool AutoEnable { get; set; }
    public int UpdatedTime { get; set; }

    [JsonIgnore]
    public List<LimitedReward> LimitedRewards { get; set; } = [];

    // TODO: Compatibility stub
    // TODO: Rework to ReceivedLimitedRewards
    [JsonIgnore]
    [BsonIgnore]
    public Dictionary<uint, int> RemainingLimitedRewards
    {
        get
        {
            _remainingLimitedRewards ??= LimitedRewards.ToDictionary(x => x.MasterRewardId, x => x.Remaining);

            return _remainingLimitedRewards;
        }
    }
}
