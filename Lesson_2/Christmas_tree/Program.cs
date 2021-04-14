using System;

namespace Christmas_tree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number rows ");
            int rows = int.Parse(Console.ReadLine());
            int space = 0;
            int star = 1;
            int y = 0;

            while (y < rows)
            {
                while (space < rows)
                {
                    Console.Write(" ");
                    space++;
                }
                int x = 0;
                while (x < star - 1)
                {
                    Console.Write("*");
                    x++;
                }
                x = 0;
                while (x < star)
                {
                    Console.Write("*");
                    x++;
                }
                Console.WriteLine();
                space = star++;
                y++;
            }
            Console.ReadLine();
        }
    }
}
