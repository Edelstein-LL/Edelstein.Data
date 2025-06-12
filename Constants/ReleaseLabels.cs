using Edelstein.Data.Msts;

using System.Collections.Frozen;
using System.Diagnostics.CodeAnalysis;

namespace Edelstein.Data.Constants;

public static class ReleaseLabels
{
    private static FrozenDictionary<uint, ReleaseLabelMst>? _releaseLabels;

    public static bool TryGet(uint id, [NotNullWhen(true)] out ReleaseLabelMst? releaseLabel)
    {
        releaseLabel = null;

        return _releaseLabels is not null && _releaseLabels.TryGetValue(id, out releaseLabel);
    }

    public static bool IsOpen(uint id, DateTimeOffset currentDateTimeOffset) =>
        TryGet(id, out ReleaseLabelMst? mst) && mst.IsOpen(currentDateTimeOffset);

    public static void Load(IEnumerable<ReleaseLabelMst> releaseLabelMsts)
    {
        if (_releaseLabels != null)
            throw new Exception("Ids can only be set one time");

        _releaseLabels = releaseLabelMsts.ToFrozenDictionary(x => x.Id, x => x);
    }
}
