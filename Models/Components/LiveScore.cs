namespace Edelstein.Data.Models.Components;

public class LiveScore
{
    public int Hp { get; set; }
    public int Score { get; set; }
    public int Perfect { get; set; }
    public int Great { get; set; }
    public int Good { get; set; }
    public int Bad { get; set; }
    public int Miss { get; set; }
    public int MaxCombo { get; set; }
    public int TotalParam { get; set; }
    public int MultiTotalScore { get; set; }
    public float PlayTime { get; set; }
    public List<SkillLog> SkillLogList { get; set; } = [];
}
