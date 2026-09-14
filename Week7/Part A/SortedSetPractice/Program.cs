using System;
using System.Collections.Generic;

void DisplayScores(SortedSet<int> scores)
{
    Console.WriteLine("Scores:");
    foreach (int score in scores)
    {
        Console.WriteLine(score);
    }

    Console.WriteLine($"Lowest score: {scores.Min}");
    Console.WriteLine($"Highest score: {scores.Max}");
    Console.WriteLine();
}
//Task1
// SortedSet<int> scores = new();
// Random rand = new();
// for (int i = 0; i < 10; i++)
// {
//     scores.Add(rand.Next(0, 101));
// }

// Console.WriteLine("Initial scores:");
// DisplayScores(scores);

// scores.Add(160);
// Console.WriteLine("After adding High score:");
// DisplayScores(scores);

// scores.Add(160);
// Console.WriteLine("After adding duplicate High score:");
// DisplayScores(scores);

//Task2
void DisplayAccounts(SortedSet<BankAccount> accounts)
{
    foreach (BankAccount account in accounts)
    {
        Console.WriteLine(account);
    }
}

//Task2 Test
SortedSet<BankAccount> sortedBankSet = new SortedSet<BankAccount>(new BankComparer());

BankAccount account1 = new("Yuchen", 100);
BankAccount account2 = new("Jun", 250);
BankAccount account3 = new("Anon", 75);
BankAccount account4 = new("Shanice", 500);
BankAccount account5 = new("Ecclesiasticalot", 150);
BankAccount account6 = new("Mark", 300);
BankAccount account7 = new("Annalie", 50);
BankAccount account8 = new("Melissa", 400);
BankAccount account9 = new("Askey", 200);
BankAccount account10 = new("Alex", 350);

sortedBankSet.Add(account1);
sortedBankSet.Add(account2);
sortedBankSet.Add(account3);
sortedBankSet.Add(account4);
sortedBankSet.Add(account5);
sortedBankSet.Add(account6);
sortedBankSet.Add(account7);
sortedBankSet.Add(account8);
sortedBankSet.Add(account9);
sortedBankSet.Add(account10);
