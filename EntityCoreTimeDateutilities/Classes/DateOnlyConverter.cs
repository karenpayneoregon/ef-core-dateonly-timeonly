using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EntityCoreTimeDateUtilities.Classes;

public class DateOnlyConverter : ValueConverter<DateOnly, DateTime>
{
    public DateOnlyConverter() 
        : base(dateOnly => 
                dateOnly.ToDateTime(TimeOnly.MinValue), 
            dateTime => DateOnly.FromDateTime(dateTime)) { }
}