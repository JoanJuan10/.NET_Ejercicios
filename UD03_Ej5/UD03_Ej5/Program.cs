using System;

namespace UD03_Ej5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 3;
            int c = 6;
            int d = 10;

            int guardarB = b;

            b = c;
            c = a;
            a = d;
            d = guardarB;

            Console.WriteLine("A = {0}", a);
            Console.WriteLine("B = {0}", b);
            Console.WriteLine("C = {0}", c);
            Console.WriteLine("D = {0}", d);
        }
    }
}
