namespace BankAccountTestProject;

public class UnitTest1
{
    [Fact]
    public void Deposit_Decimal_IncreasesBalance()
    {
        BankAccount account = new BankAccount();
        account.Balance = 1000m;

        account.Deposit(100m);

        Assert.Equal(1100m, account.Balance);
    }

    [Fact]
    public void Deposit_Int_IncreasesBalance()
    {
        BankAccount account = new BankAccount();
        account.Balance = 1000m;

        account.Deposit(100);

        Assert.Equal(1100m, account.Balance);
    }

    [Fact]
    public void Deposit_Double_IncreasesBalance()
    {
        BankAccount account = new BankAccount();
        account.Balance = 1000m;

        account.Deposit(100.5);

        Assert.Equal(1100.5m, account.Balance);
    }

    [Fact]
    public void Withdraw_DecreasesBalance()
    {
        BankAccount account = new BankAccount();
        account.Balance = 1000m;

        account.Withdraw(200m);

        Assert.Equal(800m, account.Balance);
    }

    [Fact]
    public void Withdraw_ThrowsException_WhenBalanceTooLow()
    {
        BankAccount account = new BankAccount();
        account.Balance = 1000m;

        Assert.Throws<ArgumentException>(() =>
        {
            account.Withdraw(1500m);
        });
    }
}