using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio._11
{
    class Program
    {
        static void Main(string[] args)
        {
            string mystring;

            Console.WriteLine("Ingrese su texto");
          
            mystring = Console.ReadLine();
            mystring = mystring.Replace("á", "a");
            mystring = mystring.Replace("é", "e");
            mystring = mystring.Replace("í", "i");
            mystring = mystring.Replace("ó", "o");
            mystring = mystring.Replace("ú", "u");

            Console.WriteLine(mystring);
            Console.ReadKey();

        }
    }
}
