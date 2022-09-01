# About

This class provide provides two converters, one to convert time from SQL-Server to [TimeOnly](https://docs.microsoft.com/en-us/dotnet/api/system.timeonly?view=net-6.0) and the second, convert date from SQL-Server to [DateOnly](https://docs.microsoft.com/en-us/dotnet/api/system.dateonly?view=net-6.0) for use with EF Core 6 or higher.

To use in your projects simple copy this project into your solution and reference it in the project performing EF Core operations.

Add the following method to your DbContext then adjust properties in a model for DateOnly from DateTime to DateOnly, usually for time the type is TimeSpan so nothing needs to change for TimeOnly other than the configuration below.


```csharp
protected override void ConfigureConventions(ModelConfigurationBuilder builder)
{

    builder.Properties<DateOnly>()
        .HaveConversion<DateOnlyConverter>()
        .HaveColumnType("date");

    builder.Properties<TimeOnly>()
        .HaveConversion<TimeOnlyConverter>()
        .HaveColumnType("time");

    base.ConfigureConventions(builder);

}
```