using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio._37
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena;
            bool flag = false;

            do
            {
                Console.WriteLine("Ingrese un texto entre 10 y 20 caracteres");
                cadena = Console.ReadLine();

                if (cadena.Length > 20 || cadena.Length < 10)
                {
                    Console.WriteLine("el texto ingresado no cumple con las condiciones");
                    flag = false;
                }
                else
                {
                    flag = true;
                }
            } while (flag==false);

            Console.WriteLine(cadena);
            Console.ReadKey();

        }
    }
}
