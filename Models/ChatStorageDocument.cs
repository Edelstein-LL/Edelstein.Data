namespace Edelstein.Data.Models;

public class ChatStorageDocument
{
    public List<ChatProgressDocument> Chats { get; set; } = [];
    public List<uint> ChatRoomIds { get; set; } = [];
}
