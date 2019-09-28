using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio._41
{
    class Program
    {
        static void Main(string[] args)
        {
            string strFecha;
            bool flag = false;
            DateTime Fecha;
            bool RtaFlag = false;
            int i = 0;
            string Rta;
            var numeros = new List<DateTime>();

            do
            {
                do
                {
                    Console.WriteLine("Ingrese una fecha");
                    strFecha = Console.ReadLine();
                    flag = DateTime.TryParse(strFecha, out Fecha);

                    if (flag == false)
                    {
                        Console.WriteLine("Debe ingresar una fecha no vacia");
                    }

                } while (flag == false);

                i = i + 1;
                numeros.Add(Fecha);

                Console.WriteLine("Desea seguir agregando Fechas?");
                Rta = Console.ReadLine();

                if (Rta == "No")
                {
                    RtaFlag = true;
                }

            } while (RtaFlag == false);

            numeros.Sort();

            foreach (DateTime value in numeros)
            {
                Console.WriteLine(value);
            }


            //foreach (DateTime s in numeros)
            //  Console.WriteLine(s.ToString("dd/MM/yyyy"));

            // do
            //   {
            //    Console.WriteLine(numeros[i - 1].ToString("dd/MM/yyyy"));
            //    i = i - 1;
            // } while (i != 0);


            Console.ReadKey();
        }
    }
}
