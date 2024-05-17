using Edelstein.Data.Models.Components;

using MongoDB.Bson.Serialization.Attributes;

namespace Edelstein.Data.Models;

public class UserHomeDocument
{
    [BsonId]
    public ulong Xuid { get; set; }

    public List<PresetData> Presets { get; set; } =
    [
        new PresetData { Slot = 1 },
        new PresetData { Slot = 2 },
        new PresetData { Slot = 3 },
        new PresetData { Slot = 4 }
    ];

    public bool HasUnreadAnnouncements { get; set; } = false;

    public ChatStorageDocument ChatStorage { get; set; } = new();
}
