using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio._17
{
    class Program
    {
        static void Main(string[] args)
        {
            string nro1;
            string nro2;
            bool flag1=false;
            bool flag2 = false;
            decimal n1;
            decimal n2;

            do
            {
                Console.WriteLine("Ingrese el nro 1 ");
                nro1 = Console.ReadLine();
                Console.WriteLine("Ingrese el nro 2 ");
                nro2 = Console.ReadLine();

                flag1 = decimal.TryParse(nro1, out n1);
                flag2 = decimal.TryParse(nro2, out n2);

                if (flag1 == false || flag2 == false || nro1 == "" || nro2 == "")
                {
                    Console.WriteLine("Ingrese valores numericos no vacios");
                }

            } while (flag1 == false || flag2 == false || nro1 == "" || nro2 == "");


            Console.WriteLine("la suma es: "+(n1+n2));
            Console.WriteLine("la resta es: " + (n1 - n2));
            Console.WriteLine("la multi es: " + n1 * n2);
            Console.WriteLine("la division es: " + n1 / n2);
            Console.WriteLine("la resto es: " + n1 % n2);
            //Console.WriteLine("el primero elevado al segundo es: " + (n1^n2));
            Console.ReadKey();
        }
    }
}
