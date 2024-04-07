namespace Edelstein.Data.Models.Components;

public class Gift
{
    public ulong Id { get; set; }
    public byte IsReceive { get; set; }
    public required string ReasonText { get; set; }
    public int RewardType { get; set; }
    public uint Value { get; set; }
    public int Level { get; set; }
    public int Amount { get; set; }
    public long CreatedDateTime { get; set; }
    public long ExpireDateTime { get; set; }
    public long ReceivedDateTime { get; set; }
}