namespace Edelstein.Data.Models.Components;

public class LiveDataSummary
{
    public List<int> ClearCountList { get; set; } = [];
    public List<int> FullComboList { get; set; } = [];
    public List<int> AllPerfectList { get; set; } = [];
    public required HighScoreRate HighScoreRate { get; set; }
}
