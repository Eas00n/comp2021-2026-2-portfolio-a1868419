using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;

string path = @"./MyTest.txt";
using (StreamWriter sw = File.CreateText(path))
{
    sw.WriteLine("Hello, World!");
    sw.WriteLine("The old content should be replaced.");
}
Console.WriteLine("File created and text written successfully.");


//Read the file
string content = File.ReadAllText(path);
Console.WriteLine(content);

//Task 2
List<Player> players = new List<Player>
{
    new Player("Anon", 100, 20, 10),
    new Player("Jun", 90, 15, 8),
    new Player("Shanice", 85, 12, 15),
    new Player("Ecclesiasticalot FF", 95, 18, 12),
    new Player("Ryla", 110, 25, 7)
};
//Print the players to the console
foreach (Player player in players)
{
    Console.WriteLine(player);
}
//Convert the list to JSON
string jsonString = JsonSerializer.Serialize(players);
