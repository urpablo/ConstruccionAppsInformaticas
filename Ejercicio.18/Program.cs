using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio._18
{
    class Program
    {
        static void Main(string[] args)
        {
            string strnro1;
            Int32 decimales = 2;
            decimal nro1;
            decimal redondeado;

            Console.WriteLine("ingrese numero decimal: ");
            strnro1= Console.ReadLine();

            nro1 = decimal.Parse(strnro1);
            redondeado=Decimal.Round(nro1, decimales);


            Console.Write(redondeado);
            Console.ReadKey();


        }
    }
}
