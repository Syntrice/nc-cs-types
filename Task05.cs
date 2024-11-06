using System.Text.Json;

namespace NcCsTypes;

internal class NorthcodersStudent
{
    public bool IsDebugging { get; set; }
    public string Name { get; set; }
    public int YearsCoding { get; set; }
    public string CodingAffiliation { get; set; } = "Northcoders";

    public void CheckIfDebugging()
    {
        if (IsDebugging)
        {
            Console.WriteLine("Defeating bugs in code...");
        }
        else
        {
            Console.WriteLine("Bugs defeated, happy coding!");
        }
    }
}

internal class Task05
{
    internal static void Run()
    {
        Console.WriteLine("Type in a JSON format string to convert to a class:");
        string jsonFormattedString = Console.ReadLine();

        //Example working input: {"Name":"Evie Pom","YearsCoding": 6,"IsDebugging":false,"CodingAffiliation":"Poms Who Code"}
        //string workingLiteralString = "{\"Name\": \"Evie Pom\",\"YearsCoding\": 6,\"IsDebugging\":false,\"CodingAffiliation\":\"Poms Who Code\"}";

        NorthcodersStudent test = JsonSerializer.Deserialize<NorthcodersStudent>(jsonFormattedString);
        Console.WriteLine("Name of new instance: " + test.Name);
    }
}
