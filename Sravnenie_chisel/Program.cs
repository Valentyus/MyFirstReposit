using System;

namespace Sravnenie_chisel
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Сравнение пяти чисел");
                double chislo1, chislo2, chislo3, chislo4, chislo5;
                double max = 0;
                try
                {
                    Console.Write("\nВведите первое число: ");
                    chislo1 = double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Невозможно преобразовать строку в число ");
                    Console.ReadLine();
                    continue;
                }
                try
                {
                    Console.Write("Введите второе число: ");
                    chislo2 = double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Невозможно преобразовать строку в число ");
                    Console.ReadLine();
                    continue;
                }
                try
                {
                    Console.Write("Введите третие число: ");
                    chislo3 = double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Невозможно преобразовать строку в число ");
                    Console.ReadLine();
                    continue;
                }
                try
                {
                    Console.Write("Введите четвертое число: ");
                    chislo4 = double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Невозможно преобразовать строку в число ");
                    Console.ReadLine();
                    continue;
                }
                try
                {
                    Console.Write("Введите пятое число: ");
                    chislo5 = double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Невозможно преобразовать строку в число! ");
                    Console.ReadLine();
                    continue;
                }
                
                if (chislo1 > chislo2)
                {
                    max = chislo1;
                }
                if (chislo2 > chislo1)
                {
                    max = chislo2;
                }
                if (chislo3 > max)
                {
                    max = chislo3;
                }
                if (chislo4 > max)
                {
                    max = chislo4;
                }
                if (chislo5 > max)
                {
                    max = chislo5;
                }
                Console.WriteLine("\nМаксимальное число: " + max);
                Console.ReadLine();
            }
           
        }
    }
}
