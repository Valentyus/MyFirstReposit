using System;

namespace Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter numbers of colums ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number sof lines ");
            int y = int.Parse(Console.ReadLine());
            int a = 0;

            while (a < x)
            {
                
                int b = 0;
                while (b < y)
                {
                    Console.Write("*");
                    b++;
                }

            Console.WriteLine();
            a++;
                        
            }
        }
    }
}
