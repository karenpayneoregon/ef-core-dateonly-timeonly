namespace TimeClassLibrary;

public static class Extensions
{
    /// <summary>
    /// Is end time prior to start time
    /// </summary>
    public static bool IsValidEndTime(this TimeOnly endTime, TimeOnly startTime) => endTime.Hour < startTime.Hour;


    /// <summary>
    /// Is start time after end time
    /// </summary>
    public static bool IsValidStartTime(this TimeOnly startTime, TimeOnly endTime)
        => endTime.Hour > startTime.Hour;


    /// <summary>
    /// Determine if TimeOnly is before another TimeOnly
    /// </summary>
    public static bool IsLessThan(this TimeOnly endTimeOnly, TimeOnly startTime) => endTimeOnly.CompareTo(startTime) < 0;


    public static bool IsLessThan<T>(this T sender, T compareTo) where T : IComparable<T> => compareTo.CompareTo(sender) < 0;

    /// <summary>
    /// Determine if TimeOnly is after another TimeOnly
    /// </summary>
    public static bool IsGreaterThan(this TimeOnly endTime, TimeOnly startTime) => endTime.CompareTo(startTime) > 0;


    public static bool IsGreaterThan<T>(this T sender, T compareTo) where T : IComparable => sender.CompareTo(compareTo) > 0;


    /// <summary>
    /// Determine if TimeOnly is the same as another TimeOnly
    /// </summary>
    public static bool AreSame(this TimeOnly endTimeOnly, TimeOnly startTimeOnly) => endTimeOnly.CompareTo(startTimeOnly) == 0;


    /// <summary>
    /// Get time between two TimeOnly as a TimeSpan
    /// </summary>
    /// <remarks>
    /// Sure this code can be circumvented but using an extension the name provides clarity
    /// </remarks>
    public static TimeSpan Duration(this TimeOnly endTimeOnly, TimeOnly starTimeOnly) => endTimeOnly - starTimeOnly;


}