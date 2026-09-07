Stack<BankAccount> accounts = new();

accounts.Push(new BankAccount("Yuchen", 1000));
accounts.Push(new BankAccount("Jun", 2000));
accounts.Push(new BankAccount("Anon", 1500));
accounts.Push(new BankAccount("Shanice", 3000));
accounts.Push(new BankAccount("Ecclesiasticalot", 4000));
accounts.Push(new BankAccount("Mark", 2500));
accounts.Push(new BankAccount("Annalie", 3500));
accounts.Push(new BankAccount("Melissa", 5000));
accounts.Push(new BankAccount("Askey", 1200));
accounts.Push(new BankAccount("Alex", 2200));

Console.WriteLine("Stack:");

foreach (BankAccount account in accounts)
{
    Console.WriteLine(account);
}

static Queue<BankAccount> StackToQueue(Stack<BankAccount> stack)
{
    Queue<BankAccount> queue = new();

    foreach (BankAccount account in stack)
    {
        queue.Enqueue(account);
    }

    return queue;
}

static Queue<BankAccount> SortQueue(Queue<BankAccount> queue)
{
    Queue<BankAccount> sortedQueue = new();

    int count = queue.Count;

    for (int i = 0; i < count; i++)
    {
        Queue<BankAccount> tempQueue = new();

        BankAccount lowestBalanceAccount = queue.Peek();

        while (queue.Count > 0)
        {
            BankAccount account = queue.Dequeue();

            if (account.Balance < lowestBalanceAccount.Balance)
            {
                lowestBalanceAccount = account;
            }

            tempQueue.Enqueue(account);
        }

        while (tempQueue.Count > 0)
        {
            BankAccount account = tempQueue.Dequeue();

            if (account != lowestBalanceAccount)
            {
                queue.Enqueue(account);
            }
        }

        sortedQueue.Enqueue(lowestBalanceAccount);
    }

    return sortedQueue;
}

Queue<BankAccount> queueAccounts = StackToQueue(accounts);

// Console.WriteLine();
// Console.WriteLine("Queue:");

// foreach (BankAccount account in queueAccounts)
// {
//     Console.WriteLine(account);
// }
Console.WriteLine();
Console.WriteLine("Queue Before Sorting:");

foreach (BankAccount account in queueAccounts)
{
    Console.WriteLine(account);
}

Queue<BankAccount> sortedQueue = SortQueue(queueAccounts);

Console.WriteLine();
Console.WriteLine("Queue After Sorting:");

foreach (BankAccount account in sortedQueue)
{
    Console.WriteLine(account);
}