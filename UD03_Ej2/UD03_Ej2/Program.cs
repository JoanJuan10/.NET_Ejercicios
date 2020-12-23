using System;

namespace UD03_Ej2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            double a = 4.56;
            char c = 'a';

            Console.WriteLine("N = {0}", n);
            Console.WriteLine("A = {0}", a);
            Console.WriteLine("C = {0}", c);

            Console.WriteLine("{0} + {1} = {2}", n, a, n + a);
            Console.WriteLine("{0} - {1} = {2}", a, n, a - n);
            Console.WriteLine("Numerico de C = {0}", (int)c);
        }
    }
}
