namespace VisitorsConsoleApp.Extensions;

internal static class DeconstructExtensions
{
    public static void Deconstruct(this DateOnly date, out int day, out int month, out int year) =>
        (day, month, year) = (date.Day, date.Month, date.Year);


    public static void Deconstruct(this TimeOnly sender, out int hour, out int minutes, out int seconds, out int millisecond) =>
        (hour, minutes, seconds, millisecond) = (sender.Hour, sender.Minute, sender.Second, sender.Millisecond);

    public static void Deconstruct(this TimeOnly sender, out int hour, out int minutes) =>
        (hour, minutes) = (sender.Hour, sender.Minute);
}