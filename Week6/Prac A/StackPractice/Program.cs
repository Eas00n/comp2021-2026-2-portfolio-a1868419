Queue<string> printQueue = new();

printQueue.Enqueue("Print Job 1");
printQueue.Enqueue("Print Job 2");
printQueue.Enqueue("Print Job 3");

Console.WriteLine("Initial Queue:");

foreach (string job in printQueue)
{
    Console.WriteLine(job);
}

Console.WriteLine();

Console.WriteLine($"Front Job: {printQueue.Peek()}");

Console.WriteLine();

string completedJob = printQueue.Dequeue();

Console.WriteLine($"Completed Job: {completedJob}");

Console.WriteLine();

Console.WriteLine("Queue After Dequeue:");

foreach (string job in printQueue)
{
    Console.WriteLine(job);
}