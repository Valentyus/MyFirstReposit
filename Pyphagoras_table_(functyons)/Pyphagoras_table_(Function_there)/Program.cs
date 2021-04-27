using System;

namespace Pyphagoras_table__Function_there_
{
    class Program
    {
        static void HorizontDiapozon(int HStart, int HEnd, int VStart, int VEnd)
        {
            Console.Write("\n ");
            for (int space = 0, vmax = VEnd; space <= vmax; space++, vmax /= 10)
            {
                Console.Write(" ");
            }
            Console.Write("|");
            for (int hNumbStart = HStart; hNumbStart <= HEnd; hNumbStart++)
            {
                Console.Write(" ");
                int Hspace = 0, Hnumb = hNumbStart;
                while (Hnumb > 0)
                {
                    Hspace++;
                    Hnumb /= 10;
                }
                int Numbspace = 0, vMax = hNumbStart * VEnd;
                while (vMax > 0)
                {
                    Numbspace++;
                    vMax /= 10;
                }
                while (Numbspace > Hspace)
                {
                    Numbspace--;
                    Console.Write(" ");
                }
                Console.Write(hNumbStart);
            }
        }
        static void HorizontLine(int HStart, int HEnd, int VStart, int VEnd)
        {
            Console.Write("-");
            for (int space = 0, vmax = VEnd; space <= vmax; space++, vmax /= 10)
            {
                Console.Write("-");
            }
            Console.Write("+");
            for (int hNumbStart = HStart; hNumbStart <= HEnd; hNumbStart++)
            {
                Console.Write("-");
                int Hspace = 0, Hnumb = hNumbStart;
                while (Hnumb > 0)
                {
                    Hspace++;
                    Hnumb /= 10;
                    Console.Write("-");
                }
                int Numbspace = 0, hMax = hNumbStart * VEnd;
                while (hMax > 0)
                {
                    Numbspace++;
                    hMax /= 10;
                }
                while (Numbspace > Hspace)
                {
                    Numbspace--;
                    Console.Write("-");
                }
            }
        }
        static void VerticalDiapozon(int HStart, int HEnd, int VStart, int VEnd)
        {
            for (int vNumbStart = VStart; vNumbStart <= VEnd; vNumbStart++)
            {
                Console.Write(" ");
                int Vspace = 0, Vnumb = vNumbStart;
                while (Vnumb > 0)
                {
                    Vspace++;
                    Vnumb /= 10;
                }
                int Numbspace = 0, vMax = VEnd;
                while (vMax > 0)
                {
                    Numbspace++;
                    vMax /= 10;
                }
                while (Numbspace > Vspace)
                {
                    Numbspace--;
                    Console.Write(" ");
                }
                Console.Write(vNumbStart);
                Console.Write("|");
                TableBody(HStart, HEnd, VStart, VEnd, vNumbStart);
            }
        }
        static void TableBody(int HStart, int HEnd, int VStart, int VEnd, int vNumbStart)
        {
            for (int hNumbStart = HStart; hNumbStart <= HEnd; hNumbStart++)
            {
                Console.Write(" ");
                int Hspace = 0, Hnumb = hNumbStart * vNumbStart;
                while (Hnumb > 0)
                {
                    Hspace++;
                    Hnumb /= 10;
                }
                int horNumbspace = 0, vertMax = hNumbStart * VEnd;
                while (vertMax > 0)
                {
                    horNumbspace++;
                    vertMax /= 10;
                }
                while (horNumbspace > Hspace)
                {
                    horNumbspace--;
                    Console.Write(" ");
                }
                Console.Write(hNumbStart * vNumbStart);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Таблица Пифагора!\n");
                try
                {
                    Console.Write("Введите начало диапазона по горизонтали: ");
                    int HStart = int.Parse(Console.ReadLine());
                    Console.Write("Введите конец диапазона по горизонтали: ");
                    int HEnd = int.Parse(Console.ReadLine());
                    Console.Write("Введите начало диапазона по вертикали: ");
                    int VStart = int.Parse(Console.ReadLine());
                    Console.Write("Введите конец диапазона по вертикали: ");
                    int VEnd = int.Parse(Console.ReadLine());

                    HorizontDiapozon(HStart, HEnd, VStart, VEnd);

                    Console.WriteLine();

                    HorizontLine(HStart, HEnd, VStart, VEnd);

                    Console.WriteLine();

                    VerticalDiapozon(HStart, HEnd, VStart, VEnd);

                    Console.ReadLine();
                }
                catch (Exception)
                {
                    Console.WriteLine("Некоректный ввод числа " );
                    Console.ReadLine();
                }
            }
        }
    }
}
