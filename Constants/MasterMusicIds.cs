using System.Collections.Frozen;

namespace Edelstein.Data.Constants;

public static class MasterMusicIds
{
    private static FrozenSet<uint>? _ids;

    public static IEnumerable<uint> Get() =>
        _ids ?? FrozenSet<uint>.Empty;

    public static void Load(IEnumerable<uint> ids)
    {
        if (_ids != null)
            throw new Exception("Ids can only be set one time");

        _ids = ids.ToFrozenSet();
    }
}
