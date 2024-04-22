namespace Edelstein.Data.Constants;

public static class ResetDate
{
    public static DateTimeOffset Next
    {
        get
        {
            DateTimeOffset currentTime = DateTimeOffset.UtcNow;
            return NextOf(currentTime);
        }
    }

    public static DateTimeOffset Last
    {
        get
        {
            DateTimeOffset currentTime = DateTimeOffset.UtcNow;
            return LastOf(currentTime);
        }
    }

    public static DateTimeOffset NextOf(DateTimeOffset dateTimeOffset) =>
        new DateTimeOffset(dateTimeOffset.Year, dateTimeOffset.Month, dateTimeOffset.Day, 0, 0,
            0, TimeSpan.Zero).AddDays(1);

    public static DateTimeOffset LastOf(DateTimeOffset dateTimeOffset) =>
        new(dateTimeOffset.Year, dateTimeOffset.Month, dateTimeOffset.Day, 0, 0,
            0, TimeSpan.Zero);
}
