List<string> names = new()
{
    "Yuchen",
    "Jun",
    "Anon",
    "Shanice",
    "Ecclesiasticalot",
    "Mark",
    "Annalie",
    "Melissa",
    "Askey",
    "Alex"
};

Console.WriteLine("Original List:");

foreach (string name in names)
{
    Console.WriteLine(name);
}

var orderedNames = names.OrderBy(x => x);

Console.WriteLine($"Type of orderedNames: {orderedNames.GetType()}");

Console.WriteLine();

List<string> sortedNames = orderedNames.ToList();

Console.WriteLine("Sorted List:");

foreach (string name in sortedNames)
{
    Console.WriteLine(name);
}