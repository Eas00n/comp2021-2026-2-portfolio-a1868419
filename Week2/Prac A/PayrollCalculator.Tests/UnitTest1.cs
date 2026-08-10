namespace PayrollCalculator.Tests;

public class UnitTest1
{
    [Fact]
    public void CalculateNetPay_ReturnsCorrectAmount()
    {
        Payroll payroll = new Payroll(30, 20m, 0.4m);

        decimal result = payroll.CalculateNetPay();

        Assert.Equal(360m, result);
    }

    [Fact]
    public void Hours_ThrowsException_WhenNegative()
    {
        Assert.Throws<ArgumentException>(() =>
        {
            Payroll payroll = new Payroll(-30, 20m, 0.4m);
        });
    }

    [Fact]
    public void Rate_ThrowsException_WhenNegative()
    {
        Assert.Throws<ArgumentException>(() =>
        {
            Payroll payroll = new Payroll(30, -20m, 0.4m);
        });
    }

    [Fact]
    public void TaxRate_ThrowsException_WhenNegative()
    {
        Assert.Throws<ArgumentException>(() =>
        {
            Payroll payroll = new Payroll(30, 20m, -0.4m);
        });
    }

    [Fact]
    public void TaxRate_ThrowsException_WhenGreaterThanOne()
    {
        Assert.Throws<ArgumentException>(() =>
        {
            Payroll payroll = new Payroll(30, 20m, 1.4m);
        });
    }

    [Fact]
    public void ChangeTaxRate_ChangesTaxRate()
    {
        Payroll payroll = new Payroll(30, 20m, 0.4m);

        payroll.ChangeTaxRate(0.2m);

        decimal result = payroll.CalculateNetPay();

        Assert.Equal(480m, result);
    }

    [Fact]
    public void ChangeTaxRate_ThrowsException_WhenInvalid()
    {
        Payroll payroll = new Payroll(30, 20m, 0.4m);

        Assert.Throws<ArgumentException>(() =>
        {
            payroll.ChangeTaxRate(1.5m);
        });
    }
}