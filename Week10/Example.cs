string[] names =
{
 "Jon", "Zoe", "Lin", "Lim", "Zac", "Jon", "Cas", "Zoe", "Zac",
 "Lim", "Lin", "Mei", "May", "Jon", "Cas", "Ann", "Zac", "Lim"
};

Dictionary<string, int> nameCounter = new Dictionary<string, int>();
//Count each name
foreach(string name in names)
{
    if (nameCounter.ContainsKey(name))
    {
        nameCounter[name]++;
    }
    else
    {
        nameCounter.Add(name, 1);
    }
}

//print the name
foreach (KeyValuePair<string, int> item in nameCounter)
{
    Console.WriteLine(item.Key + ": " + item.Value);
}