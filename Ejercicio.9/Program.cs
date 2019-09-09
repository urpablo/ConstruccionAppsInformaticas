using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio._9
{
    class Program
    {
        static void Main(string[] args)
        {
            string ingreso;
            Console.WriteLine("Ingrese un texto");
            ingreso = Console.ReadLine();
            Console.WriteLine("Su ingreso en mayusculas es: "+ingreso.ToUpper());
            Console.ReadKey();

        }
    }
}
