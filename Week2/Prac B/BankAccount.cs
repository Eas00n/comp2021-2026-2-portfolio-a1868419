public class BankAccount
{
    public string Owner { get; set; }
    public decimal Balance { get; set; }
    public void Deposit(decimal amount)
    {
        Balance += amount;
    }
    
    public void Withdraw(decimal amount)
    {
            if (amount > Balance)
            {
                throw new ArgumentException("You do not have enough money in your account to withdraw this amount.");
            }
        Balance -= amount;
    }

    public void Deposit(int amount)
    {
        Balance += amount;
    }

    public void Deposit(double amount)
    {
        Balance += (decimal)amount;
    }
}