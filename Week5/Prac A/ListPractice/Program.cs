List<string> names = new List<string>
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

names.Add("Doug");

names.Remove("Doug");

names.Insert(1, "Paul");

names.AddRange(new List<string>
{
    "Sarah",
    "Tom"
});

Console.WriteLine("Student names:");

foreach (string name in names)
{
    Console.WriteLine(name);
}

int index = names.IndexOf("Melissa");

Console.WriteLine($"Melissa index: {index}");

Console.WriteLine("Names containing 'an':");

foreach (string name in names)
{
    if (name.Contains("an"))
    {
        Console.WriteLine(name);
    }
}