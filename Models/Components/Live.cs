using Edelstein.Data.Msts;

using MongoDB.Bson.Serialization.Attributes;

using System.Text.Json.Serialization;

namespace Edelstein.Data.Models.Components;

public class Live
{
    public uint MasterLiveId { get; set; }
    public LiveLevel Level { get; set; }
    public int ClearCount { get; set; }
    public int HighScore { get; set; }
    public int MaxCombo { get; set; }
    public bool AutoEnable { get; set; }
    public int UpdatedTime { get; set; }

    [BsonElement("receivedLimitedRewards")]
    private Dictionary<string, int> ReceivedLimitedRewardsDb
    {
        get => ReceivedLimitedRewards.ToDictionary(x => x.Key.ToString(), x => x.Value);
        set => ReceivedLimitedRewards = value.ToDictionary(x => UInt32.Parse(x.Key), x => x.Value);
    }

    [JsonIgnore]
    [BsonIgnore]
    public Dictionary<uint, int> ReceivedLimitedRewards { get; set; } = [];
}
