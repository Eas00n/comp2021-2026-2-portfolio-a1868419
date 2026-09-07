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