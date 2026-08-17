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

    [Fact]
    public void Withdraw_DecreasesBalance()
    {
        var account = new BankAccount("Yuchen", 1000m);

        account.Withdraw(200m);

        Assert.Equal(800m, account.Balance);
    }

    [Fact]
    public void Withdraw_ThrowsException_WhenBalanceIsNotEnough()
    {
        var account = new BankAccount("Yuchen", 1000m);

        Assert.Throws<ArgumentException>(() => account.Withdraw(1500m));
    }
    
    [Fact]
    public void SavingsAccount_ApplyInterest_IncreasesBalance()
    {
        var account = new SavingsAccount("Yuchen", 1000m, 5.0);

        account.ApplyInterest();

        Assert.Equal(1050m, account.Balance);
    }

     [Fact]
    public void SavingsAccount_DisplayAccountInfo_Works()
    {
        var account = new SavingsAccount("Yuchen", 1500m, 3.5);

        account.DisplayAccountInfo();

        Assert.Equal(1500m, account.Balance);
    }
}
