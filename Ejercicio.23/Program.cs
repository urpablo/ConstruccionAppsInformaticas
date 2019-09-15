using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio._23
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime fecha;
            string strfecha;
            bool flag=false;

            Console.WriteLine("Ingrese una fecha: ");
            strfecha = Console.ReadLine();

            do
            {
                Console.WriteLine("Ingrese una fecha: ");
                strfecha = Console.ReadLine();
                flag= DateTime.TryParse(strfecha, out fecha);

                if (flag == false||strfecha=="")
                {
                    Console.WriteLine("ingrese una fecha valida y no vacia");
                }
            } while (flag==false);

            Console.ReadKey();
        }
    }
}
