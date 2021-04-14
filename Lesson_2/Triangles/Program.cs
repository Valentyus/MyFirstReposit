using System;

namespace Triangles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите высоту треугольника: ");
            int rows = int.Parse(Console.ReadLine());
            Console.WriteLine("Треугольник 1\n");
            int lattice = 1;
            int space = 0;
            int numbRows = 0;

            while (numbRows < rows)
            {
                space = 0;
                while (space < lattice)
                {
                    Console.Write("#");
                    space++;
                }
                lattice++;
                Console.WriteLine();
                numbRows++;
            }

            Console.WriteLine("\nТреугольник 2\n");

            numbRows = 0;
            lattice = rows;
            while (numbRows < rows)
            {
                space = 0;
                while (space < lattice)
                {
                    Console.Write("#");
                    space++;
                }
                Console.WriteLine();
                numbRows++;
                lattice--;
            }

            Console.WriteLine("\nТреугольник 3\n");

            numbRows = 0;
            lattice = 0;
            while (numbRows < rows)
            {
                space = 0;
                while (space < lattice)
                {
                    Console.Write(" ");
                    space++;
                }
                for (int unit = numbRows; unit < rows; unit++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
                lattice++;
                numbRows++;
            }

            Console.WriteLine("\nТреугольник 4\n");

            numbRows = 0;
            lattice = rows;
            while (numbRows < rows)
            {
                space = 1;
                while (space < lattice)
                {
                    Console.Write(" ");
                    space++;
                }
                for (int unit = 0; unit <= numbRows; unit++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
                numbRows++;
                lattice--;
            }
        }
    }
}
