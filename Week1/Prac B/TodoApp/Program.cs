class Program
{
    static void Main(string[] args)
    {
        List<string> tasks = new List<string>();
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
            }
        }
    }
}