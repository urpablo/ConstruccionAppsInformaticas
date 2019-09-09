using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio._10
{
    class Program
    {
        static void Main(string[] args)
        {
            string ingreso;
            Console.WriteLine("Ingrese un texto");
            ingreso = Console.ReadLine();
            Console.WriteLine("Su ingreso en minusculas es: " + ingreso.ToLower());
            Console.ReadKey();
        }
    }
}
