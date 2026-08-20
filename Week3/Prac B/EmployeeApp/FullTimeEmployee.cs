public class FullTimeEmployee : Employee, IReportable
{
    public decimal AnnualSalary { get; set; }

    public FullTimeEmployee(string name, decimal annualSalary)
        : base(name)
    {
        AnnualSalary = annualSalary;
    }

    public override decimal CalculatePay()
    {
        decimal tax = AnnualSalary * TaxRate;
        return AnnualSalary - tax;
    }
}