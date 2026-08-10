public class Payroll
{
    private double _hours;
    private decimal _rate;
    private decimal _taxRate;
    private double Hours
    {
        get { return _hours;}
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Hours cannot be negative.");
            }
            _hours = value;
        }
    }
    private decimal Rate
    {
        get { return _rate;}
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Rate cannot be negative.");
            }
            _rate = value;
        }
    }
    private decimal TaxRate
    {
        get { return _taxRate;}
        set
        {
            if (value < 0 || value > 1)
            {
                throw new ArgumentException("Tax rate must be between 0 and 1.");
            }
            _taxRate = value;
        }
    }

    public Payroll(double hours, decimal rate, decimal taxRate)
    {
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