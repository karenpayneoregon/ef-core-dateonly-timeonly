using TimeOnlyCore7App.Classes;

namespace TimeOnlyCore7App
{
    internal partial class Program
    {
        static async Task Main(string[] args)
        {

            TimeOnly timeOnly1 = new TimeOnly();
            AnsiConsole.MarkupLine($"12 AM [cyan]{timeOnly1}[/]");

            Console.WriteLine();

            TimeOnly timeOnly2 = new TimeOnly(13,15,10,20,30);
            AnsiConsole.MarkupLine($"{timeOnly2.ToShortTimeString()}");
            AnsiConsole.MarkupLine($"{timeOnly2.ToLongTimeString()}");
            AnsiConsole.MarkupLine($"{timeOnly2.ToString(@"hh\:mm\:ss\.ff")}");

            Console.WriteLine();

            var ts = timeOnly2.ToTimeSpan();

            AnsiConsole.MarkupLine($"As [b]TimeSpan[/] [cyan]{ts.ToString()}[/]");
            AnsiConsole.MarkupLine($"As [b]TimeSpan[/] [cyan]{ts:g}[/]");
            Console.WriteLine();

            await DataOperations.Read();
            Console.ReadLine();
        }
    }
}