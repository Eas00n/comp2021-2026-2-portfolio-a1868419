public class Payroll
{
    private double hours
    {
        get;
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Hours cannot be negative.");
            }
            hours = value;
        }
    }
    private decimal rate
    {
        get;
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Rate cannot be negative.");
            }
            rate = value;
        }
    }
    private decimal taxRate
    {
        get;
        set
        {
            if (value < 0 || value > 1)
            {
                throw new ArgumentException("Tax rate must be between 0 and 1.");
            }
            taxRate = value;
        }
    }

    public Payroll(double hours, decimal rate, decimal taxRate)
    {
        if (hours < 0)
        {
            throw new ArgumentException("Hours cannot be negative.");
        }
        if (rate < 0)
        {
            throw new ArgumentException("Rate cannot be negative.");
        }
        if (taxRate < 0 || taxRate > 1)
        {
            throw new ArgumentException("Tax rate must be between 0 and 1.");
        }
        Hours = hours;
        Rate = rate;
        TaxRate = taxRate;
    }

    public decimal CalculateNetPay()
    {
        decimal grossPay = (decimal)Hours * Rate;
        decimal tax = grossPay * TaxRate;
        decimal netPay = grossPay - tax;
        return netPay;
    }

    public void ChangeTaxRate(decimal newTaxRate)
    {
        TaxRate = newTaxRate;
    }
}