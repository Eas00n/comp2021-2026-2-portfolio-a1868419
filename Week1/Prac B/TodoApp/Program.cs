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
            }
        }
    }
}