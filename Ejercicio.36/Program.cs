using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio._36
{
    class Program
    {
        static void Main(string[] args)
        {
            string strfecha;
            bool flag = false;
            DateTime fecha;

            do
            {
                Console.WriteLine("Ingrese una fecha");
                strfecha = Console.ReadLine();

                flag = DateTime.TryParse(strfecha, out fecha);

                if (flag == false)
                {
                    Console.WriteLine("Ingrese una fecha valida");
                }

            } while (flag==false);

            Console.WriteLine(fecha);
            Console.ReadKey();


        }
    }
}
