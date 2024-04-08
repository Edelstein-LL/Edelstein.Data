using MongoDB.Bson.Serialization.Attributes;

namespace Edelstein.Data.Models;

public class UserInitializationData
{
    [BsonId]
    public ulong Xuid { get; set; }

    public uint FavoriteCharacterMasterId { get; set; }
    public uint FavoriteCharacterMasterCardId { get; set; }
    public ulong FavoriteCharacterCardId { get; set; }
}
