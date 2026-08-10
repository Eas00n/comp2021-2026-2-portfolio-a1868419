class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter employee name: ");
        string name = Console.ReadLine();

        Console.Write("Hours worked: ");
        string hoursInput = Console.ReadLine();
        if (hoursInput == null)
        {
            throw new InvalidOperationException("No input provided for hours worked.");
        }
        double hours = double.Parse(hoursInput);

        Console.Write("Hourly rate: ");
        string rateInput = Console.ReadLine();
        if (rateInput == null)
        {
            throw new InvalidOperationException("No input provided for hourly rate.");
        }
        decimal rate = decimal.Parse(rateInput);

        Console.Write("Tax rate (e.g., 0.2 for 20%): ");
        string taxRateInput = Console.ReadLine();
        if (taxRateInput == null)
        {
            throw new InvalidOperationException("No input provided for tax rate.");
        }
        decimal taxRate = decimal.Parse(taxRateInput);

        Payroll payroll = new Payroll(hours, rate, taxRate);
        decimal net_pay = payroll.CalculateNetPay();

        Console.WriteLine($"{name} earned ${net_pay:F2} after tax.");
    }
}