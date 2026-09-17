using System.Collections.Generic;
using System.Linq;

var sortedScores2 = new SortedDictionary<ScoreEntry, Player>();

var score = new ScoreEntry(1000, 5);
var player = new Player("Yuchen");

sortedScores2.Add(score, player);

var sortedScores = new SortedDictionary<int, string>();

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

Console.WriteLine("Remaining Players:");
foreach (var player in sortedScores)
{
    Console.WriteLine($"{player.Value}: {player.Key}");
}

// Console.WriteLine();
// Console.WriteLine("Testing Duplicate Score:");

// sortedScores.Add(1200, "NewPlayer");

Console.WriteLine();
Console.WriteLine("Testing Duplicate Name:");

sortedScores.Add(1600, "Yuchen");

foreach (var player in sortedScores)
{
    Console.WriteLine($"{player.Value}: {player.Key}");
}