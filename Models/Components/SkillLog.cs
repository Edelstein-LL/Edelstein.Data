namespace Edelstein.Data.Models.Components;

public class SkillLog
{
    public uint MasterCardId { get; set; }
    public int Level { get; set; }
    public List<int> NotesNumRange { get; set; } = [];
}
