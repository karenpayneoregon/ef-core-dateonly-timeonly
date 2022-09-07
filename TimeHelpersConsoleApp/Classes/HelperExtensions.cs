using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeHelpersConsoleApp.Classes
{
    internal static class HelperExtensions
    {
        [DebuggerStepThrough]
        public static string ToYesNoString(this bool value) => (value ? "[cyan]Yes[/]" : "[red]No[/]");
    }
}
