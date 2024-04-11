using System.Text.Json.Serialization;

namespace Edelstein.Data.Models.Components;

public class StarEventBonus
{
    [JsonPropertyName("star_event_bonus")]
    public uint StarEventBonusValue { get; set; }

    public uint StarEventBonusScore { get; set; }
    public uint StarPlayTimesBonus { get; set; }
    public uint StarPlayTimesBonusScore { get; set; }
    public uint CardBonus { get; set; }
    public uint CardBonusScore { get; set; }
    public uint StarAssistBonus { get; set; }
    public uint StarAssistBonusScore { get; set; }
}
