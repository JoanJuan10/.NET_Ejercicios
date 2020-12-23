using System;

namespace UD03_Ej1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 4;
            int numero2 = 2;

            Console.WriteLine("Suma: {0} + {1} = {2}", numero, numero2, numero + numero2);
            Console.WriteLine("Resta: {0} - {1} = {2}", numero, numero2, numero - numero2);
            Console.WriteLine("Multiplicacion: {0} * {1} = {2}", numero, numero2, numero * numero2);
            Console.WriteLine("Division: {0} / {1} = {2}", numero, numero2, numero / numero2);
            Console.WriteLine("Residuo: {0} % {1} = {2}", numero, numero2, numero % numero2);
        }
    }
}
