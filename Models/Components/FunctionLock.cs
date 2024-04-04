namespace Edelstein.Data.Models.Components;

public class FunctionLock
{
    public uint Id { get; set; }
    public byte Platforms { get; set; }
    public int FunctionId { get; set; }
    public uint Value { get; set; }
    public string? StartDate { get; set; }
    public string? EndDate { get; set; }
}
