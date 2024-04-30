using MongoDB.Bson.Serialization.Attributes;

namespace Edelstein.Data.Models.Components;

public class User
{
    public ulong Id { get; set; }
    public string? Name { get; set; }
    public string? Comment { get; set; }
    public int Exp { get; set; }
    public int Level { get; set; }
    public uint MainDeckSlot { get; set; }
    public uint FavoriteMasterCardId { get; set; }
    public byte FavoriteCardEvolve { get; set; }
    public uint GuestSmileMasterCardId { get; set; }
    public uint GuestCoolMasterCardId { get; set; }
    public uint GuestPureMasterCardId { get; set; }

    [BsonIgnore]
    public bool FriendRequestDisabled => !ProfileSettings.Contains(ProfileType.FriendRequest);

    public List<uint> MasterTitleIds { get; set; } = [];
    public List<ProfileType> ProfileSettings { get; set; } = [];
    public long LastLoginTime { get; set; }
    public ulong SifUserId { get; set; }
    public ulong SsUserId { get; set; }
    public string Birthday { get; set; } = "";
}
