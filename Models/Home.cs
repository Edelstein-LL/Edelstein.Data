using Edelstein.Data.Models.Components;

namespace Edelstein.Data.Models;

public class Home
{
    public IEnumerable<Gift> GiftList { get; set; } = [];
    public int PendingFriendCount { get; set; }
    public int ClearMissionCount { get; set; }
    public int ClearBeginnerMissionCount { get; set; }
    public bool BeginnerMissionComplete { get; set; }
    public bool NewAnnouncementFlag { get; set; }
    public List<Information> InformationList { get; set; } = [];
    public List<PresetData> PresetSetting { get; set; } = [];
    public int NotClearedDailyMissionCount { get; set; }
    public int UnreadStoryCount { get; set; }
    public int UnreadChatCount { get; set; }
    public byte ActiveFriend { get; set; }
    public List<uint> SerialCodeIdList { get; set; } = [];
}
