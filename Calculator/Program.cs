using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Hello! This is calculator!\n");
                double numb1, numb2;

                try
                {
                    Console.WriteLine("Введите первое число ");
                    numb1 = double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Не удалось преобразовать строку в число!");
                    Console.ReadLine();
                    continue;
                }

                try
                {
                    Console.WriteLine("Введите второе число ");
                    numb2 = double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Не удалось преобразовать строку в число!");
                    Console.ReadLine();
                    continue;
                }

                Console.WriteLine("Выберите операцию: + - * / ");
                string operatr = Console.ReadLine();

                if (operatr == "+")
                {
                    Console.WriteLine("Сумма чисел = " + (numb1 + numb2));
                }
                else if (operatr == "-")
                {
                    Console.WriteLine("Разница чисел = " + (numb1 - numb2));
                }
                else if (operatr == "*")
                {
                    Console.WriteLine("Произведение чисел = " + (numb1 * numb2));
                }
                else if (operatr == "/")
                {
                    if (numb2 == 0)
                        Console.WriteLine("Деление двух чиcел = бесконечность");
                    else
                        Console.WriteLine("Деление двух чичел = " + (numb1 / numb2));
                }
                else
                {
                    Console.WriteLine("Некоректная операция");
                }
                Console.ReadLine();
            }
        }
        }
    }
}
