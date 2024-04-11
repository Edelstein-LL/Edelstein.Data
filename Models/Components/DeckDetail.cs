namespace Edelstein.Data.Models.Components;

public class DeckDetail
{
    public int TotalPower { get; set; }
    public required Deck Deck { get; set; }
    public List<Card> CardList { get; set; } = [];
}
