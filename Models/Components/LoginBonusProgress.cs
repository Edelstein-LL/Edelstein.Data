namespace Edelstein.Data.Models.Components;

public class LoginBonusProgress
{
    public uint MasterLoginBonusId { get; set; }
    public List<int> DayCounts { get; set; } = [];
    public long ReceivedDateTime { get; set; }
    public long ExpireDateTime { get; set; }
}
