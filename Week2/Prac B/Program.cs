class Program
{
    static void Main(string[] args)
    {
        BankAccount account = new BankAccount();

        account.Owner = "Yuchen";
        account.Balance = 1400m;

        Console.WriteLine($"Owner: {account.Owner}");
        Console.WriteLine($"Initial balance: ${account.Balance:F2}");

        account.Deposit(100m);
        Console.WriteLine($"After deposit: ${account.Balance:F2}");

        account.Withdraw(200m);
        Console.WriteLine($"After withdrawal: ${account.Balance:F2}");
    }
}