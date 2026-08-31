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
Console.WriteLine("Before Reverse:");

foreach (string name in names)
{
    Console.WriteLine(name);
}

Array.Reverse(names);
Console.WriteLine("After Reverse:");

foreach (string name in names)
{
    Console.WriteLine(name);
}

// Array.Sort(names);
// Console.WriteLine("After Sort:");

// foreach (string name in names)
// {
//     Console.WriteLine(name);
// }



// string longest = names[0];
// string shortest = names[0];

// foreach (string name in names)
// {
//     if (name.Length > longest.Length)
//     {
//         longest = name;
//     }
// }

// Console.WriteLine($"The longest name is: {longest}");

// foreach (string name in names)
// {
//     if (name.Length < shortest.Length)
//     {
//         shortest = name;
//     }
// }

// Console.WriteLine($"The shortest name is: {shortest}");