namespace Edelstein.Data.Models.Components;

public class StarEventData
{
    public uint StarLevel { get; set; }
    public uint LastEventStarLevel { get; set; }
    public List<StarEventMusicData> StarMusicList { get; set; } = [];
    public uint IsStarEventUpdate { get; set; }
    public uint IsInheritedLevelReward { get; set; }
    public uint MusicChangeCount { get; set; }
    public uint StarEventBonusCount { get; set; }
    public uint StarEventBonusDailyCount { get; set; }
    public uint StarEventPlayTimesBonusCount { get; set; }
    public uint StarAssistBonus { get; set; }
}
