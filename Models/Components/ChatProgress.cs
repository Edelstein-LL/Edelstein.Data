namespace Edelstein.Data.Models.Components;

public class ChatProgress
{
    public uint ChatId { get; set; }
    public uint RoomId { get; set; }
    public uint ChapterId { get; set; }
    public bool IsRead { get; set; }
    public ulong CreatedAt { get; set; }
}
