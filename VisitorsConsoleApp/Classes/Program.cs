using System.Runtime.CompilerServices;

// ReSharper disable once CheckNamespace
namespace VisitorsConsoleApp
{
    internal partial class Program
    {
        [ModuleInitializer]
        public static void Init()
        {
            AnsiConsole.MarkupLine("");
            Console.Title = "Code sample: TimeOnly with DateOnly";
            WindowUtility.SetConsoleWindowPosition(WindowUtility.AnchorWindow.Center);
        }

        private static Table CreateViewTable() =>
            new Table()
                .Border(TableBorder.Square)
                .BorderColor(Color.Cornsilk1)
                .Centered()
                .AddColumn(new TableColumn("First"))
                .AddColumn(new TableColumn("Last"))
                .AddColumn(new TableColumn("Visited"))
                .AddColumn(new TableColumn("Came at"))
                .AddColumn(new TableColumn("Left at"))
                .AddColumn(new TableColumn("Spent"));
    }
}
