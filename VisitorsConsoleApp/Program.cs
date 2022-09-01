
using VisitorsConsoleApp.Extensions;

namespace VisitorsConsoleApp;

internal partial class Program
{
    static void Main(string[] args)
    {
        var table = CreateViewTable();

        List<VisitorLog> logs = DataOperations.DescendingLogs();
        foreach (var log in logs)
        {

            table.AddRow(
                log.Navigation.FirstName, 
                log.Navigation.LastName, 
                log.VisitOn!.Value.Formatted(), 
                log.EnteredTime!.Value.Formatted(), 
                log.ExitedTime!.Value.Formatted(),
                log.Spent.ToString());

        }

        AnsiConsole.Write(table);
        Console.WriteLine();
        Console.ReadLine();

    }
}