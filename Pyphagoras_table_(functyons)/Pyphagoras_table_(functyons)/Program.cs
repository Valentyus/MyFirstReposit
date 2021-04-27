using System;

namespace Pyphagoras_table__functyons_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Таблица Пифагора!\n");
            Console.Write("Введите начало диапазона по горизонтали: ");
            int HStart = int.Parse(Console.ReadLine());
            Console.Write("Введите конец диапазона по горизонтали: ");
            int HEnd = int.Parse(Console.ReadLine());
            Console.Write("Введите начало диапазона по вертикали: ");
            int VStart = int.Parse(Console.ReadLine());
            Console.Write("Введите конец диапазона по вертикали: ");
            int VEnd = int.Parse(Console.ReadLine());

            /* ___|__9__10__11
             * ---+-----------
             * __9|_81__90__99
             * _10|_90_100_111
             * _11|_99_110_121
             */

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

            Console.WriteLine();

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

            Console.WriteLine();

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
        }
    }
}
