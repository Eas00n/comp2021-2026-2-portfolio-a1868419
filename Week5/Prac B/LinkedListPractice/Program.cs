using System.Collections.Generic;

LinkedList<string> students = new();

students.AddFirst("Yuchen");
students.AddLast("Jun");
students.AddLast("Anon");

LinkedListNode<string>? junNode = students.Find("Jun");

students.AddBefore(junNode!, "Shanice");
students.AddAfter(junNode!, "Ecclesiasticalot");

students.AddLast("Mark");
students.AddLast("Annalie");
students.AddLast("Melissa");
students.AddLast("Askey");
students.AddLast("Alex");

students.Remove("Melissa");
students.RemoveFirst();
students.RemoveLast();

Console.WriteLine("Current List:");

foreach (string student in students)
{
    Console.WriteLine(student);
}

LinkedListNode<string>? current = students.First;

for (int i = 1; i < 5; i++)
{
    current = current?.Next;
}

if (current != null)
{
    Console.WriteLine($"Removing: {current.Value}");
    students.Remove(current);
}

Console.WriteLine("\nAfter removing 5th element:");

foreach (string student in students)
{
    Console.WriteLine(student);
}