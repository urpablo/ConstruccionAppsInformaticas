using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio._22
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime fecha = DateTime.Now;
            string strfecha;

            strfecha = fecha.ToString("dd/MM/yyyy");

            Console.WriteLine(strfecha);
            Console.ReadKey();
        }
    }
}
