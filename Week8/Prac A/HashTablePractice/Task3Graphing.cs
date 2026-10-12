using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using ScottPlot;

public class Task3Graphing
{
    public static void Run()
    {
        int iterations = 20;
        List<double> appendElapsedList = new List<double>();
        List<double> builderElapsedList = new List<double>();
        Stopwatch watch = new Stopwatch();

        // Measure string Append
        for (int pass = 1; pass <= iterations; pass++)
        {
            string aOutput = "";
            watch.Reset();
            watch.Start();

            for (int i = 0; i < pass * 10_000; i++)
            {
                aOutput += "z";
            }
            watch.Stop();
            appendElapsedList.Add(watch.Elapsed.TotalSeconds);
            Console.WriteLine($"Build - Pass {pass}: {watch.Elapsed.TotalSeconds:F4} seconds");

        }

        //Create the Append plot
        for (int pass = 1; pass <= iterations; pass++)
        {
            StringBuilder bOutput = new StringBuilder();

            watch.Reset();
            watch.Start();

            for (int i = 0; i < pass * 10_000; i++)
            {
                bOutput.Append("z");
            }

            watch.Stop();
            builderElapsedList.Add(watch.Elapsed.TotalSeconds);

            Console.WriteLine($"Builder - Pass {pass}: {watch.Elapsed.TotalSeconds:F4} seconds");
        }

        Plot appendPlot = new Plot();
        double[] appendValues = appendElapsedList.ToArray();
        double[] passNumbers = new double[iterations];
        for (int i = 0; i < iterations; i++)
        {
            passNumbers[i] = i + 1;
        }
        var appendBars = appendPlot.Add.Bars(appendValues);

        appendPlot.Title("String Append Performance");
        appendPlot.XLabel("Pass Number(each pass adds 10,000 more characters)");
        appendPlot.YLabel("Elapsed Time (seconds)");
        appendPlot.SavePng("appendPlot.png", 800, 600);

        // Create the StringBuilder plot
        Plot builderPlot = new Plot();
        double[] builderValues = builderElapsedList.ToArray();
        var builderBars = builderPlot.Add.Bars(builderValues);

        builderPlot.Title("StringBuilder Performance");
        builderPlot.XLabel("Pass Number(each pass adds 10,000 more characters)");
        builderPlot.YLabel("Elapsed Time (seconds)");
        builderPlot.SavePng("buildPlot.png", 800, 600);

        Console.WriteLine();
        Console.WriteLine("Graphs saved as appendPlot.png and buildPlot.png");
    }
}