using System;

namespace Rhombus
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
            int x = 0;

            while (y < rows)
            {
                while (space < rows)
                {
                    Console.Write(" ");
                    space++;
                }
                x = 0;
                while (x < star)
                {
                    Console.Write("*");
                    x++;
                }
                x = 0;
                while (x < star - 1)
                {
                    Console.Write("*");
                    x++;
                }
                Console.WriteLine();
                space = star++;
                y++;
            }

            space = 0;
            star = 2;
            y = 0;
            x = rows;

            while (star < rows + 1)
            {
                while (space < star)
                {
                    Console.Write(" ");
                    space++;
                }
                while (space < rows)
                {
                    Console.Write("*");
                    space++;
                }
                while (y < x - 1)
                {
                    Console.Write("*");
                    y++;
                }
                Console.WriteLine();
                star++;
                space = 0;
                y = 0;
                x--;
            }
            Console.ReadLine();
        }
    }
}
