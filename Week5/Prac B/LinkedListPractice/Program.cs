using System.Collections.Generic;

LinkedList<string> students = new();

students.AddFirst("Yuchen");
students.AddLast("Jun");
students.AddLast("Anon");

LinkedListNode<string>? junNode = students.Find("Jun");

students.AddLast("Shanice");
students.AddLast("Ecclesiasticalot");
students.AddLast("Mark");
students.AddLast("Annalie");
students.AddLast("Melissa");
students.AddLast("Askey");
students.AddLast("Alex");