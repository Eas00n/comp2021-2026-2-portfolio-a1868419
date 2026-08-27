using System.IO.Pipelines;
using System.Text;

namespace TachyonManifold;
/// <summary>
/// Class <c>Program</c> contains the magical tachyon manifold.
/// </summary>
public static class Program
{

    //This is a singleline comment.
    //TODO: Change hardcoded string for the input file to one on your PC.
    public static string FileToRead { get; set; } = @"D:\SDP\Week4\Prac B\TachyonManifold\Example.txt";

    /// <summary>
    /// This method processes the start of the tachyon manifold
    /// <example>
    /// For example:
    /// <code>
    /// ProcessStart(0, 0, taychonGrid);
    /// </code>
    /// results in <c>'|'</c>being added to the grid point (0,1)
    /// </example>
    /// </summary>
    /// <param name="posX">The X position of the start point.</param>
    /// <param name="posY">The Y position of the start point.</param>
    /// <param name="tachyonGrid">The tachyon manifold grid.</param>
    public static void ProcessStart(int posX, int posY, List<string> tachyonGrid)
    {
        string line = tachyonGrid[posY + 1];
        StringBuilder sb = new(line);
        sb[posX] = '|';
        line = sb.ToString();
        tachyonGrid[posY + 1] = line;
    }

    /*
    This is a multiline comment
    TODO: ProcessSplitter should return an int to add to the total, but it currently returns nothing.
    */

    /// <summary>
    /// Processes a splitter and creates tachyon paths on both sides.
    /// </summary>
    /// <param name="posX">The X position of the splitter.</param>
    /// <param name="posY">The Y position of the splitter.</param>
    /// <param name="tachyonGrid">The tachyon manifold grid.</param>
    public static int ProcessSplitter(int posX, int posY, List<string> tachyonGrid)
    {
        string line = tachyonGrid[posY];
        StringBuilder sb = new(line);
        if (tachyonGrid[posY - 1][posX] == '|')
        {
            sb[posX - 1] = '|';
            sb[posX + 1] = '|';
            line = sb.ToString();
            tachyonGrid[posY] = line;
            return 1;
        }
        return 0;
    }

    /// <summary>
    /// Continues the tachyon path through an empty square.
    /// </summary>
    /// <param name="posX">The X position of the empty square.</param>
    /// <param name="posY">The Y position of the empty square.</param>
    /// <param name="tachyonGrid">The tachyon manifold grid.</param>
    public static void ProcessEmpty(int posX, int posY, List<string> tachyonGrid)
    {
        string line = tachyonGrid[posY];
        StringBuilder sb = new(line);
        if (tachyonGrid[posY - 1][posX] == '|')
        {
            sb[posX] = '|';
            line = sb.ToString();
            tachyonGrid[posY] = line;
        }
    }

    public static void Main()
    {
      
        StreamReader sr = new(FileToRead);
        string srText = sr.ReadToEnd();
        int totalCount = 0;

        List<string> symbols = [.. srText.Split("\n")];
        List<string> tachyonGrid = symbols[..^1];

        Console.WriteLine("Begin Tachyon Manifold start state");
        foreach (string item in tachyonGrid)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("End Tachyon Manifold start state");

        for (int posY = 0; posY < tachyonGrid.Count; posY++)
        {
            string item = tachyonGrid[posY];
            foreach ((int posX, char character) in item.Index())
            {
                if (character == 'S')
                {
                    ProcessStart(posX, posY, tachyonGrid);
                }
                else if (character == '^')
                {
                    totalCount += ProcessSplitter(posX, posY, tachyonGrid);
                }
                else if (posY != 0)
                {
                    ProcessEmpty(posX, posY, tachyonGrid);
                }
            }
        }
        Console.WriteLine($"Begin Taychon Manifold end state");

        foreach (string item in tachyonGrid)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine($"End Taychon Manifold end state");
        Console.WriteLine($"Total Tachyon Manifold splits were: {totalCount}");
        Console.WriteLine($"If using Example.txt, your total should be 21");
        Console.WriteLine($"If using Example.txt, your total is {(totalCount == 21 ? "RIGHT": "WRONG")}");
    }
}
