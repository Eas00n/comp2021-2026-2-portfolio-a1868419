using System.Collections.Generic;
using System.Linq;

//Task 4
var eventQueue2 = new PriorityQueue<Player, Priority>();

eventQueue2.Enqueue(
    new Player("Yuchen"),
    Priority.MediumPriority);

eventQueue2.Enqueue(
    new Player("Jun"),
    Priority.HighPriority);

eventQueue2.Enqueue(
    new Player("Anon"),
    Priority.LowPriority);

eventQueue2.Enqueue(
    new Player("Shanice"),
    Priority.HighPriority);

eventQueue2.Enqueue(
    new Player("Mark"),
    Priority.MediumPriority);

Console.WriteLine("Processing Players:");

while (eventQueue2.Count != 0)
{
    Console.WriteLine(eventQueue2.Dequeue());
}


// //Task 3
// var eventQueue = new PriorityQueue<Player, int>();

// eventQueue.Enqueue(new Player("Yuchen"), 3);
// eventQueue.Enqueue(new Player("Jun"), 1);
// eventQueue.Enqueue(new Player("Anon"), 5);
// eventQueue.Enqueue(new Player("Shanice"), 2);
// eventQueue.Enqueue(new Player("Mark"), 4);

// Console.WriteLine("Processing Players:");

// while (eventQueue.Count != 0)
// {
//     Console.WriteLine(eventQueue.Dequeue());
// }

// Console.WriteLine();
// Console.WriteLine("Testing Same Priority:");

// eventQueue.Enqueue(new Player("Melissa"), 2);
// eventQueue.Enqueue(new Player("Alex"), 2);

// while (eventQueue.Count != 0)
// {
//     Console.WriteLine(eventQueue.Dequeue());
// }

// //Task 2
// var sortedScores2 = new SortedDictionary<ScoreEntry, Player>(new ScoreComparer());

// // Create 10 players
// var players = new List<Player>
// {
//     new("Yuchen"),
//     new("Jun"),
//     new("Anon"),
//     new("Shanice"),
//     new("Ecclesiasticalot"),
//     new("Mark"),
//     new("Annalie"),
//     new("Melissa"),
//     new("Askey"),
//     new("Alex")
// };

// // Create 10 ScoreEntry objects
// var scores = new List<ScoreEntry>
// {
//     new(1000, 5),
//     new(800, 4),
//     new(1500, 8),
//     new(600, 3),
//     new(1200, 6),
//     new(1300, 7),
//     new(500, 2),
//     new(1100, 5),
//     new(1400, 7),
//     new(900, 4)
// };

// for (int i = 0; i < players.Count; i++)
// {
//     sortedScores2.Add(scores[i], players[i]);
// }

// Console.WriteLine("Top 3 Scores:");

// foreach (var item in sortedScores2.Reverse().Take(3))
// {
//     Console.WriteLine(
//         $"{item.Value.Name} - Score: {item.Key.Score}");
// }

// Console.WriteLine();

// Console.WriteLine("Bottom 3 Scores:");

// foreach (var item in sortedScores2.Take(3))
// {
//     Console.WriteLine(
//         $"{item.Value.Name} - Score: {item.Key.Score}");
// }

// Console.WriteLine();

// Console.WriteLine("Removing Melissa");

// var melissa = sortedScores2.First(
//     item => item.Value.Name == "Melissa");

// sortedScores2.Remove(melissa.Key);

// Console.WriteLine();

// Console.WriteLine("Remaining Players:");

// foreach (var item in sortedScores2)
// {
//     Console.WriteLine(
//         $"{item.Value.Name} - Score: {item.Key.Score}");
// }

// Console.WriteLine();

// Console.WriteLine("Adding same Score with different StageReached:");

// sortedScores2.Add(
//     new ScoreEntry(1000, 10),
//     new Player("NewPlayer"));

// Console.WriteLine(
//     $"NewPlayer - Score: 1000 - Stage: 10");

// Console.WriteLine();

// Console.WriteLine("Adding different Score with same Player:");

// sortedScores2.Add(
//     new ScoreEntry(2000, 12),
//     players[0]);

// Console.WriteLine(
//     $"{players[0].Name} - Score: 2000 - Stage: 12");

//Task1
// var sortedScores = new SortedDictionary<int, string>();

// sortedScores.Add(1200, "Yuchen");
// sortedScores.Add(950, "Jun");
// sortedScores.Add(1500, "Anon");
// sortedScores.Add(800, "Shanice");
// sortedScores.Add(1100, "Ecclesiasticalot");
// sortedScores.Add(1300, "Mark");
// sortedScores.Add(700, "Annalie");
// sortedScores.Add(1000, "Melissa");
// sortedScores.Add(1400, "Askey");
// sortedScores.Add(900, "Alex");

// Console.WriteLine("Top 3 Scores:");

// foreach (var player in sortedScores.Reverse().Take(3))
// {
//     Console.WriteLine($"{player.Value}: {player.Key}");
// }

// Console.WriteLine();

// Console.WriteLine("Bottom 3 Scores:");
// foreach (var player in sortedScores.Take(3))
// {
//     Console.WriteLine($"{player.Value}: {player.Key}");
// }

// Console.WriteLine();

// Console.WriteLine("Removing Player Melissa:");
// int scoreToRemove = sortedScores.First(x => x.Value == "Melissa").Key;

// sortedScores.Remove(scoreToRemove);

// Console.WriteLine();

// Console.WriteLine("Remaining Players:");
// foreach (var player in sortedScores)
// {
//     Console.WriteLine($"{player.Value}: {player.Key}");
// }

// // Console.WriteLine();
// // Console.WriteLine("Testing Duplicate Score:");

// // sortedScores.Add(1200, "NewPlayer");

// Console.WriteLine();
// Console.WriteLine("Testing Duplicate Name:");

// sortedScores.Add(1600, "Yuchen");

// foreach (var player in sortedScores)
// {
//     Console.WriteLine($"{player.Value}: {player.Key}");
// }