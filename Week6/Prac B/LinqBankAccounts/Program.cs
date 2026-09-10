Stack<BankAccount> accountsStack = new();

accountsStack.Push(new BankAccount("Yuchen", 1000));
accountsStack.Push(new BankAccount("Jun", 2000));
accountsStack.Push(new BankAccount("Anon", 1500));
accountsStack.Push(new BankAccount("Shanice", 3000));
accountsStack.Push(new BankAccount("Ecclesiasticalot", 4000));
accountsStack.Push(new BankAccount("Mark", 2500));
accountsStack.Push(new BankAccount("Annalie", 3500));
accountsStack.Push(new BankAccount("Melissa", 5000));
accountsStack.Push(new BankAccount("Askey", 1200));
accountsStack.Push(new BankAccount("Alex", 2200));

Queue<BankAccount> accountsQueue = new();

foreach (BankAccount account in accountsStack)
{
    accountsQueue.Enqueue(account);
}

// Task2
// var stackOwners = accountsStack
//     .Select(x => x.Owner)
//     .OrderBy(x => x);

// Console.WriteLine("Stack Owners:");

// foreach (string owner in stackOwners)
// {
//     Console.WriteLine(owner);
// }

// var queueOwners = accountsQueue
//     .Select(x => x.Owner)
//     .OrderBy(x => x);

// Console.WriteLine();
// Console.WriteLine("Queue Owners:");

// foreach (string owner in queueOwners)
// {
//     Console.WriteLine(owner);
// }

// Task3
var stackResults = accountsStack
    .Where(x => x.Owner.Contains("e"))
    .Select(x => new
    {
        Owner = x.Owner,
        Balance = x.Balance
    })
    .OrderBy(x => x.Owner);

Console.WriteLine("Stack Results:");

foreach (var account in stackResults)
{
    Console.WriteLine($"{account.Owner} - {account.Balance:F2}");
}

var queueResults = accountsQueue
    .Where(x => x.Owner.Contains("e"))
    .Select(x => new
    {
        Owner = x.Owner,
        Balance = x.Balance
    })
    .OrderBy(x => x.Balance);

Console.WriteLine();
Console.WriteLine("Queue Results:");

foreach (var account in queueResults)
{
    Console.WriteLine($"{account.Owner} - {account.Balance:F2}");
}