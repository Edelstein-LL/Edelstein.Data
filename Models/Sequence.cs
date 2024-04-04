using System.Numerics;

namespace Edelstein.Data.Models;

public class Sequence<T>
    where T : IBinaryInteger<T>
{
    public required string Id { get; set; }
    public required T CurrentValue { get; set; }
}
