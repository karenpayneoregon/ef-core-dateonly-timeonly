using System.Diagnostics;

namespace TimeHelpersConsoleApp.Classes
{
    internal static class HelperExtensions
    {
        [DebuggerStepThrough]
        public static string ToYesNoString(this bool value) => (value ? "[cyan]Yes[/]" : "[red]No[/]");
    }
}
