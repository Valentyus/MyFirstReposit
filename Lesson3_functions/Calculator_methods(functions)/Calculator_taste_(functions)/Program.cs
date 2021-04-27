using System;

namespace Calculator_taste__functions_
{
    class Program
    {
        static double calculator(double numb1, double numb2, string operatr, double result)
        {
            if (operatr == "+")
            {
                result = summa(numb1, numb2);
                Console.WriteLine("Сумма дух чисел = " + result);
            }
            else if (operatr == "-")
            {
                result = vichitanie(numb1, numb2);
                Console.WriteLine("Вычитание дух чисел = " + result);
            }
            else if (operatr == "*")
            {
                result = umnozhenie(numb1, numb2);
                Console.WriteLine("Умножение дух чисел = " + result);
            }
            else if (operatr == "/")
            {
                result = delenie(numb1, numb2);
                Console.WriteLine("Деление дух чисел = " + result);
            }
            return result;
        }
        static double summa(double numb1, double numb2)
        {
            return numb1 + numb2;
        }
        static double vichitanie(double numb1, double numb2)
        {
            return numb1 - numb2;
        }
        static double umnozhenie(double numb1, double numb2)
        {
            return numb1 * numb2;
        }
        static double delenie(double numb1, double numb2)
        {
            return numb1 / numb2;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Калькулятор с двумя числами\n");

            while (true)
            {
                Console.Clear();
                try
                {
                    Console.Write("Введите первое число: ");
                    double numb1 = double.Parse(Console.ReadLine());
                    Console.Write("Введите второе число: ");
                    double numb2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Введите операцию над числами: + - * / ");
                    string operatr = Console.ReadLine();
                    double result = 1;
                    calculator(numb1, numb2, operatr, result);
                }
                catch
                {
                    Console.WriteLine("Некоректный ввод числа!!!\n");
                }
                Console.ReadLine();
            }
        }
    }
}
