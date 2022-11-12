using Microsoft.Data.SqlClient;
using ConfigurationLibrary.Classes;
using TimeOnlyCore7App.ExtensionMethods;

namespace TimeOnlyCore7App.Classes;

internal class DataOperations
{
    /// <summary>
    /// Example for reading <see cref="DateOnly"/> and <see cref="TimeOnly"/> with <see cref="SqlDataReader"/>
    /// </summary>
    /// <returns></returns>
    public static async Task Read()
    {
        Helpers.PrintSampleName();
        var statement =
            "SELECT L.VistorLogIdentifier, L.VisitorIdentifier, L.VisitOn, L.EnteredTime, L.ExitedTime,  V.FirstName + ' ' + V.LastName Fullname " + 
            "FROM dbo.VisitorLog AS L INNER JOIN dbo.Visitor AS V ON L.VisitorIdentifier = V.VisitorIdentifier;";

        await using var cn = new SqlConnection(ConfigurationHelper.ConnectionString());
        await using var cmd = new SqlCommand { Connection = cn, CommandText = statement };

        await cn.OpenAsync();
        await using var reader = await cmd.ExecuteReaderAsync();

        var table = CreateTable();

        while (reader.Read())
        {
            // has TimeOnly formatted and unformatted for demonstration purpose
            table.AddRow(
                reader.GetInt32(0).ToString(),
                reader.GetInt32(1).ToString(),
                reader.GetDateOnlyFormatted(2), 
                reader.GetTimeOnly(3).ToString(),
                reader.GetTimeOnlyFormatted(4),
                reader.GetString(5)
            );
        }

        AnsiConsole.Write(table);
    }

    private static Table CreateTable()
    {
        var table = new Table()
            .RoundedBorder()
            .AddColumn("[b]Log Id[/]")
            .AddColumn("[b]Visit Id[/]")
            .AddColumn("[b]Visit on[/]")
            .AddColumn("[b]Entered time[/]")
            .AddColumn("[b]Exit time[/]")
            .AddColumn("[b]Name[/]")
            .Alignment(Justify.Center)
            .BorderColor(Color.LightSlateGrey)
            .Title("[LightGreen]Log with DateOnly and TimeOnly[/]");
        return table;
    }
}