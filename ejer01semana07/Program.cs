using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el valor de n: ");
            int n = int.Parse(Console.ReadLine());

            double suma = 0;

            for (int i = 1; i <= n; i++)
            {
                double termino = (16 - i) / (3.0 * i);
                suma += termino;
                Console.WriteLine("Resultado : " + suma);
            }

            Console.WriteLine(+suma);
            Console.ReadKey();

        }
    }
}
