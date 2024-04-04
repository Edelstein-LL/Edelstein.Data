namespace Edelstein.Data.Models.Components;

public class Deck
{
    public byte Slot { get; set; }
    public int LeaderRole { get; set; }
    public List<ulong> MainCardIds { get; set; } = [];
}
