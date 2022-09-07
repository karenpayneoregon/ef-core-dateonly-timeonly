# About

Test/examples for the following extension methods located in `TimeClassLibrary`


```csharp
namespace TimeClassLibrary;

public static class Extensions
{
    /// <summary>
    /// Is end time prior to start time
    /// </summary>
    public static bool IsValidEndTime(this TimeOnly endTimeOnly, TimeOnly starTimeOnly) => endTimeOnly.Hour < starTimeOnly.Hour;
    /// <summary>
    /// Is start time after end time
    /// </summary>
    public static bool IsValidStartTime(this TimeOnly starTimeOnly, TimeOnly endTimeOnly)
        => endTimeOnly.Hour > starTimeOnly.Hour;

    /// <summary>
    /// Determine if TimeOnly is before another TimeOnly
    /// </summary>
    public static bool IsLessThan(this TimeOnly endTimeOnly, TimeOnly starTimeOnly) => endTimeOnly.CompareTo(starTimeOnly) < 0;
    /// <summary>
    /// Determine if TimeOnly is after another TimeOnly
    /// </summary>
    public static bool IsGreaterThan(this TimeOnly endTimeOnly, TimeOnly starTimeOnly) => endTimeOnly.CompareTo(starTimeOnly) > 0;
    /// <summary>
    /// Determine if TimeOnly is the same as another TimeOnly
    /// </summary>
    public static bool AreSame(this TimeOnly endTimeOnly, TimeOnly starTimeOnly) => endTimeOnly.CompareTo(starTimeOnly) == 0;
}
```