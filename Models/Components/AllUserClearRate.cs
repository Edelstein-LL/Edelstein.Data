namespace Edelstein.Data.Models.Components;

public class AllUserClearRate
{
    public uint MasterLiveId { get; set; }
    public required string Normal { get; set; }
    public required string Hard { get; set; }
    public required string Expert { get; set; }
    public required string Master { get; set; }
}
