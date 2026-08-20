FullTimeEmployee employee =
    new FullTimeEmployee("Jordan", 90000m);

Contractor contractor =
    new Contractor("Sarah", 75m, 35m);

Console.WriteLine(employee.GenerateReport());
Console.WriteLine();

Console.WriteLine(contractor.GenerateReport());
Console.WriteLine();

Console.WriteLine($"Employee Pay: ${employee.CalculatePay():F2}");
Console.WriteLine($"Contractor Pay: ${contractor.CalculatePay():F2}");