Stack<string> undoHistory = new();

undoHistory.Push("Typed Text");
undoHistory.Push("Inserted Image");
undoHistory.Push("Changed Colour");

Console.WriteLine("Initial Stack:");

foreach (string action in undoHistory)
{
    Console.WriteLine(action);
}

Console.WriteLine();

Console.WriteLine($"Top Item: {undoHistory.Peek()}");

Console.WriteLine();

string removedAction = undoHistory.Pop();

Console.WriteLine($"Removed Action: {removedAction}");

Console.WriteLine();

Console.WriteLine("Stack After Pop:");

foreach (string action in undoHistory)
{
    Console.WriteLine(action);
}