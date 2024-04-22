using Edelstein.Data.Msts;

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
    [JsonIgnore]
    public List<LimitedReward> LimitedRewards { get; set; } = [];
}
