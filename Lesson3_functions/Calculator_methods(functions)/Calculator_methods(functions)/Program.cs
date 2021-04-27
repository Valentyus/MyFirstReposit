using System;

namespace Calculator_methods_functions_
{
    class Program
    {
        static double calculator(double numb1, double numb2, string operatr, double result)
        {
            
            switch (operatr)
            {
                case "+":
                    result = summa(numb1, numb2);
                    Console.WriteLine("Сумма двух чисел = " + result);
                    break;
                case "-":
                    result = vichitanie(numb1, numb2);
                    Console.WriteLine("Вычитание двух чисел = " + result);
                    break;
                case "*":
                    result = umnozhenie(numb1, numb2);
                    Console.WriteLine("Умножение двух чисел = " + result);
                    break;
                case "/":
                    if (numb2 == 0)
                    {
                        Console.WriteLine("Деление на 0 равно бесконечности ");
                    }
                    result = delenie(numb1, numb2);
                    Console.WriteLine("Деление двух чисел = " + result);
                    break;
                default:
                    Console.WriteLine("Введена некорректная операция ");
                    break;
            }
            return result;
        }
        static double summa(double numb1, double numb2)
        {
            return numb1 + numb2;
        }
        static double vichitanie(double numb1, double numb2)
        {
            double result = numb1 - numb2;
            return result;
        }
        static double umnozhenie(double numb1, double numb2)
        {
            double result = numb1 * numb2;
            return result;
        }
        static double delenie(double numb1, double numb2)
        {
            double result = numb1 / numb2;
            return result;
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

    

