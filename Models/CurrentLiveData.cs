using Edelstein.Data.Msts;

namespace Edelstein.Data.Models;

public class CurrentLiveData
{
    public uint MasterLiveId { get; set; }
    public LiveLevel Level { get; set; }
    public uint DeckSlot { get; set; }
    public byte LiveBoost { get; set; }
    public byte AutoPlay { get; set; }
    public uint MasterEventId { get; set; }
    public byte IsOmakase { get; set; }
}
