using MongoDB.Bson.Serialization.Attributes;

using System.Text.Json.Serialization;

namespace Edelstein.Data.Models;

public class UserHomeDocument
{
    [BsonId]
    [JsonIgnore]
    public ulong Xuid { get; set; }
    public required Home Home { get; set; }
    public List<int> ClearMissionIds { get; set; } = [];
}
