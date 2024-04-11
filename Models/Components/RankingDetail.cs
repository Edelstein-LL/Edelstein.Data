namespace Edelstein.Data.Models.Components;

public class RankingDetail
{
    public uint Rank { get; set; }
    public required UserDetail UserDetail { get; set; }
    public int Score { get; set; }
    public List<ScoreDetail> ScoreDetailList { get; set; } = [];
    public int StarLevel { get; set; }
}
