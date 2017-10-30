using System;

namespace ConsoleApp1
{
    class Program
    {

        static readonly int a = 5;
        static readonly int wx = 7 * a;
        static readonly int wy = 5 * a;

        static bool IsBlack(int x, int y)
        {
            var isBlackX  = (x % (2*a)) > a - 1;
            var isEvenRow = (y % (2*a)) > a - 1;
            var isBlack = isEvenRow ? isBlackX : !isBlackX;
            return isBlack;
        }

        static void Main(string[] args)
        {
            for (int y = 0; y < wy; y++)
            {
                for (int x = 0; x < wx; x++)
                {
                    Console.Write(IsBlack(x,y) ? "X" : " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}