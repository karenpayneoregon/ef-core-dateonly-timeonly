using Microsoft.EntityFrameworkCore;
using VisitorsLibrary.Data;

namespace VisitorsConsoleApp.Classes;

internal class DataOperations
{
    public static List<VisitorLog> DescendingLogs()
    {
        using var context = new VisitorContext();
        return context.VisitorLog
            .Include(x => x.Navigation)
            .OrderByDescending(x => x.VisitOn!.Value)
            .ToList();
    }
}