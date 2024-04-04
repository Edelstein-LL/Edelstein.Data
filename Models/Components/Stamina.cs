using System.Text.Json.Serialization;

namespace Edelstein.Data.Models.Components;

public class Stamina
{
    [JsonPropertyName("stamina")]
    public int StaminaValue { get; set; }

    public long LastUpdatedTime { get; set; }
}
