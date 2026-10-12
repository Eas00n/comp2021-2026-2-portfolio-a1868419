using System.Collections;
Hashtable scoreHash = new Hashtable();

// Create five players
Player player1 = new Player("Anon");
Player player2 = new Player("Jun");
Player player3 = new Player("Shanice");
Player player4 = new Player("Ecclesiasticalot FF");
Player player5 = new Player("Ryla");

// Add players and their scores
scoreHash.Add(player1, 84);
scoreHash.Add(player2, 77);
scoreHash.Add(player3, 90);
scoreHash.Add(player4, 67);
scoreHash.Add(player5, 99);

Console.WriteLine("Five players have been added.");
Console.WriteLine($"Number of entries: {scoreHash.Count}");

// Test add code
scoreHash.Add("Test Player", 70);
Console.WriteLine($"Number of entries after test: {scoreHash.Count}");

// Test adding a duplicate key
try
{
    scoreHash.Add(player1, 100);
}
catch (ArgumentException)
{
    Console.WriteLine("Duplicate key is not allowed.");
}

Console.WriteLine($"Number of entries after duplicate test: {scoreHash.Count}");

// Get names of players and their scores
Console.WriteLine("\nPlayers sorted by score(highest to lowest):");

var sortedScores = scoreHash.Cast<DictionaryEntry>().Where(entry => entry.Key is Player).OrderByDescending(entry => (int)entry.Value);

foreach (DictionaryEntry entry in sortedScores)
{
    Player player = (Player)entry.Key;
    int score = (int)entry.Value;
    Console.WriteLine($"{player.Name}: {score}");
}