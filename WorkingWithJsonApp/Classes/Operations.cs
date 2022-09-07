#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using WorkingWithJsonApp.Converters;

namespace WorkingWithJsonApp.Classes
{
    public class Operations
    {
        public static List<Container> Containers() =>
            new List<Container>()
            {
                new() {Id = 1, BirthDate = new DateOnly(1956,9,12),  TimeOnly = new TimeOnly(13,35,0)},
                new() {Id = 2,BirthDate = new DateOnly(1966,9,12), TimeOnly = new TimeOnly(14,45,0)},
                new() {Id = 3,BirthDate = new DateOnly(1977,9,12), TimeOnly = new TimeOnly(15,55,0)},
            };


        public static void SerializeDeserialize()
        {

            string fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data.json");

            JsonSerializerOptions JsonSerializerOptions()
            {
                var jsonSerializerOptions = new JsonSerializerOptions(JsonSerializerDefaults.General);

                jsonSerializerOptions.Converters.Add(new DateOnlyConverter());
                jsonSerializerOptions.Converters.Add(new TimeOnlyConverter());
                jsonSerializerOptions.WriteIndented = true;

                return jsonSerializerOptions;

            }

            var list = Containers();

            // setup for to use DateOnlyConverter
            var options = JsonSerializerOptions();


            File.WriteAllText(fileName, JsonSerializer.Serialize(list, options));

            var containers = JsonSerializer.Deserialize<List<Container>>(File.ReadAllText(fileName), options);

            var table = CreateTable();

            foreach (var container in containers!)
            {
                table.AddRow(container.Id.ToString(), container.BirthDate.ToString(), container.TimeOnly.ToString());
            }

            AnsiConsole.Write(table);


        }

        private static Table CreateTable()
        {
            return new Table()
                .RoundedBorder().BorderColor(Color.LightSlateGrey)
                .AddColumn("[b]Id[/]")
                .AddColumn("[b]Date[/]")
                .AddColumn("[b]Time[/]")
                .Alignment(Justify.Center)
                .Title("[yellow]Records[/]");
        }
    }

    public class Container
    {
        public int Id { get; set; }
        public TimeOnly TimeOnly { get; set; }
        public DateOnly BirthDate { get; set; }
    }


}
