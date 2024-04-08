using System.Numerics;

namespace Edelstein.Data.Extensions;

public static class EnumerableExtensions
{
    public static IEnumerable<T> Range<T>(T start, T count)
        where T : INumber<T>, IMinMaxValue<T>
    {
        T max = start - T.One + count;

        if (count < T.Zero || max > T.MaxValue)
            throw new ArgumentOutOfRangeException(nameof(count));

        if (count == T.Zero)
            yield break;

        while (start <= max)
        {
            yield return start;
            start++;
        }
    }
}
