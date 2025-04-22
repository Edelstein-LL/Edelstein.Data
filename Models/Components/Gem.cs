namespace Edelstein.Data.Models.Components;

public class Gem
{
    public long Total => Charge + Free;
    public long Charge { get; set; }
    public long Free { get; set; }
}
