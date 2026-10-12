using System;
using System.Diagnostics;
using System.Text;

public class ComplexityBenchmark
{
    public static void Run()
    {
        int[] sizes = { 10000, 50000, 100000 };
        foreach (int size in sizes)
        {
            // Method A: Append using string
            string aOutput = "";
            Stopwatch aStopwatch = Stopwatch.StartNew();
            aStopwatch.Start();
            for (int i = 0; i < size; i++)
            {
                aOutput += "z";
            }
            aStopwatch.Stop();

            // Method B: Append using StringBuilder
            StringBuilder bOutput = new StringBuilder();
            Stopwatch bStopwatch = Stopwatch.StartNew();
            bStopwatch.Start();
            for (int i = 0; i < size; i++)
            {
                bOutput.Append("z");
            }
            bStopwatch.Stop();

            Console.WriteLine($"Loop size: {size:N0}");
            Console.WriteLine($"String Append: {aStopwatch.Elapsed.TotalSeconds:F4} seconds");
            Console.WriteLine($"StringBuilder Append: {bStopwatch.Elapsed.TotalSeconds:F4} seconds");
        }
    }
}