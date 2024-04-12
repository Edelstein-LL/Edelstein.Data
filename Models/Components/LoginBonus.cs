namespace Edelstein.Data.Models.Components;

public class LoginBonus
{
    public uint MasterLoginBonusId { get; set; }
    public List<int> DayCounts { get; set; } = [];
    public List<LoginBonusEventData> EventBonusList { get; set; } = [];
}
