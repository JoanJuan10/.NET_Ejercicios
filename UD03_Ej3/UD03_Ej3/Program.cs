using System;

namespace UD03_Ej3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Definición de variables
            int x = 3;
            int y = 4;
            double n = 5.8;
            double m = 1.2;

            // Mostramos las variables

            Console.WriteLine("X = {0}", x);
            Console.WriteLine("Y = {0}", y);
            Console.WriteLine("N = {0}", n);
            Console.WriteLine("M = {0}", m);

            Console.WriteLine();

            // Suma, diferencia, producto, cociente y resto de x e y
            Console.WriteLine("{0} + {1} = {2}", x, y, x + y);
            Console.WriteLine("{0} - {1} = {2}", x, y, x - y);
            Console.WriteLine("{0} * {1} = {2}", x, y, x * y);
            Console.WriteLine("{0} / {1} = {2}", x, y, x / y);
            Console.WriteLine("{0} % {1} = {2}", x, y, x % y);

            Console.WriteLine();

            // Suma, diferencia, producto, cociente y resto de n y m

            Console.WriteLine("{0} + {1} = {2}", n, m, n + m);
            Console.WriteLine("{0} - {1} = {2}", n, m, n - m);
            Console.WriteLine("{0} * {1} = {2}", n, m, n * m);
            Console.WriteLine("{0} / {1} = {2}", n, m, n / m);
            Console.WriteLine("{0} % {1} = {2}", n, m, n % m);

            Console.WriteLine();

            // Operaciones cruzadas

            Console.WriteLine("{0} + {1} = {2}", x, n, x + n);
            Console.WriteLine("{0} / {1} = {2}", y, m, y / m);
            Console.WriteLine("{0} % {1} = {2}", y, m, y % m);

            Console.WriteLine();

            // El doble de cada variable

            Console.WriteLine("X * 2 = {0}", x * 2);
            Console.WriteLine("Y * 2 = {0}", y * 2);
            Console.WriteLine("N * 2 = {0}", n * 2);
            Console.WriteLine("M * 2 = {0}", m * 2);

            Console.WriteLine();

            // Suma y producto de todas las variables

            Console.WriteLine("X + Y + N + M = {0}", x + y + n + m);
            Console.WriteLine("X * Y * N * M = {0}", x * y * n * m);




        }
    }
}
