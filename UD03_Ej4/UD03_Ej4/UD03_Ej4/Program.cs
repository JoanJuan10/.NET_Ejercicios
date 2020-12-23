using System;

namespace UD03_Ej4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 3;

            // Mostramos valor inicial
            Console.WriteLine("Valor inicial de N = {0}", n);

            // Valor sumado a 77
            n += 77;
            Console.WriteLine("N + 77 = {0}", n);

            // Valor restado a 3
            n -= 3;
            Console.WriteLine("N - 3 = {0}", n);

            // Valor multiplicado por 2
            n *= 2;
            Console.WriteLine("N * 2 = {0}", n);

        }
    }
}