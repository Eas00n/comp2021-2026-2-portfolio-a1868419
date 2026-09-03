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