using System.Globalization;

namespace BrokenProgram;

internal static class BrokenProgram
{
    private static void Main()
    {
        const string input = """
           23
           + 
           77
           + 
            3
           + 
          457
           * 
            2
             
          """;

        int total = 0;
        List<int> items = [];
        List<string> symbols = [];

        string[] lines = input.Split("\n", StringSplitOptions.RemoveEmptyEntries);

        for (int i = 0; i < lines.Length; i++)
        {
            if (i % 2 == 0)
            {
                items.Add(int.Parse(lines[i], CultureInfo.InvariantCulture));
            }
            else
            {
                symbols.Add(lines[i].Trim());
            }
        }

        foreach ((int i, int value) in items.Index())
        {
            if (i == 0)
            {
                total = value;
            }
            else if (symbols[i - 1] == "*")
            {
                total *= value;
            }
            else
            {
                total += value;
            }
        }

        Console.WriteLine("Total was: " + total);
        Console.WriteLine("Expected total was: 1120");
        Console.WriteLine(
            total == 1120
                ? "Your answer was RIGHT!"
                : "Your answer was WRONG!\nGo and fix it.");
    }
}