using System.Collections.Generic;

var sortedDictionary = new SortedDictionary<int, string>();

sortedScores.Add(1200, "Yuchen");
sortedScores.Add(950, "Jun");
sortedScores.Add(1500, "Anon");
sortedScores.Add(800, "Shanice");
sortedScores.Add(1100, "Ecclesiasticalot");
sortedScores.Add(1300, "Mark");
sortedScores.Add(700, "Annalie");
sortedScores.Add(1000, "Melissa");
sortedScores.Add(1400, "Askey");
sortedScores.Add(900, "Alex");

Console.WriteLine("Top 3 Scores:");

foreach (var player in sortedScores.Reverse().Take(3))
{
    Console.WriteLine($"{player.Value}: {player.Key}");
}

Console.WriteLine();

Console.WriteLine("Bottom 3 Scores:");
foreach (var player in sortedScores.Take(3))
{
    Console.WriteLine($"{player.Value}: {player.Key}");
}

Console.WriteLine();

Console.WriteLine("Removing Player Melissa:");
int scoreToRemove = sortedScores.First(x => x.Value == "Melissa").Key;

sortedScores.Remove(scoreToRemove);

Console.WriteLine();