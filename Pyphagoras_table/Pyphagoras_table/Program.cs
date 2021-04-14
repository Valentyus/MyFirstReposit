using System;

namespace Pyphagoras_table
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первый номер по горизонтали: ");
            int hStart = int.Parse(Console.ReadLine());
            Console.Write("Введите последний номер по горизонтали: ");
            int hEnd = int.Parse(Console.ReadLine());
            Console.Write("Введите первый номер по вертикали: ");
            int vStart = int.Parse(Console.ReadLine());
            Console.Write("Введите последний номер по вертикали: ");
            int vEnd = int.Parse(Console.ReadLine());
            int max = hEnd * vEnd;
            int hFirstNumb = hStart;

            /*   |  9  10  11
             * --+-----------
             *  9| 81  90  99
             * 10| 90 100 110
             * 11| 99 111 121
             */

            Console.WriteLine();
            for (int space = 0, spaceEnd = vEnd; space < spaceEnd; spaceEnd /= 10)
            {
                Console.Write(" ");
            }

            Console.Write("|");

            int Vertmax = hFirstNumb * vEnd;
            while (hFirstNumb <= hEnd)
            {
                Console.Write(" ");
                int horSpace = hFirstNumb;
                int space = 0;
                while (horSpace > 0)
                {
                    horSpace /= 10;
                    space++;
                }
                Vertmax = hFirstNumb * vEnd; int spaceEnd = 0;
                while (Vertmax > 0)
                {
                    Vertmax /= 10;
                    spaceEnd++;
                }
                while (space != spaceEnd)
                {
                    Console.Write(" ");
                    spaceEnd--;
                }
                Console.Write(hFirstNumb);
                hFirstNumb++;
            }

            Console.WriteLine();

            max = hEnd * vEnd;
            for (int space = 0, spaceEnd = vEnd; space < spaceEnd; spaceEnd /= 10)
            {
                Console.Write("-");
            }

            Console.Write("+");

            hFirstNumb = hStart;
            while (hFirstNumb <= hEnd)
            {
                max = hEnd * vEnd;
                while (hFirstNumb < max)
                {
                    Console.Write("-");
                    max /= 10;
                }
                for (int line = hFirstNumb; line != 0; line /= 10)
                {
                    Console.Write("-");
                }
                hFirstNumb++;
            }
            Console.WriteLine();

            while (vStart <= vEnd)
            {
                int vFirstNumb = vStart, space = 0;
                while (vFirstNumb > 0)
                {
                    vFirstNumb /= 10;
                    space++;
                }
                int vEndNumb = vEnd, spaceEnd = 0;
                while (vEndNumb > 0)
                {
                    vEndNumb /= 10;
                    spaceEnd++;
                }
                if (space != spaceEnd)
                {
                    Console.Write(" ");
                }
                Console.Write(vStart);
                 
                Console.Write("|");

                hFirstNumb = hStart;
                while (hFirstNumb <= hEnd)
                {
                    Console.Write(" ");
                    int result = hFirstNumb * vStart;
                    space = 0;
                    while (result > 0)
                    {
                        result /= 10;
                        space++;
                    }
                    Vertmax = hFirstNumb * vEnd; spaceEnd = 0;
                    while (Vertmax > 0)
                    {
                        Vertmax /= 10;
                        spaceEnd++;
                    }
                    while (space != spaceEnd)
                    {
                        Console.Write(" ");
                        spaceEnd--;
                    }

                    Console.Write(hFirstNumb * vStart);
                    hFirstNumb++;
                }
                vStart++;
                Console.WriteLine();
            }
        }
    }
}
