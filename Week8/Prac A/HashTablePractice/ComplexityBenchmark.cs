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

            Console.WriteLine($"Loop size: {size:N0}");
            Console.WriteLine($"String Append: {aStopwatch.Elapsed.TotalSeconds:F4} seconds");
        }
    }
}