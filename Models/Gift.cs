using Edelstein.Data.Msts;

using System.Text.Json.Serialization;

namespace Edelstein.Data.Models;

public class Gift
{
    public ulong Id { get; set; }

    [JsonIgnore]
    public ulong UserId { get; set; }

    public bool IsReceive { get; set; }
    public required string ReasonText { get; set; }
    public RewardType RewardType { get; set; }
    public uint Value { get; set; }
    public int Level { get; set; }
    public int Amount { get; set; }
    public long CreatedDateTime { get; set; }
    public long ExpireDateTime { get; set; }
    public long ReceivedDateTime { get; set; }
}
