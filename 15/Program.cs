using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15
{
    class Program
    {
        static void Main(string[] args)
        {
            string ingreso;
            bool flag1 = false;
            Int32 nroint;
            bool flag2 = false;
            decimal nrodec;

            Console.WriteLine("Ingrese un texto a comprobar");
            ingreso = Console.ReadLine();

            flag1 = Int32.TryParse(ingreso, out nroint);
            flag2 = decimal.TryParse(ingreso, out nrodec);

            if (flag1 == true || flag2 == true)
            {
                Console.WriteLine("el valor introducido es numerico");
            }
            else
            {
                Console.WriteLine("el valor introducido NO es numerico");
            }

            Console.ReadKey();
        }
    }
}
