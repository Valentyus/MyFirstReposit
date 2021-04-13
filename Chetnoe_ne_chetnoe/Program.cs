using System;

namespace Chetnoe_ne_chetnoe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Проверка числа на четность\n");
            Console.WriteLine("Введите число");

            double numb = double.Parse(Console.ReadLine());

            if (numb % 2 == 0)
            {
                Console.WriteLine("Число четное");
            }
            else
            {
                Console.WriteLine("Число не четное");
            }
        }
    }
}
