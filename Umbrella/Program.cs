using System;

namespace Umbrella
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Umbrella corporation welcomes you");
            Console.WriteLine("Hello! What is your name?\n");
            string name = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Well, hello " + name);
            Console.WriteLine("Wanna buy some cat?\n");
            string answer = Console.ReadLine();
            Console.WriteLine();

            while (answer != "Yes" && answer != "yes")
            {
                Console.WriteLine("\nWHHAAAAAT?\n");
                answer = Console.ReadLine();
            }
            switch (answer)
            {
                case "Yes":
                case "yes":
                    Console.WriteLine("\nSorry, this is joke!");
                    break;
            }
        }
    }
}
