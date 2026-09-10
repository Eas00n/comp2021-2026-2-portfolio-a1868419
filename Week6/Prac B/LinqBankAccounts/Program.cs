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

var stackOwners = accountsStack
    .Select(x => x.Owner);

var stackOwners = accountsStack
    .Select(x => x.Owner)
    .OrderBy(x => x);