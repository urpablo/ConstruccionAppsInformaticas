using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio._13
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

            if (texto1.Length == texto2.Length)
            {
                Console.WriteLine("Las lineas tienen la misma longitud");
            }
            else
            {
                Console.WriteLine("las lineas no tienen la misma longitud");
            }
            Console.ReadKey();
        }
    }
}
