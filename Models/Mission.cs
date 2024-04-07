using Edelstein.Data.Models.Components;

namespace Edelstein.Data.Models;

public class Mission
{
    public uint MasterMissionId { get; set; }
    public MissionStatus Status { get; set; }
    public int Progress { get; set; }
    public long ExpireDateTime { get; set; }
    public byte NotVisible { get; set; }
}
