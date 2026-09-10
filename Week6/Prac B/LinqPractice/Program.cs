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

// LINQ OrderBy
var orderedNames = names.OrderBy(x => x);

Console.WriteLine($"Type of orderedNames: {orderedNames.GetType()}");

Console.WriteLine();
