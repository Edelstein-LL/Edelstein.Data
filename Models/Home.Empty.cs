using Edelstein.Data.Models.Components;

namespace Edelstein.Data.Models;

public partial class Home
{
    public static Home CreateEmpty() =>
        new()
        {
            NotClearedDailyMissionCount = 6,
            NewAnnouncementFlag = 1,
            UnreadStoryCount = 4,
            PresetSetting =
            [
                new PresetData { Slot = 1 },
                new PresetData { Slot = 2 },
                new PresetData { Slot = 3 },
                new PresetData { Slot = 4 }
            ]
        };
}
