using System.Text.RegularExpressions;

namespace Edelstein.Data.Serialization;

public static partial class SlashDelimitedListParser
{
    public static bool TryParse<T>(string input, out List<T> list)
        where T : IParsable<T>
    {
        list = [];

        if (!input.StartsWith('[') || !input.EndsWith(']'))
            return false;

        MatchCollection matches = ListItemRegex().Matches(input);

        bool fullSuccess = true;

        foreach (Match match in matches)
        {
            if (T.TryParse(match.Value, null, out T? item))
                list.Add(item);
            else
                fullSuccess = false;
        }

        return fullSuccess;
    }

    [GeneratedRegex(@"[^\/\[\]]+")]
    private static partial Regex ListItemRegex();
}
