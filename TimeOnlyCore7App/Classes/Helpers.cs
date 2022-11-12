using System.Runtime.CompilerServices;

namespace TimeOnlyCore7App.Classes;

public class Helpers
{
    public static void PrintSampleName([CallerMemberName] string? methodName = null)
    {
        AnsiConsole.MarkupLine($"[cyan]>>>> Sample:[/] [white]{methodName}[/]");
        Console.WriteLine();
    }
}