namespace Edelstein.Data.Models.Components;

public class HighScoreRate
{
    public int Rate { get; set; }
    public required List<HighScoreRateDetail> Detail { get; set; }
}
