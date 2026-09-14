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

Console.WriteLine("Initial scores:");
DisplayScores(scores);

scores.Add(160);
Console.WriteLine("After adding High score:");
DisplayScores(scores);

scores.Add(160);
Console.WriteLine("After adding duplicate High score:");
DisplayScores(scores);

SortedSet<BankAccount> sortedBankSet = new();
sortedBankSet.Add(account1);