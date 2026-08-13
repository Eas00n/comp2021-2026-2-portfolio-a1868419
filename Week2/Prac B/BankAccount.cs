public class BankAccount
{
    public string Owner { get; set; }
    public decimal Balance { get; set; }
    public void Deposit(decimal amount)
    {
        Balance += amount;
    }
}