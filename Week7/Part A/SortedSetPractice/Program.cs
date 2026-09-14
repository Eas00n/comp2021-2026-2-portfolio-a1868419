using System;
using System.Collections.Generic;

void DisplayScores(SortedSet<int> scores)
{
    Console.WriteLine("Scores:");
    foreach (int score in scores)
    {
        Console.WriteLine(score);
    }

    Console.WriteLine($"Lowest score: {scores.Min}");
    Console.WriteLine($"Highest score: {scores.Max}");
    Console.WriteLine();
}

SortedSet<int> scores = new();
Random rand = new();
for (int i = 0; i < 10; i++)
{
    scores.Add(rand.Next(0, 101));
}

