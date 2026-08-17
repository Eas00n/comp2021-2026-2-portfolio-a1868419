namespace BankAccount.Tests;

public class UnitTest1
{
    [Fact]
    public void Deposit_IncreasesBalance()
    {
        var account = new BankAccount("Yuchen", 1000m);

        account.Deposit(500m);

        Assert.Equal(1500m, account.Balance);
    }
}
