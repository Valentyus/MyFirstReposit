using System;

namespace Triangles__methods_functions_
{
    class Program
    {
        static void triangle(int rowsTriang)
        {
            for (int numbRows = rowsTriang; numbRows > 0; numbRows--)
            {
                for (int space = 1; space < numbRows; space++)
                {
                    Console.Write(" ");
                }
                for (int star = rowsTriang; star >= numbRows; star--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        static void Tree(int rowsTree)
        {
            for (int numbRows = rowsTree; numbRows > 0; numbRows--)
            {
                for (int space = 1; space < numbRows; space++)
                {
                    Console.Write(" ");
                }
                for (int star = rowsTree; star >= numbRows; star--)
                {
                    Console.Write("*");
                }

                for (int star = rowsTree - 1; star >= numbRows; star--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        static void Rombhus(int rowsRombhus)
        {
            for (int numbRows = rowsRombhus; numbRows > 0; numbRows--)
            {
                for (int space = 1; space < numbRows; space++)
                {
                    Console.Write(" ");
                }
                for (int star = rowsRombhus; star >= numbRows; star--)
                {
                    Console.Write("*");
                }

                for (int star = rowsRombhus - 1; star >= numbRows; star--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            for (int numbRows = rowsRombhus; numbRows > 0; numbRows--)
            {
                for (int space = rowsRombhus; space >= numbRows; space--)
                {
                    Console.Write(" ");
                }
                for (int star = 1; star < numbRows; star++)
                {
                    Console.Write("*");
                }

                for (int star = 2; star < numbRows; star++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Построение треугольника, дерева и ромба в консоли\n ");

                try
                {
                    Console.Write("Введите высоту треугольника (целое число): ");
                    int rowsTriang = int.Parse(Console.ReadLine());
                    triangle(rowsTriang);
                }
                catch (Exception)
                {
                    Console.WriteLine("Некоректный ввод числа!!!\n");
                }

                try
                {
                    Console.Write("\nВведите высоту дерева (целое число): ");
                    int rowsTree = int.Parse(Console.ReadLine());
                    Tree(rowsTree);
                }
                catch (Exception)
                {
                    Console.WriteLine("Некоректный ввод числа!!!\n");
                }

                try
                {
                    Console.Write("\nВедите высоту ромба (целое число): ");
                    int rowsRombhus = int.Parse(Console.ReadLine());
                    Rombhus(rowsRombhus);
                }
                catch (Exception)
                {
                    Console.WriteLine("Некоректный ввод числа!!!\n");
                }

                Console.ReadLine();
                continue;
              
            }
        }
    }
}
