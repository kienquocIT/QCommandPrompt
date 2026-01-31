namespace QTerminal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "exit")
                {
                    break;
                }
                
                var command = new Command("", []);

                if (input == null)
                {
                    Console.WriteLine("No input provided.");
                    continue;
                }

                command.ConvertToCommand(input);

                Console.WriteLine($"Command: {command.CommandText}");
            }
        }
    }
}
