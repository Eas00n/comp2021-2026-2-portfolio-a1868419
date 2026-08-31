string[] names =
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

foreach (string name in names)
{
    Console.WriteLine(name);
}

foreach (string name in names)
{
    if (name.Length > longest.Length)
    {
        longest = name;
    }
}

Console.WriteLine($"The longest name is: {longest}");