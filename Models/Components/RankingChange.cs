namespace Edelstein.Data.Models.Components;

public class RankingChange
{
    public int Score { get; set; }
    public uint OldGroupRank { get; set; }
    public uint NewGroupRank { get; set; }
    public uint OldAllRank { get; set; }
    public uint NewAllRank { get; set; }
    public List<RankingDetail> NewGroupUserDetailList { get; set; } = [];
    public List<RankingDetail> NewAllUserDetailList { get; set; } = [];
}
