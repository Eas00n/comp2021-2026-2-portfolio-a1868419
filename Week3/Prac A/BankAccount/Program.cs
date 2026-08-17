SavingsAccount savings = new SavingsAccount("Yuchen", 1000m, 0.05m);
savings.ApplyInterest();

CheckingAccount checking = new CheckingAccount("Yuchen", 1000m, 10m);
checking.Withdraw(100m);

Console.WriteLine($"Savings Account: {savings.Owner}, Balance: ${savings.Balance:F2}");
Console.WriteLine($"Checking Account: {checking.Owner}, Balance: ${checking.Balance:F2}");