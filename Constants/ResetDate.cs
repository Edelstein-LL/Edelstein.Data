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

    public static DateTimeOffset Previous
    {
        get
        {
            DateTimeOffset currentTime = DateTimeOffset.UtcNow;
            return PreviousOf(currentTime);
        }
    }

    public static DateTimeOffset NextOf(DateTimeOffset dateTimeOffset) =>
        new DateTimeOffset(dateTimeOffset.Year, dateTimeOffset.Month, dateTimeOffset.Day, 0, 0,
            0, TimeSpan.Zero).AddDays(1);

    public static DateTimeOffset PreviousOf(DateTimeOffset dateTimeOffset) =>
        new(dateTimeOffset.Year, dateTimeOffset.Month, dateTimeOffset.Day, 0, 0,
            0, TimeSpan.Zero);
}
