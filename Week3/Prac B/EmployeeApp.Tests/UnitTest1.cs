using Xunit;

public class EmployeeTests
{
    [Fact]
    public void FullTimeEmployee_CalculatePay_ReturnsNetPay()
    {
        var employee = new FullTimeEmployee("Bill", 60000m);

        decimal pay = employee.CalculatePay();

        Assert.Equal(48000m, pay);
    }

    [Fact]
    public void FullTimeEmployee_GenerateReport_ReturnsCorrectReport()
    {
        var employee = new FullTimeEmployee("Bill", 60000m);

        string report = employee.GenerateReport();

        Assert.Contains("Bill", report);
        Assert.Contains("60000.00", report);
        Assert.Contains("48000.00", report);
    }

    [Fact]
    public void Contractor_CalculatePay_ReturnsNetPay()
    {
        var contractor = new Contractor("Fred", 50m, 40m);

        decimal pay = contractor.CalculatePay();

        Assert.Equal(1600m, pay);
    }

    [Fact]
    public void Contractor_GenerateReport_ReturnsCorrectReport()
    {
        var contractor = new Contractor("Fred", 50m, 40m);

        string report = contractor.GenerateReport();

        Assert.Contains("Fred", report);
        Assert.Contains("50.00", report);
        Assert.Contains("40", report);
        Assert.Contains("1600.00", report);
    }

    [Fact]
    public void Employee_TaxRate_Is20Percent()
    {
        Assert.Equal(0.2m, Employee.TaxRate);
    }
}