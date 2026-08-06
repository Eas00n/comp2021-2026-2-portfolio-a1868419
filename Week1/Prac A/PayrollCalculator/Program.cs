class Program
{
    const double TAX_RATE = 0.2;

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
        double rate = double.Parse(rateInput);

        double net_pay = CalculatePay(hours, rate);

        Console.WriteLine($"{name} earned ${net_pay:F2} after tax.");
    }

    static double CalculatePay(double hours, double rate)
    {
        if (hours < 0 || rate < 0)
        {
            throw new ArgumentException("Hours and rate must be positive.");
        }
        double gross = hours * rate;
        double tax = gross * TAX_RATE;
        double net = gross - tax;
        return net;
    }
}