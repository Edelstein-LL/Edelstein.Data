using Edelstein.Data.Models.Components;
using Edelstein.Data.Serialization.Json;

using System.Text.Json.Serialization;

namespace Edelstein.Data.Models;

public class Home
{
    public IAsyncEnumerable<Gift> GiftList { get; set; } = AsyncEnumerable.Empty<Gift>();
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

[JsonSourceGenerationOptions(Converters = [typeof(BooleanToIntegerJsonConverter), typeof(OneOfListOrObjectJsonConverterFactory)],
    PropertyNamingPolicy = JsonKnownNamingPolicy.SnakeCaseLower)]
[JsonSerializable(typeof(Home))]
public partial class HomeJsonSerializerContext : JsonSerializerContext;
