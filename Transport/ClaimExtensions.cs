using System.Globalization;
using System.Security.Claims;

namespace Edelstein.Data.Transport;

public static class ClaimExtensions
{
    public static T? As<T>(this Claim? claim)
        where T : IParsable<T>
    {
        T.TryParse(claim?.Value, CultureInfo.InvariantCulture, out T? value);
        return value;
    }
}
