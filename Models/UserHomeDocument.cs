using MongoDB.Bson.Serialization.Attributes;

namespace Edelstein.Data.Models;

public class UserHomeDocument
{
    [BsonId]
    public ulong Xuid { get; set; }

    public required Home Home { get; set; }

    //public List<uint> ClearMissionIds { get; set; } = []; // TODO: Reconsider
    public ChatStorageDocument ChatStorage { get; set; } = new();
}
