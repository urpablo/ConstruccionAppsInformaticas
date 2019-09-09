using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio._8
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1; //= "books pencil pen ruler";
            string s2 = "fin";

            Console.WriteLine("Ingrese una frase");
            s1 = Console.ReadLine();
            if (s1.Contains(s2) && s2 != "")
            {
                Console.WriteLine("La palabra fin se encuentra en el texto");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("La palabra fin NO se encuentra en el texto");
                Console.ReadLine();
            }
        }
    }
}
