namespace Edelstein.Data.Models.Components;

public class Story
{
    public uint MasterStoryId { get; set; }
    public List<uint> MasterStoryPartIds { get; set; } = [];
}
