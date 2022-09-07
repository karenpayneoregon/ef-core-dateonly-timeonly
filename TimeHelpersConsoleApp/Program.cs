using TimeClassLibrary;
using TimeHelpersConsoleApp.Classes;

namespace TimeHelpersConsoleApp
{
    internal partial class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine();

            GreaterThan_LesserThan();
            //IsBetween();

            Console.ReadLine();
        }

        /// <summary>
        /// How to determine if a TimeOnly falls between two other TimeOnly variables
        /// </summary>
        private static void IsBetween()
        {

            TimeOnly timeOnly1 = new(14, 0, 0);
            TimeOnly timeOnly2 = new(15, 0, 0);
            TimeOnly timeOnly3 = new(16, 0, 0);

            if (timeOnly2.IsBetween(timeOnly1, timeOnly3))
            {
                AnsiConsole.MarkupLine($"[b]{timeOnly2}[/] [chartreuse1]is between[/] [b]{timeOnly1}[/] [chartreuse1]and[/] [b]{timeOnly3}[/]");
            }
            else
            {
                AnsiConsole.MarkupLine($"[b]{timeOnly2}[/] [red]is not between[/] [b]{timeOnly1}[/] [chartreuse1]and[/] [b]{timeOnly3}[/]");
            }

        }

        /// <summary>
        /// How to determine if TimeOnly is
        ///   Less than another TimeOnly
        ///   Greater than another TimeOnly
        ///   Equal to another TimeOnly
        /// </summary>
        private static void GreaterThan_LesserThan()
        {

            TimeOnly timeOnly1 = new(14, 0, 0);
            TimeOnly timeOnly2 = new(13, 0, 0);


            AnsiConsole.MarkupLine($"[white]timeOnly2.IsValidEndTime(timeOnly1)[/] {timeOnly2.IsValidEndTime(timeOnly1).ToYesNoString()}");
            AnsiConsole.MarkupLine($"[white]    timeOnly2.IsLessThan(timeOnly1)[/] {timeOnly2.IsLessThan(timeOnly1).ToYesNoString()}");
            AnsiConsole.MarkupLine($"[white] timeOnly2.IsGreaterThan(timeOnly1)[/] {timeOnly2.IsGreaterThan(timeOnly1).ToYesNoString()}");


            AnsiConsole.MarkupLine($"[white]       timeOnly2.AreSame(timeOnly1)[/] {timeOnly2.AreSame(timeOnly1).ToYesNoString()}");
            timeOnly2 = new(14, 0, 0);
            AnsiConsole.MarkupLine($"[white]       timeOnly2.AreSame(timeOnly1)[/] {timeOnly2.AreSame(timeOnly1).ToYesNoString()}");


        }
    }
}