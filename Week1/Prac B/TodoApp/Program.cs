class Program
{
    static void Main(string[] args)
    {
        List<string> tasks = new List<string>();

        Dictionary<string, List<int>> tags = new Dictionary<string, List<int>>();

        while(true)
        {
            Console.Write("Enter command:");
            string input = Console.ReadLine();

            string[] parts = input.Split(' ');
            switch(parts[0])
            {
                case "add":

                    switch(parts.Length)
                    {
                        case < 2:
                            Console.WriteLine("Please enter a task.");
                            break;

                        default:
                            tasks.Add(parts[1]);
                            Console.WriteLine("Task added.");
                            break;
                    }
                    break;

                case "show":

                    switch(tasks.Count)
                    {
                        case 0:
                            Console.WriteLine("No tasks.");
                            break;
                        default:
                            for(int i = 0; i < tasks.Count; i++)
                            {
                                Console.WriteLine($"{i + 1}. {tasks[i]}");
                            }
                            break;
                    }
                    break;

                case "remove":

                    switch(parts.Length)
                    {
                        case < 2:
                            Console.WriteLine("Please enter a task number.");
                            break;
                        
                        default:
                            int index = int.Parse(parts[1]);
                            switch(index)
                            {
                                case < 1:

                                    Console.WriteLine("Invalid index.");

                                    break;


                                default:

                                    if(index <= tasks.Count)
                                    {
                                        tasks.RemoveAt(index - 1);
                                        Console.WriteLine("Task removed.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid index.");
                                    }

                                    break;
                            }
                            break;
                    }
                    break;
                
                case "tag":

                    switch (parts.Length)
                    {
                        case < 3:
                            Console.WriteLine("Usage: tag [index] [name]");
                            break;

                        default:

                            try
                            {
                                int index = int.Parse(parts[1]);
                                string tagName = parts[2];

                                if (index < 1 || index > tasks.Count)
                                {
                                    Console.WriteLine("Invalid index.");
                                    break;
                                }

                                if (!tags.ContainsKey(tagName))
                                {
                                    tags.Add(tagName, new List<int>());
                                }

                                if (tags[tagName].Contains(index))
                                {
                                    Console.WriteLine("Duplicate tag.");
                                    break;
                                }

                                tags[tagName].Add(index);

                                Console.WriteLine("Tag added.");
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Please enter a valid number.");
                            }

                            break;
                    }

                    break;

                case "get-tagged":
                    switch(parts.Length)
                    {
                        case < 2:

                            Console.WriteLine("Usage: get-tagged [tag]");

                            break;

                        default:
                    }
                    break;

                case "clear":

                    tasks.Clear();

                    Console.WriteLine("All tasks cleared.");

                    break;

                default:

                    Console.WriteLine("Invalid command.");

                    break;
            }
        }
    }
}