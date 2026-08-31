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

// foreach (string name in names)
// {
//     Console.WriteLine(name);
// }

string longest = "";
string shortest = "";

foreach (string name in names)
{
    if (name.Length > longest.Length)
    {
        longest = name;
    }
}

Console.WriteLine($"The longest name is: {longest}");

foreach (string name in names)
{
    if (name.Length < shortest.Length)
    {
        shortest = name;
    }
}

Console.WriteLine($"The shortest name is: {shortest}");