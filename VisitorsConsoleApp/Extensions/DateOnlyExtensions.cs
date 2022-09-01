namespace VisitorsConsoleApp.Extensions;

internal static class DateOnlyExtensions
{


    /// <summary>
    /// Format with MM/dd/yy
    /// </summary>
    public static string Formatted(this DateOnly sender) => sender.ToString("MM/dd/yy");

    public static TimeOnly ToTimeOnlyNullable(this TimeSpan? sender) =>
        sender.HasValue ?
            new TimeOnly(sender.Value.Hours, sender.Value.Minutes) :
            new TimeOnly(0, 0);

    /// <summary>
    /// Create a new <see cref="DateTime"/> from a <see cref="DateOnly"/> without creating
    /// the <see cref="TimeOnly"/> in implementation 
    /// </summary>
    /// <param name="sender">DateOnly</param>
    /// <param name="hour">Hour to set for result DateTime</param>
    /// <param name="minutes">Minutes to set for result DateTime</param>
    /// <returns></returns>
    public static DateTime ToDateTime(this DateOnly sender, int hour = 0, int minutes = 0)
        => sender.ToDateTime(new TimeOnly(hour, minutes));

    public static DateOnly ToDateOnly(this DateTime? sender)
        => new(sender!.Value.Year, sender.Value.Month, sender.Value.Day);


}