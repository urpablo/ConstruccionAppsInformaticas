using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio._12
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto1;
            string texto2;

            Console.WriteLine("Ingrese el texto 1 ");
            texto1 = Console.ReadLine();
            Console.WriteLine("Ingrese el texto 2 ");
            texto2 = Console.ReadLine();

            if (texto1 == texto2)
            {
                Console.WriteLine("Las lineas son iguales");
            }
            else
            {
                Console.WriteLine("las lineas no son iguales");
            }
            Console.ReadKey();

        }
    }
}
