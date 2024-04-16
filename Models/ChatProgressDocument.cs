using Edelstein.Data.Models.Components;

namespace Edelstein.Data.Models;

public class ChatProgressDocument
{
    public required ChatProgress ChatProgress { get; set; }
    public List<string> SelectTalkIdList { get; set; } = [];
    public List<uint> GetItemList { get; set; } = [];
}
