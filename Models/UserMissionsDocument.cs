using MongoDB.Bson.Serialization.Attributes;

namespace Edelstein.Data.Models;

public class UserMissionsDocument
{
    [BsonId]
    public ulong Xuid { get; set; }
    public List<Mission> Missions { get; set; } = [];
}
