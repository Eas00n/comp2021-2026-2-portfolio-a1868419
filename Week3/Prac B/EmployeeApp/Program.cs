List<Employee> employees = new List<Employee>
{
    new FullTimeEmployee("Bill", 60000m),
    new Contractor("Fred", 50m, 40m)
};

foreach (Employee employee in employees)
{
    decimal pay = employee.CalculatePay();
    decimal tax = pay / (1 - Employee.TaxRate) * Employee.TaxRate;

    Console.WriteLine($"{employee.Name}: Pay ${pay:F2}. Tax ${tax:F2}.");
}