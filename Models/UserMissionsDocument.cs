using MongoDB.Bson.Serialization.Attributes;

using System.Text.Json.Serialization;

namespace Edelstein.Data.Models;

public class UserMissionsDocument
{
    [BsonId]
    [JsonIgnore]
    public ulong Xuid { get; set; }

    public List<Mission> MissionList { get; set; } = [];
}
