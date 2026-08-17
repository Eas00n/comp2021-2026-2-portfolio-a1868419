using Xunit;
using BankAccountClass = global::BankAccount;

public class BankAccountTests
{
    [Fact]
    public void Deposit_IncreasesBalance()
    {
        var account = new BankAccountClass("Yuchen", 1000m);

        account.Deposit(500m);

        Assert.Equal(1500m, account.Balance);
    }

    [Fact]
    public void Withdraw_DecreasesBalance()
    {
        var account = new BankAccountClass("Yuchen", 1000m);

        account.Withdraw(200m);

        Assert.Equal(800m, account.Balance);
    }

    [Fact]
    public void Withdraw_ThrowsException_WhenBalanceIsNotEnough()
    {
        var account = new BankAccountClass("Yuchen", 1000m);

        Assert.Throws<ArgumentException>(() => account.Withdraw(1500m));
    }

    [Fact]
    public void SavingsAccount_ApplyInterest_IncreasesBalance()
    {
        var account = new SavingsAccount("Yuchen", 1000m, 5.0m);

        account.ApplyInterest();

        Assert.Equal(1050m, account.Balance);
    }

    [Fact]
    public void SavingsAccount_DisplayAccountInfo_Works()
    {
        var account = new SavingsAccount("Yuchen", 1500m, 3.5m);

        account.DisplayAccountInfo();

        Assert.Equal(1500m, account.Balance);
    }

    [Fact]
    public void CheckingAccount_Withdraw_DeductsTransactionFee()
    {
        var account = new CheckingAccount("Yuchen", 1000m, 10m);

        account.Withdraw(100m);

        Assert.Equal(890m, account.Balance);
    }

    [Fact]
    public void CheckingAccount_DisplayAccountInfo_Works()
    {
        var account = new CheckingAccount("Yuchen", 1500m, 10m);

        account.DisplayAccountInfo();

        Assert.Equal(1500m, account.Balance);
    }

    [Fact]
    public void CheckingAccount_Withdraw_ThrowsException_WhenBalanceIsNotEnough()
    {
        var account = new CheckingAccount("Yuchen", 1000m, 10m);

        Assert.Throws<ArgumentException>(() => account.Withdraw(1000m));
    }
}